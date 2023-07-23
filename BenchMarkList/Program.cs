using BenchmarkDotNet.Running;
using BenchMarkList.Benchmarks;

Console.WriteLine("### Usando BenchmarkDotNet  ###\n");
Console.WriteLine("Pressione algo para iniciar\n");
Console.ReadLine();
var test = new BenchmarkTestWithLists();
//test.BinarySearchUnordened();
var summary = BenchmarkRunner.Run<BenchmarkTestWithLists>();
//var summary2 = BenchmarkRunner.Run<BenchmarkTestWhitObjects>();