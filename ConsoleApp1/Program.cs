using BlakeIshoyAlgorithms.MathAlgorithms;
using System;
using System.Linq;

namespace BlakeIshoyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var output = Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
            //var output = MathTools.LargestPrimeFactor(600851475143);
            var output = MathTools.Permute(new int[3] { 1, 2, 3 });

            Console.WriteLine(output);
        }

        
    }
}
