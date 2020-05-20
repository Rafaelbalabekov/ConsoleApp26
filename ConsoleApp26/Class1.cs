using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    public class Calculate
    {
       public double a, b;
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Min(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
                throw new Exception("Delenie na nol nevozmojmo!!!");
        }
        public double Div2(double a)
        {
            return Math.Sqrt(a);
        }
        public void Menu()
        {
            Console.WriteLine("Vvedite pervoe chislo");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite vtoroe chislo");
            b = double.Parse(Console.ReadLine());
        }
    }
 }

