using System;
using System.IO;
namespace Ch02Ex03Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i <85; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            Console.WriteLine(format: "{0,-10} {1,6} {2,20} {3,35}","type", "Byte(s) of memory","min","max");
            for (int i = 0; i < 85; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}","sbyte",$"{sizeof(sbyte)}",$"{sbyte.MinValue}",$"{sbyte.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "byte", $"{sizeof(byte)}", $"{byte.MinValue}", $"{byte.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "short", $"{sizeof(short)}", $"{short.MinValue}", $"{short.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "ushort", $"{sizeof(ushort)}", $"{ushort.MinValue}", $"{ushort.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "int", $"{sizeof(int)}", $"{int.MinValue}", $"{int.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "uint", $"{sizeof(uint)}", $"{uint.MinValue}", $"{uint.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "long", $"{sizeof(long)}", $"{long.MinValue}", $"{long.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "ulong", $"{sizeof(ulong)}", $"{ulong.MinValue}", $"{ulong.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "double", $"{sizeof(double)}", $"{double.MinValue}", $"{double.MaxValue}");
            Console.WriteLine(format: "{0,-10} {1,6} {2,31} {3,35}", "decimal", $"{sizeof(decimal)}", $"{decimal.MinValue}", $"{decimal.MaxValue}");

            for (int i = 0; i < 85; i++)
            {
                Console.Write("_");
            }
            Console.ReadKey();


        }
    }
}
