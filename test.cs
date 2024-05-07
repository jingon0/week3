using csbemt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class test
    {
        static void Main(string[] args)
        { 
            ReadData Read = new ReadData();

            List<double> airfoil_alpha = new List<double>();
            List<double> airfoil_Cl = new List<double>();
            List<double> airfoil_Cd = new List<double>();

            int length = airfoil_alpha.Count;

            Read.Airfoil_dat("C:\\Users\\goni0\\source\\repos\\week2\\ConsoleApp1\\NACA_0012.dat", airfoil_alpha, airfoil_Cl, airfoil_Cd);

            for (int i= 0; i < airfoil_Cl.Count; i++)
            {
                Console.WriteLine(airfoil_Cl[i]);
            }
            Console.WriteLine();
        }
     }
}
