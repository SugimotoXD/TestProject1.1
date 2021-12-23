using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Cosh(n));
            Console.WriteLine(Math.Round(Cosh(30*Math.PI/90),4));
            Console.WriteLine(Math.Round(Math.Sin(30*Math.PI/90),4));
            Console.ReadKey();
        }
        public static long Cosh(int n)
        {
            long F = 1;
            for (int i = 1; i <= n; i++) F *= i;
            return F;
        }
        public static double Cosh(double x)
        {
            const double eps = 5e-25;  
            double s = 0;  
            double r = x;   
            int n = 1;        
            while (Math.Abs(r) > eps) 
            {
                s = s + r;     
                n = n + 2; 
                r = -r * x * x / (n * (n - 1)); 
            }
            return s;    
        }
    }
}
