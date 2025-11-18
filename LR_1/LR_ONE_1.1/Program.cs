using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_ONE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1. Структура консольного приложения");
            Console.WriteLine("Выполнил: Коротченко Дмитрий Игоревич");
            Console.WriteLine("Группа: ИДБ-23-01. Шифр специальности: 09.03.01");
            Console.WriteLine("Дата рождения: 13.03.2006");
            Console.WriteLine("Город: Люберцы");
            Console.WriteLine("Любимый школьный предмет: алгебра");
            Console.WriteLine("Увлечений, хобби, интересы: большой теннис, баскетбол");

            double a = 10;
            double b = 11.3;
            int x = 17;
            int t = 18;
            double f = 19;
            double i_2 = 2;
            double R_x = a * b + b / t - x + f - i_2;
            Console.WriteLine($"R_x = {R_x}");

            Console.ReadKey();
        }
    }
}