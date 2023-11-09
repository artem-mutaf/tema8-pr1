using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_8_praktikum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа
            //Задача 1
            //Console.Write("Введите число i = ");
            //int i = int.Parse(Console.ReadLine());
            //Console.Write("Введите число z = ");
            //int z = int.Parse(Console.ReadLine());
            //Console.Write($"Наибольшее число {Max(i,z)}");
            //Console.ReadKey();
            //Задача 2
            //Console.Write("Введите число i = ");
            //int i = int.Parse(Console.ReadLine());
            //Console.Write("Введите число z = ");
            //int z = int.Parse(Console.ReadLine());
            //Console.Write("Введите число k = ");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine($"среднее ариф {Aref(i,z,k)}");
            //Console.ReadKey();
            //Задача 3
            double n = -9;
            double k = 9;
            double g = 3;
            Func(n, k, g);

            Console.ReadKey();


        }
        //Задача 1 
        //public static int Max(int i,int z)
        //{
        //    if (i > z)
        //    {
        //        return i;
        //    }
        //    else
        //        return z;
        //}
        //public static double Aref(double i,double z,double k)
        //{
        //    return (i + z + k) / 3;
        //}
        public static void Func(double n, double k, double g)
        {
            for(double x = n;x<= k;x += g)
            {
                double y = 4 * Math.Pow(x, 2) + 5 * x - 10;
                Console.Write($"x ={x}  y = {y}\n");
            }
            
        }


    }
}
