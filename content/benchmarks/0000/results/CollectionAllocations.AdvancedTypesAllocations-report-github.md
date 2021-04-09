``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-8665U CPU 1.90GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-XMOFIM : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-JFNHCL : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-BOGPDX : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-IAPZBU : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-FVTULY : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-PMTURM : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-DQLYWR : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


```
|    Method |        Job | MinInvokeCount | LaunchCount | MaxIterationCount | MaxWarmupIterationCount | MinIterationCount | MinWarmupIterationCount | WarmupCount |         Mean |       Error |      StdDev |       Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|---------- |----------- |--------------- |------------ |------------------ |------------------------ |------------------ |------------------------ |------------ |-------------:|------------:|------------:|-------------:|-------:|-------:|-------:|----------:|
|    Thread | Job-XMOFIM |        Default |           1 |           Default |                 Default |           Default |                 Default |     Default | 3,875.659 ns |  76.6788 ns | 114.7692 ns | 3,874.363 ns | 0.2594 | 0.2594 | 0.2594 |     192 B |
| Stopwatch | Job-XMOFIM |        Default |           1 |           Default |                 Default |           Default |                 Default |     Default |     6.471 ns |   0.2419 ns |   0.2263 ns |     6.410 ns | 0.0096 |      - |      - |      40 B |
|    Thread | Job-JFNHCL |        Default |     Default |                16 |                 Default |           Default |                 Default |     Default | 3,847.377 ns | 225.7193 ns | 221.6866 ns | 3,811.216 ns | 0.2518 | 0.2518 | 0.2518 |     192 B |
| Stopwatch | Job-JFNHCL |        Default |     Default |                16 |                 Default |           Default |                 Default |     Default |     6.470 ns |   0.2293 ns |   0.2145 ns |     6.446 ns | 0.0096 |      - |      - |      40 B |
|    Thread | Job-BOGPDX |        Default |     Default |           Default |                       7 |           Default |                 Default |     Default | 4,587.079 ns | 190.8288 ns | 562.6631 ns | 4,564.795 ns | 0.1450 | 0.1450 | 0.1450 |     192 B |
| Stopwatch | Job-BOGPDX |        Default |     Default |           Default |                       7 |           Default |                 Default |     Default |     7.559 ns |   0.3484 ns |   1.0272 ns |     7.249 ns | 0.0095 |      - |      - |      40 B |
|    Thread | Job-IAPZBU |        Default |     Default |           Default |                 Default |                 1 |                 Default |     Default | 3,792.396 ns |  69.1760 ns | 121.1562 ns | 3,800.788 ns | 0.2823 | 0.2823 | 0.2823 |     192 B |
| Stopwatch | Job-IAPZBU |        Default |     Default |           Default |                 Default |                 1 |                 Default |     Default |     5.851 ns |   0.2367 ns |   0.1848 ns |     5.825 ns | 0.0096 |      - |      - |      40 B |
|    Thread | Job-FVTULY |        Default |     Default |           Default |                 Default |           Default |                       1 |     Default | 3,702.323 ns |  74.0667 ns | 110.8596 ns | 3,709.700 ns | 0.2441 | 0.2441 | 0.2441 |     192 B |
| Stopwatch | Job-FVTULY |        Default |     Default |           Default |                 Default |           Default |                       1 |     Default |     5.651 ns |   0.1660 ns |   0.1553 ns |     5.651 ns | 0.0096 |      - |      - |      40 B |
|    Thread | Job-PMTURM |        Default |     Default |           Default |                 Default |           Default |                 Default |           1 | 3,632.863 ns |  69.8729 ns |  88.3668 ns | 3,606.241 ns | 0.2518 | 0.2518 | 0.2518 |     192 B |
| Stopwatch | Job-PMTURM |        Default |     Default |           Default |                 Default |           Default |                 Default |           1 |     5.666 ns |   0.1686 ns |   0.1577 ns |     5.690 ns | 0.0096 |      - |      - |      40 B |
|    Thread | Job-DQLYWR |              1 |     Default |           Default |                 Default |           Default |                 Default |     Default | 3,654.189 ns |  72.3239 ns |  91.4666 ns | 3,611.645 ns | 0.2747 | 0.2747 | 0.2747 |     192 B |
| Stopwatch | Job-DQLYWR |              1 |     Default |           Default |                 Default |           Default |                 Default |     Default |     6.971 ns |   0.2685 ns |   0.3935 ns |     6.886 ns | 0.0096 |      - |      - |      40 B |
