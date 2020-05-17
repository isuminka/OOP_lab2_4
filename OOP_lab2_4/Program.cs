using System;

namespace OOP_lab2_4
{
    public class Program
    {
        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int Multiplication(int[] array)
        {
            int firstNegativeIndex = 0;
            int lastNegativeIndex = 0;

            int d = 1;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    firstNegativeIndex = i;
                    break;
                }
            }

            for (int i = array.Length - 1; i >= firstNegativeIndex; --i)
            {
                if (array[i] < 0)
                {
                    lastNegativeIndex = i;
                    break;
                }
            }

            if (firstNegativeIndex != lastNegativeIndex)
            {
                for (int i = firstNegativeIndex + 1; i < lastNegativeIndex; ++i)
                {
                    d *= array[i];
                }
            }
            else
            {
                return 0;
            }

            return d;
        }

        static void Main()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];


            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);

                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cумa елементiв масиву з непарними номерами: {0}", Sum(array));
            Console.WriteLine("Добуток елементiв масиву, розташованих мiж першим й останнiм вiд’ємними елементами: {0}", Multiplication(array));
        }
    }
}
