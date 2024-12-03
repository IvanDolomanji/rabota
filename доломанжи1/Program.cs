using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace доломанжи1
{
    class Program
    {
        /// <summary>
        /// метод ввода размера массива
        /// </summary>
        /// <returns>размер</returns>
        static int GetSize()
        {
            Console.Write("Введите размер массива");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }
            return size;
        }
        /// <summary>
        /// метод заполнения с клавиатуры
        /// </summary>
        /// <param name="size">размер</param>
        /// <returns>массив</returns>
        static int[] Input(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"array[{i}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;

        }
            static void Main(string[] args)
            {
                int size = GetSize();
                int[] array = Input(size);
                Output(array);
                Console.Read();

            }
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }

        }


    } 
}
