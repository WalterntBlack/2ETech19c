using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a,b,aa,bb,w;
            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = int.Parse(Console.ReadLine());
            aa = a * a;
            bb = b * b;
            w = aa + bb;
            Console.WriteLine($"{a}");
            Console.ReadKey();
            */
            /*
            int x, y, z;
            Console.WriteLine("Podaj x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj z");
            z = int.Parse(Console.ReadLine());
            if (x < y || x < z || y < z)
            {
                Console.WriteLine($"{x}{y}{z}");
            }
            else
            {
                if (x < y || x < z || y > z)
                {
                    Console.WriteLine($"{x}{z}{y}");
                }
                else
                {
                    if (x > y || x > z || y > z)
                    {
                        Console.WriteLine($"{z}{y}{x}");
                    }
                    else
                    {
                        if (x < y || x > z || y > z)
                        {
                            Console.WriteLine($"{z}{x}{y}");
                        }
                        else
                        {
                            if (x > y || x < z || y < z)
                            {
                                Console.WriteLine($"{y}{x}{z}");
                            }
                            else
                            {
                                if (x > y || x > z || y < z)
                                {
                                    Console.WriteLine($"{y}{z}{x}");
                                }
                            }
                        }

                    }
                }
            }
            
            int x, y, z;
            Console.WriteLine("Podaj x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj z");
            z = int.Parse(Console.ReadLine());
            if (x < y && x < z && y < z)
            {
                Console.WriteLine($"{x}{y}{z}");
            }
            else if (x < y && x < z && y > z)
            {
                Console.WriteLine($"{x}{z}{y}");
            }
            else if (x > y && x > z && y > z)
            {
                Console.WriteLine($"{z}{y}{x}");
            }
            else if (x < y && x > z && y > z)
            {
                Console.WriteLine($"{z}{x}{y}");
            }
            else if (x > y && x < z && y < z)
            {
                Console.WriteLine($"{y}{x}{z}");
            }
            else if (x > y && x > z && y < z)
            {
                Console.WriteLine($"{y}{z}{x}");
            }
            
            int n, i, wynik;
            wynik = 1;
            Console.WriteLine("Podaj N");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            Console.WriteLine(wynik);
            Console.ReadKey();
            
            
            int i;
            i = -11;
            
            while (i < 17)
            {

                i = i + 4;
                Console.WriteLine(i);

            }
            Console.ReadKey();
            
            int i;
            i = -11;

            for (i = 2;i <= 486; i = i * 3)
            {

                
                Console.WriteLine(i);

            }
            Console.ReadKey();
            
            int n,x;
            Console.WriteLine("podaj liczbę n");
            n = int.Parse(Console.ReadLine());
            x = 0;

            while (n > 0)
            {
                n = n / 10;
                x = x + 1;
            }
            Console.WriteLine(x);
            Console.ReadKey();
            

            int n, i;
            bool flaga = true;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flaga = false;
                    break;
                }

            }
            if (flaga) Console.WriteLine("jest pierwsza");
            else
            {
                Console.WriteLine("nie jest pierwsza");
            }
            Console.ReadKey();
            */


        }
    }
}

