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
            int[,] arr = new int[i, j];
            Console.WriteLine("Ваш масив");
            ArrayRandom(arr); //створюється рандомний масив
            LastNegative(arr);//шукається невід*ємний рядок
            Console.ReadLine();
        }
        static void ArrayRandom(int[,] arr)
        {

            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-5, 10);
                    Console.Write(" {0}", arr[i, j]);
                }
            }
        }
        static void LastNegative(int[,] arr)
        {

            int k = 0;//"перевірочна" змінна, можна було використати bool
            int last = 0;//змінна для зберігання індексу рядка
            for (int i = 0; i < arr.GetLength(0); i++)//починаємо з нуля, тому що можемо пропустити перший елемент, а він може бути від'ємним
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)//якщо елемент масиву від*ємний
                    {
                        k = 0;//так і залишаємо його
                        break;
                    }
                    if (arr[i, j] > 0)//якщо елемент більше нуля
                    {
                        k = 1;//змінюємо перевірочну змінну
                    }
                    if (k == 1)//перевіряємо, чи дорівнює К потрібному значенню
                    {
                        last = i;//якщо є, присвоюємо їй індекс рядка
                    }
                }

            }
            if (k == 0)//перевіряємо, чи змінилась взагалі К
            {
                Console.WriteLine("\nТаких немає");
            }
            else
            {
                Console.WriteLine($"\nОстанній рядок: {last + 1}"); // +1 тому що i = 0
            }
        }


    }
}
