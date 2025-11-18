using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           
            if (!File.Exists("input.txt"))
            {
                File.WriteAllText("input.txt", "10\n20\n10000\n40\n50");
            }

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double a, b, c, d, e;
            double s = 0, k = 0;
            bool s_calculated = false;
            bool k_calculated = false;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if (a < 0 || a > 100000 || b < 0 || b > 100000 ||
                c < 0 || c > 100000 || d < 0 || d > 100000 ||
                e < 0 || e > 100000)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                
                if ((e - b >= 0) && (a - Math.Sqrt(e - b) >= 0) && (e != 0))
                {
                    s = Math.Sqrt(a - Math.Sqrt(e - b)) / e;
                    Console.WriteLine(String.Format("{0:0.00}", s));
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

                if ((c - 1000 >= 0) && (Math.Abs(b - a) != 0) && ((d + Math.Sqrt(c - 1000)) >= 0))
                {
                    k = Math.Sqrt((d + Math.Sqrt(c - 1000)) / Math.Abs(b - a));
                    Console.WriteLine(String.Format("{0:0.00}", k));
                    k_calculated = true;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    
      
                }
            }

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}