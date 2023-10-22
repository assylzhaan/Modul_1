using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    internal class Program
    {
        private static Random rnd = new Random();
        static void task1()
        {
            double a = 0;
            double b = 0;
            float c = 0;

            Console.Write("Введите число а = ");

            a = double.Parse(Console.ReadLine());

            b = Convert.ToDouble(Console.ReadLine());// Превращяет введенную строку в дабл\

            while (float.TryParse(Console.ReadLine(), out c) == true)
            {
                Console.WriteLine(" Введите корректное число");
            }




        }
        static void task2()
        {

            Console.WriteLine("Введите интервал начала:");
            float a = 0;
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите интервал конца:");
            float b = 0;
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число");
            float c = 0;
            c = float.Parse(Console.ReadLine());

            if (c >= a & c <= b)
            {
                Console.WriteLine("Входит");
            }
            else
            {
                Console.WriteLine("Не входит");
            }


        }

        static void task3()
        {
            Random rnd = new Random();
            double a = rnd.NextDouble();
            double b = rnd.NextDouble();
            double c = rnd.NextDouble();
            int sum = 0;
            Console.WriteLine("{0}\t {1} \t {2}", a, b, c);
            if (a < 0)
            {
                sum += 1;
            }
            if (b < 0)
            {
                sum += 1;
            }
            if (c < 0)
            {
                sum += 1;
            }
            Console.WriteLine(sum);
        }

        static void fillArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 1000);
            }
        }
        static void fillArr(int[,] arr, int col, int rol)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < rol; j++)
                {
                    arr[i, j] = rnd.Next(1, 1000);

                }
            }
        }
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void printArr(int[,] arr, int col, int rol)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < rol; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void task5()
        {
            int userId = 0;
            int[,] employee = new int[12, 4];
            for (int i = 0; i < 12; i++)
            {
                employee[i, 0] = userId++;
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    employee[i, j] = rnd.Next(1000, 100000);
                }
            }
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;


            for (int i = 0; i < 12; i++)
            {
                
                    Console.WriteLine("{0}) {1:###,##}kzt\t" +
                        " {2:###,##}kzt\t " +
                        "{3:###,##}kzt\t" +
                        "\ttotal- {4:###,##} kzt\t ",
                        employee[i, 0],
                        employee[i, 1],
                        employee[i, 2],
                        employee[i, 3],

                        (employee[i, 1] + employee[i, 2] + employee[i, 3]));
                total1 = total1 + employee[i, 1];
                total2 = total2 + employee[i, 2];  
                total3 = total3 + employee[i, 3];


            }
            Console.WriteLine("Итого выдано за первый  месяц-{0:###,##} kzt", total1 );
            Console.WriteLine("Итого выдано за второй  месяц-{0:###,##} kzt", total2);
            Console.WriteLine("Итого выдано за третий  месяц-{0:###,##} kzt", total3);
            Console.WriteLine("Итого выдано за квартал - {0:###,##} kzt", total1+ total2+ total3);

        }
        static void task4()
        {
            int[] arr = new int[5];
            fillArr(arr);
            printArr(arr);
        }
        static void Main(string[] args)
        {

            //task1();
            //task2();
            //task3();
            //task4();
            task5();
            Console.ReadKey();
        }
    }
}


