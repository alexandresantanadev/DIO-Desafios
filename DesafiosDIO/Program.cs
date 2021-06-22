using System;
using System.Globalization;

namespace DesafiosDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, mediaP;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);
            Console.WriteLine("MEDIA = " + mediaP.ToString("F5", CultureInfo.InvariantCulture));

            Console.WriteLine("------------");

            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = X / Y; 
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

                Console.WriteLine("------------");

                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());

                int SOMA = A + B;
                
                Console.WriteLine("SOMA = " + SOMA.ToString());
            }
        }
    }
}

