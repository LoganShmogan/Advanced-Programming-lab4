```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3323)
13th Gen Intel Core i7-13620H, 1 CPU, 16 logical and 10 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  Job-NUDCFI : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

IterationCount=10  

```
| Method           | Mean            | Error         | StdDev      | Median          | Gen0   | Allocated |
|----------------- |----------------:|--------------:|------------:|----------------:|-------:|----------:|
| Do               |       0.0008 ns |     0.0019 ns |   0.0012 ns |       0.0000 ns |      - |         - |
| ArraySort        | 339,340.6413 ns | 1,255.5085 ns | 747.1330 ns | 339,478.8574 ns | 2.9297 |   40024 B |
| ListSort         | 338,343.9795 ns | 1,472.1741 ns | 973.7520 ns | 338,221.5576 ns | 2.9297 |   40056 B |
| TestLinearSearch |   2,647.9213 ns |    11.5343 ns |   7.6292 ns |   2,646.6875 ns |      - |         - |
| TestBinarySearch |      11.7599 ns |     0.1298 ns |   0.0859 ns |      11.7512 ns |      - |         - |
