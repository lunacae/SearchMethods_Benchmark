using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchMarkList.Benchmarks
{
    [RankColumn(0)]
    [MemoryDiagnoser]
    public class BenchmarkTestWithLists
    {
        int NumeroDeItens = 100000;
        [Benchmark]
        public int BinarySearchOrdened()
        {
            var test = new List<int>();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(i);
            }
            return test.BinarySearch(5000);
        }

        [Benchmark]
        public int BinarySearchUnordenedWithSort()
        {
            //cria e ordena
            var test = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(randNum.Next(0, 10000));
            }
            test.Sort();
            return test.BinarySearch(5000);
        }

        [Benchmark]
        public int FirstOrDefaultOrdened()
        {
            var list = new List<int>();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                list.Add(i);
            }
            return list.FirstOrDefault(a => a == 5000);
        }

        [Benchmark]
        public int FirstOrDefaultUnordened()
        {
            var test = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(randNum.Next(0, 10000));
            }
            return test.FirstOrDefault(a => a == 5000);
        }

        //[Benchmark]
        public int FirstOrDefaultUnordenedWithSort()
        {
            var test = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(randNum.Next(0, 10000));
            }
            test.Sort();
            return test.FirstOrDefault(a => a == 5000);
        }


        [Benchmark]
        public int FindOrdened()
        {
            var list = new List<int>();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                list.Add(i);
            }
            return list.Find(a => a == 5000);
        }
        [Benchmark]
        public int FindUnordened()
        {
            var test = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(randNum.Next(0, 10000));
            }
            return test.Find(a => a == 5000);
        }

        //[Benchmark]
        public int FindUnordenedWithSort()
        {
            var test = new List<int>();
            Random randNum = new Random();
            for (int i = 0; i < NumeroDeItens; i++)
            {
                test.Add(randNum.Next(0, 10000));
            }
            test.Sort();
            return test.Find(a => a == 5000);
        }

    }
}
