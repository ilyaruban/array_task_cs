namespace task_15
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
            Random rand = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = rand.Next(-100, 100);
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
        /// Функция добавления элементов в массив
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <param name="number"></param>
        static void AddItem(ref int[] arr, int k, int number)
        {
            int[] temp = new int[arr.Length + 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != k)
                {
                    temp[j] = arr[i];
                    j++;
                }
                else
                {
                    temp[j] = number;
                    j++;
                    temp[j] = arr[i];
                    j++;
                }
            }
            if (k == arr.Length)
            {
                temp[j] = number;
            }
            arr = temp;
        }
        static void Main(string[] args)
        {
            int length = ReadInt();
            int[] arr = CreateArray(length);
            PrintArray(arr);
            Console.WriteLine("На какую позицию добавить элемент?");
            int pos = ReadInt();
            if(pos <= arr.Length)
            {
                Console.WriteLine("Какой элемент добавить?");
                int number = ReadInt();
                AddItem(ref arr, pos - 1, number);
                PrintArray(arr);
            }
            else
            {
                Console.WriteLine($"Нет такой позиции, максимально возможная {arr.Length}");
            }
            
        }
    }
}