using System.Numerics;

namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] _)
        {
            /*
             * 
             * no Comments necessary. This should be self-explanatory
             *
             */

            Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");
            Console.WriteLine($"nint: {nint.MinValue} to {nint.MaxValue}");
            Console.WriteLine($"nuint: {nuint.MinValue} to {nuint.MaxValue}");
            Console.WriteLine($"char: {(int)char.MinValue} to {(int)char.MaxValue}");
            Console.WriteLine($"DateTime: {DateTime.MinValue} to {DateTime.MaxValue}");
            Console.WriteLine($"DateOnly: {DateOnly.MinValue} to {DateOnly.MaxValue}");
            Console.WriteLine($"TimeOnly: {TimeOnly.MinValue} to {TimeOnly.MaxValue}");
            Console.WriteLine($"Guid: {Guid.Empty} to {Guid.Empty} (no Min/Max available)");
            Console.WriteLine($"Half: {Half.MinValue} to {Half.MaxValue}");
            Console.WriteLine($"BigInteger: {BigInteger.MinusOne * BigInteger.Pow(10, 100)} to {BigInteger.Pow(10, 100)} (no Min/Max available)");
            Console.WriteLine($"Int128: {Int128.MinValue} to {Int128.MaxValue}");
            Console.WriteLine($"UInt128: {UInt128.MinValue} to {UInt128.MaxValue}");
            Console.WriteLine($"IntPtr: {(nint)IntPtr.MinValue} to {(nint)IntPtr.MaxValue}");
            Console.WriteLine($"UIntPtr: {(nuint)UIntPtr.MinValue} to {(nuint)UIntPtr.MaxValue}");
            Console.WriteLine($"IntPtr Size: {IntPtr.Size * 8} bits");
            Console.WriteLine($"UIntPtr Size: {UIntPtr.Size * 8} bits");

        }
    }
}