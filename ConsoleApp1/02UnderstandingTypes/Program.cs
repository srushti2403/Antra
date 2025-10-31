// See https://aka.ms/new-console-template for more information

using System;

namespace UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // The format string uses {index, alignment} to align the columns:
            // {0, -10}: Left-align the type name in a 10-character field.
            // {1, -15}: Left-align the byte size in a 15-character field.
            // {2, -37}: Left-align the min value in a 37-character field.
            // {3, -37}: Left-align the max value in a 37-character field.
            string format = "| {0, -7} | {1, -15} | {2, -37} | {3, -37} |";

            // sbyte
            Console.WriteLine(format,
                nameof(sbyte),
                sizeof(sbyte),
                sbyte.MinValue.ToString("N0"),
                sbyte.MaxValue.ToString("N0"));

            // byte
            Console.WriteLine(format,
                nameof(byte),
                sizeof(byte),
                byte.MinValue.ToString("N0"),
                byte.MaxValue.ToString("N0"));

            // short
            Console.WriteLine(format,
                nameof(short),
                sizeof(short),
                short.MinValue.ToString("N0"),
                short.MaxValue.ToString("N0"));

            // ushort
            Console.WriteLine(format,
                nameof(ushort),
                sizeof(ushort),
                ushort.MinValue.ToString("N0"),
                ushort.MaxValue.ToString("N0"));

            // int
            Console.WriteLine(format,
                nameof(int),
                sizeof(int),
                int.MinValue.ToString("N0"),
                int.MaxValue.ToString("N0"));

            // uint
            Console.WriteLine(format,
                nameof(uint),
                sizeof(uint),
                uint.MinValue.ToString("N0"),
                uint.MaxValue.ToString("N0"));

            // long
            Console.WriteLine(format,
                nameof(long),
                sizeof(long),
                long.MinValue.ToString("N0"),
                long.MaxValue.ToString("N0"));

            // ulong
            Console.WriteLine(format,
                nameof(ulong),
                sizeof(ulong),
                ulong.MinValue.ToString("N0"),
                ulong.MaxValue.ToString("N0"));
            
            // float
            Console.WriteLine(format,
                nameof(float),
                sizeof(float),
                float.MinValue,
                float.MaxValue);
            
            // double
            Console.WriteLine(format,
                nameof(double),
                sizeof(double),
                double.MinValue,
                double.MaxValue);
            
            // decimal
            // Note: Decimal Min/Max is displayed in scientific notation as the full number is too long.
            Console.WriteLine(format,
                nameof(decimal),
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue);
        }
    }
}