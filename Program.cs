using System;

namespace palm2
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість рядків");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпчиків");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш масив");
            int[,] arr = new int[i, j];
            ArrayRandom(arr); //створюється рандомний масив
            FindPositive(arr); //шукається останній невід*ємний рядок
            Console.ReadLine();
        }
        static void ArrayRandom(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-5, 10); //аби перевірити, чи правильно шукає номер рядка, раджу погратися з першим параметром
                    Console.Write(" {0}", array[i, j]);
                }
            }
        }

        static void FindPositive(int[,] arr)
        {
            int last = 0; //тимчасова змінна, будемо заповнювати номер рядка
            int empty = 0; //лічильник для "непотрібних" елементів
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] >= 0)
                    {
                        last = i;
                        last += 1; //i = 0, за умовою циклу, буде без цього показувати на 1 менше
                    }
                    if (arr[i, j] < 0)
                    {
                        empty++;
                    }

                }
            }
            if (empty != 0)//порівнюємо наш лічильник
            {
                Console.WriteLine("\nТаких рядків немає");
            }
            else
            {
                Console.WriteLine($"\nОстанній рядок : {last}");
            }
        }
    }
}



