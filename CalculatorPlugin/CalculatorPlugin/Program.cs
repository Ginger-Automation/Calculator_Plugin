using Amdocs.Ginger.Plugin.Core;
using System;

namespace CalculatorPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Ginger calculator Plugin");

            using (GingerNodeStarter gingerNodeStarter = new GingerNodeStarter())
            {
                gingerNodeStarter.StartNode("calculator Service", new CalculatorService());
                gingerNodeStarter.Listen();
            }
        }
    }
}
