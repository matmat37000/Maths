using System;
using System.IO;

///
/// By Mathiol - BORDIER-AUPY Mathieu
///

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calcule(0);
        }

        static void calcule(float num)
        {
            Console.Write("Calcule 1:\nnombre * ");
            string num1 = Console.ReadLine();
            int N1 = Int32.Parse(num1);

            Console.Write("nombre * " + num1 + " + ");
            string num2 = Console.ReadLine();
            int N2 = Int32.Parse(num2);

            Console.Write("\nCalcule 2:\nnombre * ");
            string num3 = Console.ReadLine();
            int N3 = Int32.Parse(num3);

            Console.Write("nombre * " + num3 + " + ");
            string num4 = Console.ReadLine();
            int N4 = Int32.Parse(num4);

            Console.WriteLine("\nnombre * " + num1 + " + " + num2);
            Console.WriteLine("nombre * " + num3 + " + " + num4);

            
            Console.Write("\n1: -\n2: +\n");
            string cal1 = Console.ReadLine();
            int cal = Int32.Parse(cal1);
            Console.WriteLine(cal);
            



            bool good = false;
            while (good != true)
            {
                float calcule1 = num * N1 + N2;
                float calcule2 = num * N3 + N4;
                Console.WriteLine(String.Format("{0:0.00}", calcule1));
                Console.WriteLine(String.Format("{0:0.00}", calcule2));

                if (cal == 1) num = (float)(num - 0.01);
                if (cal == 2) num = (float)(num + 0.01);

                if (String.Format("{0:0.0}", calcule1) == String.Format("{0:0.0}", calcule2))
                {
                    Console.WriteLine(String.Format("{0:0.0}", num));
                    good = true;
                }
            }
            Console.WriteLine("good");
            Console.Read();

        }
    }
}