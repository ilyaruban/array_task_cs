using System.Formats.Tar;

namespace task_14
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
        /// Функция поиска максимального элемента в массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="posMax"></param>
        /// <returns></returns>
        static int FindMax(int[] arr, out int posMax)
        {
            int max = arr[0];
            posMax = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    posMax = i;
                }
            }
            return max;
        }

        /// <summary>
        /// Функция поиска минимального элемента в массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="posMin"></param>
        /// <returns></returns>
        static int FindMin(int[] arr, out int posMin)
        {
            int min = arr[0];
            posMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    posMin = i;                   
                }
            }
            return min;
        }

        /// <summary>
        /// Функция перемены местами максимального и минимального элемента
        /// </summary>
        /// <param name="arr"></param>
        static void ChangePairs(int[] arr)
        {
            int i = 0;
            FindMin(arr, out int posMin);
            FindMax(arr, out int posMax);
            int temp = arr[posMin];
            arr[posMin] = arr[posMax];
            arr[posMax] = temp;           
            Console.WriteLine($"Минимум на позиции: {posMin+1}\nМаксимум на позиции: {posMax+1}");
        }

        static void Main(string[] args)
        {
            int length = ReadInt();
            int[] arr = CreateArray(length);
            PrintArray(arr);
            ChangePairs(arr);
            PrintArray(arr);
        }
    }
}