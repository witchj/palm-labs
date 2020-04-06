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
            LastNegative(arr, n, m);//шукається останній невід*ємний рядок
            SortMatrix(arr, n);
            AddElements();
            NewArr();
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
            {

                bool IsZero = false; ;
                int index = 0;

                for (int i = 0; i < n; i++)
                {
                    int count = 0;

                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] > 0)
                        {
                            count++;
                        }
                    }

                    if (count == m)
                    {
                        IsZero = true;
                        index = i;
                    }

                }
                Console.WriteLine();
                if (IsZero)
                {
                    Console.WriteLine("\nв {0}-му рядку  не має відємних чисел", index + 1);
                }
                else
                {
                    Console.WriteLine("Таких немає");
                }
                Console.WriteLine();
            }
        }
        static void SortMatrix(int[,] array, int n)
        {
            int max = array[0, 0];
            int ii = 0;
            int jj = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        ii = i;
                        jj = j;
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == max && i == j)
                    {
                        int temp = array[i, j];
                        array[n - i - 1, j] = array[i, j];
                        array[i, j] = temp;
                    }

                }
            }
            ArrayOutput(array);
        }
        static void ArrayOutput(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        static void AddElements()
        {
            Console.WriteLine("Введіть K");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину масиву");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш рандомний масив");
            Random rand = new Random();
            int count = 0;
            int[] arr = new int[size];
            int[] tmp = new int[k];
            int[] newarr = new int[size + k];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(-10, 30);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nВаші нові елементи");
            for (int i = 0; i < k; i++)
            {
                tmp[i] = rand.Next(-10, 30);
                Console.Write(tmp[i] + " ");
            }

            for (int i = 0; i < size + k; i++)
            {
                if (i < n)
                {
                    newarr[i] = arr[i];
                }
                else if (i >= n && i < n + k)
                {
                    newarr[i] = tmp[count];
                    count++;
                }
                else
                {
                    newarr[i] = arr[i - count];
                }
            }


            Console.WriteLine();

            foreach (int i in newarr)
            {
                Console.Write(i + " ");
            }
        }
        static void NewArr()
        {

            Console.WriteLine("\nВведіть кількість рядків");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців");
            int m = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            int mem = 0;

            int count = 0;
            Console.WriteLine("Ваша матриця:");
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    arr[i][j] = rand.Next(-10, 30);
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            int min = arr[0][0];



            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] <= min)
                    {
                        mem = arr[i][j];
                        if (arr[i][j] == arr[i][j])
                        {
                            count++;
                        }
                        if (count > 0)
                        {
                            mem = i;
                            break;
                        }

                    }
                }
            }
            Console.WriteLine($"Рядок з найменшим елементом {mem+1}");
            Console.WriteLine("Додатковий рядок:");
            int[] array = new int[m];
            for (int i = 0; i < m; i++)
            {
                array[i] = rand.Next(-10, 30);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int[][] mas = new int[arr.Length + 1][];
            Console.WriteLine("Новий масив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new int[m];
                for (int j = 0; j < mas[i].Length; j++)
                {
                    if (i < n)
                    {
                        mas[i][j] = arr[i][j];
                    }
                    else if (i == n)
                    {
                        mas[n][j] = array[j];
                    }
                    else
                    {
                        mas[i][j] = arr[i - 1][j];
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {

                for (int j = 0; j < mas[i].Length; j++)
                {

                    Console.Write(mas[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
    }

}



