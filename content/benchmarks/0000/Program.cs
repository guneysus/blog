using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionAllocations
{

    public class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfig.Instance
                    .With(Job.Default.WithMinInvokeCount(1))
                    .With(Job.Default.WithMinIterationCount(1))
                    .With(Job.Default.WithMinWarmupCount(1))

                    .With(Job.Default.WithLaunchCount(1))
                    .With(Job.Default.WithWarmupCount(1))

                    .With(Job.Default.WithMaxIterationCount(16))
                    .With(Job.Default.WithMaxWarmupCount(7));

            BenchmarkRunner.Run<PrimitiveTypesAllocation>(config);
            BenchmarkRunner.Run<ArrayAllocation>(config);
            BenchmarkRunner.Run<CollectionsAllocations>(config);
            BenchmarkRunner.Run<AdvancedTypesAllocations>(config);
        }
    }

    [MemoryDiagnoser]
    public class PrimitiveTypesAllocation
    {
        [Benchmark] public bool Bool() => true;
        [Benchmark] public byte Byte() => byte.MaxValue;
        [Benchmark] public char Char() => char.MaxValue;
        [Benchmark] public string String() => string.Empty;
        [Benchmark] public int Int() => int.MaxValue;
        [Benchmark] public short Short() => short.MaxValue;
        [Benchmark] public long Long() => long.MaxValue;
        [Benchmark] public float Float() => float.MaxValue;
        [Benchmark] public Single Single() => System.Single.MaxValue;
        [Benchmark] public double Double() => double.MaxValue;
        [Benchmark] public decimal Decimal() => decimal.MaxValue;

    }

    [MemoryDiagnoser]
    public class ArrayAllocation
    {

        [Params(0, 8, 64, 512)]
        public int N { get; set; }


        [Benchmark] public int[] IntArray() => new int[N];
        [Benchmark] public char[] CharArray() => new char[N];

    }

    [MemoryDiagnoser]
    public class CollectionsAllocations
    {

        [Params(0, 8, 64, 512)]
        public int N { get; set; }

        [Benchmark] public List<int> IntList() => new List<int>(N);
        [Benchmark] public LinkedList<int> LinkedList() => new LinkedList<int>();
        [Benchmark] public ValueTuple<int, int> ValueTupleIntInt() => (int.MaxValue, int.MaxValue);
        [Benchmark] public Tuple<int, int> TupleIntInt() => new Tuple<int, int>(int.MaxValue, int.MaxValue);
        [Benchmark] public Task<int> TaskInt() => Task.FromResult(int.MaxValue);
        [Benchmark] public ValueTask ValueTask() => new ValueTask();
        [Benchmark] public ReadOnlyCollection<int> EmptyReadOnlyCollection() => new ReadOnlyCollection<int>(new List<int>(N));


        [Benchmark] public Dictionary<int, int> DictIntInt() => new Dictionary<int, int>(N);
        [Benchmark] public ConcurrentDictionary<int, int> ConcurrentDictIntInt() => new ConcurrentDictionary<int, int>(2, N);
    }

    [MemoryDiagnoser]
    public class AdvancedTypesAllocations
    {

        [Benchmark] public Thread Thread() => new Thread(() => { });
        [Benchmark] public Stopwatch Stopwatch() => new Stopwatch();
    }
}
