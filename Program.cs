using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of the variable alpha in degrees");
            string v = Console.ReadLine();
            double alpha = double.Parse(v);
            double  sin2A = Math.Sin(Math.PI/180 * alpha);
            double cos2A = Math.Cos(2* Math.PI / 180 * alpha);
            double sin3A = Math.Sin(3 * Math.PI / 180 * alpha);
            double sin4A = Math.Sin(4 * Math.PI / 180 * alpha);
            double cos3A = Math.Cos(3 * Math.PI / 180 * alpha);
            double numerator = sin2A + sin3A - sin4A ;
            double denominator = cos2A + 1 + cos3A ;
            Console.WriteLine("y = {0}", numerator / denominator);//{} - интерполяцию загуглил


            Console.WriteLine("enter the value of the variable R");
            v = Console.ReadLine();
            double R = double.Parse(v);
            numerator = 1;
            denominator = Math.Pow(2 * R + 3, 0.5);
            Console.WriteLine("x = {0}", numerator / denominator); //{} - интерполяцию загуглил
            Console.ReadKey();
        }
    }
}
