using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculate class1 = new Calculate();

                while (true)
                {
                    Console.Clear();

                Console.WriteLine("Viberite operaciyu:\n1 - Slojenie.\n2 - Vichitanie.\n3 - Umnojenie.\n4 - Delenie.\n5 - Koren chisla.");

                switch (Console.ReadLine())
                    {
                        case "1":
                            try
                            {
                            class1.Menu();
                                Console.WriteLine($"\nRezultat: {class1.Sum(class1.a, class1.b)}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOwibochka: {ex.Message}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            break;
                        case "2":
                            try
                            {
                            class1.Menu();
                            Console.WriteLine($"\nRezultat: {class1.Min(class1.a, class1.b)}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOwibochka: {ex.Message}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            break;
                        case "3":
                            try
                            {
                            class1.Menu();
                            Console.WriteLine($"\nRezultat: {class1.Mul(class1.a, class1.b)}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOwibochka: {ex.Message}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            break;
                        case "4":
                            try
                            {
                            class1.Menu();
                            Console.WriteLine($"\nRezultat: {class1.Div(class1.a, class1.b)}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOwibochka: {ex.Message}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            break;
                        case "5":
                            try
                            {
                                Console.WriteLine("Vvedite chislo");
                                class1.a = double.Parse(Console.ReadLine());
                                Console.WriteLine($"\nRezultat: {class1.Div2(class1.a)}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nOwibochka: {ex.Message}\n\nNajmite dlya prodoljeniya enter");
                                
                            }
                            break;
                    }
                Console.ReadKey();
            }

            }
        }


    }

