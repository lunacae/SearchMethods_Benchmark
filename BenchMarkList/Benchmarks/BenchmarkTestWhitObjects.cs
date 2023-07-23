using BenchmarkDotNet.Attributes;
using BenchMarkList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkList.Benchmarks
{
    [RankColumn(0)]
    [MemoryDiagnoser]
    public class BenchmarkTestWhitObjects
    {
        int NumeroDeItens = 500000;
        List<string> foolNames = new List<string>(5)
        {
            "Topya",
            "Nimona",
            "SourCandy",
            "Lemon",
            "Friday"
        };

        List<string> foolTypes = new List<string>(5)
        {
            "name",
            "day",
            "food",
            "fruit",
            "test"
        };

        [Benchmark]
        public int BinarySearchWithOrdenedList()
        {
            var test = CreateFoolListOrdened();
            var foolTest = new FoolClass()
            {
                id = 5000,
                foolName = foolNames[0],
                foolType = foolTypes[0]
            };
            var result = test.BinarySearch(foolTest, new ValueComparer<FoolClass>());
            //var searchIdResult = test[result];
            //Console.WriteLine(searchIdResult);
            return result;
        }
        [Benchmark]
        public int BinarySearchWithUnordenedList()
        {
            var test = CreateFoolListUnordened();
            var foolTest = new FoolClass()
            {
                id = 5000,
                foolName = foolNames[0],
                foolType = foolTypes[0]
            };
            var result = test.BinarySearch(foolTest, new ValueComparer<FoolClass>());
            //var searchIdResult = test[result];
            //Console.WriteLine(searchIdResult);
            return result;
        }

        [Benchmark]
        public FoolClass? FindWithOrdenedList()
        {
            var test = CreateFoolListOrdened();
            var result = test.Find(a => a.id == 5000);
            //Console.WriteLine(result?.id ?? 0);
            return result;
        }

        [Benchmark]
        public FoolClass? FindWithUnordenedList()
        {
            var test = CreateFoolListUnordened();
            var result = test.Find(a => a.id == 5000);
            //Console.WriteLine(result?.id ?? 0);
            return result;
        }


        public List<FoolClass> CreateFoolListUnordened()
        {
            List<FoolClass> fool = new();
            Random randNum = new Random();

            for (int i = 0; i <=  NumeroDeItens; i++)
            {
                var foolObject = new FoolClass();
                foolObject.id = randNum.Next(0, 100000);
                foolObject.foolName = foolNames[i % 5];
                foolObject.foolType = foolTypes[i % 5];
                fool.Add(foolObject);
            }

            return fool;
        }

        public List<FoolClass> CreateFoolListOrdened()
        {
            List<FoolClass> fool = new();

            for (int i = 0; i <= NumeroDeItens; i++)
            {
                var foolObject = new FoolClass();
                foolObject.id = i;
                foolObject.foolName = foolNames[i % 5];
                foolObject.foolType = foolTypes[i % 5];
                fool.Add(foolObject);
            }

            return fool;
        }
    }
}
