using System;
using System.IO;

namespace LAB_ONE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("input.txt"))
            {
                File.WriteAllText("input.txt", "2\n3\n5\n0");
            }

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;

            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");

            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double X, Y, Z;
            int t, N;
            Z = 0;

            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());

            switch (t)
            {
                case 0:
                    ForCycle(X, Y, N, Z);
                    break;
                case 1:
                    WhileCycle(X, Y, N, Z);
                    break;
                case 2:
                    doWhileCycle(X, Y, N, Z);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            Console.SetOut(save_out);
            Console.SetIn(save_in);
            new_out.Close();
            new_in.Close();
        }

        static void ForCycle(double X, double Y, int N, double Z)
        {
            for (int i = 1; i <= N; i++)
            {
                double term;
                double denominator = (2 * i - 1) * (2 * i + 1);

                if (i % 2 != 0)
                {
                    term = Math.Pow(X, 2 * i) / denominator;
                }
                else
                {
                    term = -Math.Pow(Y, 2 * i) / denominator;
                }

                Z += term;
            }
            Console.WriteLine(String.Format("{0:0.0000}", Z));
        }

        static void WhileCycle(double X, double Y, int N, double Z)
        {
            int i = 1;
            while (i <= N)
            {
                double term;
                double denominator = (2 * i - 1) * (2 * i + 1);

                if (i % 2 != 0)
                {
                    term = Math.Pow(X, 2 * i) / denominator;
                }
                else
                {
                    term = -Math.Pow(Y, 2 * i) / denominator;
                }

                Z += term;
                i++;
            }
            Console.WriteLine(String.Format("{0:0.0000}", Z));
        }

        static void doWhileCycle(double X, double Y, int N, double Z)
        {
            int i = 1;
            do
            {
                double term;
                double denominator = (2 * i - 1) * (2 * i + 1);

                if (i % 2 != 0)
                {
                    term = Math.Pow(X, 2 * i) / denominator;
                }
                else
                {
                    term = -Math.Pow(Y, 2 * i) / denominator;
                }

                Z += term;
                i++;
            } while (i <= N);
            Console.WriteLine(String.Format("{0:0.0000}", Z));
        }
    }
}