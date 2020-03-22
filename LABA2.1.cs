using System;

namespace palm2
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Виберіть метод вводу: -1 = Рандом, 1 = з клавіатури");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість рядків");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпчиків");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш масив");
            int[,] arr = new int[n, m];
            if (input == 1)
            {
                Keyboard(arr, n, m);
            }
            if (input == -1)
            {
                ArrayRandom(arr, n, m);
            }
            LastNegative(arr, n, m);//шукається невід*ємний рядок
            Console.ReadLine();
        }
        static void Keyboard(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                string inputstr = Console.ReadLine();
                string[] str = inputstr.Split(new char[] { ' ' });
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(str[j]);
                }
            }
        }
        static void ArrayRandom(int[,] arr, int n, int m)
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-5, 10);
                    Console.Write(" {0}", arr[i, j]);
                }
            }
        }
        static void LastNegative(int[,] arr, int n, int m)
        {

            int last = 0;
            int count = 0; 
            int glass = 0;

            for (int i = 0; i < n; i++)//цикл, который проходит по всем элементам и учит ненужные нам строчки заранее
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        count = 1;
                        glass = j;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    if (arr[i, j] >= 0 && glass != j)//сравнивает, нету ли ненужных нам строчек из созданного ранее списка
                    {
                        last = i;
                        count = 0;
                    }
                }
            }

            if (count != 0)
            {
                Console.WriteLine("\nТаких немає");
            }
            else
            {
                Console.WriteLine($"\n{last + 1}");
            }
        }
    }
}
