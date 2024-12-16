using Tyuiu.KoninDP.Lab2.Review.V13.Lib;

namespace Tyuiu.KoninDP.Lab2.Review.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5, stopValue = 5;
            DataService ds = new DataService();

            Console.Title = "Лабораторная #2 | Выполнил: Конин Д. П. | МКМб-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная #2                                                         *");
            Console.WriteLine("* Тема: Табулирование функции по методологии разработка через             *");
            Console.WriteLine("* тестирование (Test-driven development (TDD)                             *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Конин Давид Павлович | МКМб-22-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне X1, X2.           *");
            Console.WriteLine("* Произвести проверку деления на ноль. Значения должны храниться в        *");
            Console.WriteLine("* массиве. Округлить значения до двух знаков после запятой.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0, 5:d}     |  {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}