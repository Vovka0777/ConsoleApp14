using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._1
{
    /// <summary>
    /// 1. Заполнить массив с клавиатуры и вывести его на экран.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод ввода размера одномерного массива
        /// </summary>
        /// <returns>Размер</returns>
        static int GetSize()
        {
            Console.Write("Введите размер массива - ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка, введите новое значение");
            }
            return size;
        }

        /// <summary>
        /// Метод ввода значений массива
        /// </summary>
        /// <param name="size"></param>
        /// <returns>Ввод</returns>
        static int[] Input(int size)
        {
            int[] array = new int[size];
            for (int i = 0;i<size;i++)
            {
                Console.Write($"array[{i}] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        /// <summary>
        /// Метод вывода значений массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Вывод</returns>
        static void OutPut(int[] array)
        {
            for (int i = 0;i<array.Length;i++)
            {
                Console.WriteLine($"\narray[{i}] = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            int size = GetSize();
            int[] array = Input(size);
            OutPut(array);
            Console.Read();
        }
    }
}
