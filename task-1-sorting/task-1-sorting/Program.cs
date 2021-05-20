using System;

namespace task_1_sorting
{
    class Program
    {
        static int[] sorting (int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int write = 0; write < arr.Length; write++)
            {
                Console.Write("{0} ", arr[write]);
            }
            Console.WriteLine("");
            return arr;
        }

        static int[] specialSort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length - 1; write++)
            {
                for (int sort = 0; sort < arr.Length - 2; sort++)
                {
                    if (sort % 2 == 0)
                    {
                        if (arr[sort] > arr[sort + 2])
                        {
                            temp = arr[sort + 2];
                            arr[sort + 2] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                    else
                    {
                        if (arr[sort] < arr[sort + 2])
                        {
                            temp = arr[sort + 2];
                            arr[sort + 2] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
                }
            }

            for (int write = 0; write < arr.Length; write++)
            {
                Console.Write("{0} ", arr[write]);
            }
            Console.WriteLine("");
            return arr;
        }


        static int[] input()
        {
            int[] arr = new int[10];

            for (int write = 0; write < arr.Length; write++)
            {
                Console.WriteLine("Введите arr[{0}]", write);
                arr[write] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int role;
            bool numexist;

            role = 0;
            numexist = false;
            while (role != 4)
            {
                Console.WriteLine("1. Ввести числа(заново).");
                if (numexist)
                {
                    Console.WriteLine("2. Полная сортировка пузырьком.");
                    Console.WriteLine("3. Альтернативная сортировка пузырьком.");
                }
                Console.WriteLine("4. Выход.");
                role = Convert.ToInt32(Console.ReadLine());
                if (role == 1)
                {
                    arr = input();
                    numexist = true;
                }
                if (role == 2 && numexist)
                {
                    arr = sorting(arr);
                }
                if (role == 3 && numexist)
                {
                    arr = specialSort(arr);
                }
            }
        }
    }
}

