``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT


```
|          Method |          Mean |        Error |        StdDev | MValue | Rank |
|---------------- |--------------:|-------------:|--------------:|-------:|-----:|
|   TestSearch100 |      67.16 μs |     1.325 μs |      1.813 μs |  2.000 |    1 |
|  TestSearch1000 |   2,554.25 μs |    48.356 μs |     47.492 μs |  2.000 |    2 |
| TestSearch10000 | 243,667.16 μs | 5,136.789 μs | 14,738.411 μs |  2.000 |    3 |
