namespace task_8
{
    internal class Program
    {
        /// <summary>
        /// Функция проверки правильности ввода числа
        /// </summary>
        /// <returns></returns>
        static int ReadInt()
        {
            int number;
            bool isParse;
            do
            {
                Console.WriteLine("Введите целое число");
                isParse = int.TryParse(Console.ReadLine(), out number);
                if (isParse == false)
                    Console.WriteLine("Вы ввели не целое число ");
            } while (isParse == false);
            return number;
        }

        /// <summary>
        /// Функция создания массива
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static int[] CreateArray(int length)
        {
            int[] arr = new int[length];
            int i = 0, n;
            while (i < arr.Length)
            {
                Console.WriteLine("Введите элемент последовательности");
                n = ReadInt();
                arr[i] = n;
                i++;
            }
            return arr;
        }

        /// <summary>
        /// Функция печати элементов массива
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Функция подсчета элементов, крастных k1, k2
        /// </summary>
        static void IsDivide()
        {
            Console.WriteLine("Введите число элементов");
            int x = ReadInt();
            int[] arr = CreateArray(x);
            Console.WriteLine("Введите число k1");
            int k1 = ReadInt();
            Console.WriteLine("Введите число k2");
            int k2 = ReadInt();
            int count_k1 =0, count_k2 = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % k1 == 0)
                {
                    count_k1++;
                }
                if (arr[j] % k2 == 0)
                {
                    count_k2++; 
                }
            }
            PrintArray(arr);
            Console.WriteLine($"Количество элементов кратных k1 = {k1}: {count_k1}, k2 = {k2}: {count_k2}");
        }
        static void Main(string[] args)
        {
            IsDivide();
        }
    }
}