using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмірність: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Output(array);
            Console.ReadLine();

        }
        static int InputByRandom(int[] array)
        {

            int result = 0;
            Random x = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = x.Next(-50, 50);
                foreach (int k in array)
                {
                    result += k;
                }
            }
            ArrayWrite(array);
            return 0;
        }
        static int ShakerSorting(int[] array)
        {

            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {

                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {

                    if (array[i - 1] > array[i])
                        Swap(array, i - 1, i);
                }
                left++;
            }
            ArrayWrite(array);
            return 0;

        }
        static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        static int MinMax(int[] array)
        {
            int max = array[0];
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (array[i] < array[min])
                {
                    min = i;
                }
            }

            Console.WriteLine($"Мінімальне число: {array[min]}\nМаксимальне число: {max}\nРізниця :{max - array[min]}");

            return min;
        }


        static void ArrayWrite(int[] array)
        {
            foreach (int s in array)
                Console.WriteLine(s.ToString());
        }

        static int Output(int[] array)
        {
            Console.WriteLine("Ваш рандомний масив:");
            Console.WriteLine(InputByRandom(array));
            Console.WriteLine("Ваш відсортований масив:");
            Console.WriteLine(ShakerSorting(array));
            Console.WriteLine(MinMax(array));
            return 0;
        }

    }
}

