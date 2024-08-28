using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medelvärde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Skriv in ett heltal");
            double number = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Medelvärdet är: " + Medelvärde(number));
            Run();
        }
        
        static double Medelvärde(double number)
        {
            GlobalVariables.Sum += number;
            GlobalVariables.NumberAmount++;

            double medelVärde = GlobalVariables.Sum / GlobalVariables.NumberAmount;
            return medelVärde;
        }

        public class GlobalVariables
        {
            public static double Sum = 0;
            public static double NumberAmount = 0;
        }
    }
}
