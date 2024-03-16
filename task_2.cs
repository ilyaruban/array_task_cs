namespace task_7
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
        /// Функция поиска максимального элемента в массиве
        /// </summary>
        /// <param name="max"></param>
        /// <param name="count"></param>
        static void FindMax(out int max, out int count)
        {
            Console.WriteLine("Введите число элементов");
            int x = ReadInt();
            int[] arr = CreateArray(x);  
            max = arr[0];
            count = -1;            
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                }
                else if (arr[j] == max)
                {
                    count++;
                }
            }
            PrintArray(arr);
        }
        

        static void Main(string[] args)
        {
            FindMax(out int max, out int count);
            Console.WriteLine($"Максимум: {max}, совпадений: {count}");
        }
    }
}