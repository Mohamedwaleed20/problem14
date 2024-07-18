using System.Runtime.CompilerServices;
using static problem14.Class1;

namespace problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator<int> intCalculator = new calculator<int>();
            calculator<int>.AddDelegate addDelegate = (a, b) => a + b;
            calculator<int>.SubDelegate subDelegate = (a,b) => a - b;
            calculator<int>.MulDelegate mulDelegate = (a,b) => a * b;
            calculator<int>.DivDelegate divDelegate = (a,b) => a/ b;
            int sum = intCalculator.addDelegate(10, 5, addDelegate);
            int difference = intCalculator.subtractDelegate(10, 5, subDelegate);
            int product = intCalculator.multiplyDelegate(10, 5, mulDelegate);
            int quotient = intCalculator.divideDelegate(10, 5, divDelegate);
            Console.WriteLine($"""
                Sum: {sum}
                Difference: {difference}
                Product: {product}
                Quotient: {quotient}
                """);

            Console.ReadLine();
        }
    }
}
