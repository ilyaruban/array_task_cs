namespace task_11
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
                arr[i] = rand.Next(1, 100);
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
        /// Сортировка методом простого выбора
        /// </summary>
        /// <param name="arr"></param>
        static void SortChange(ref int[] arr)
        {
            int min, n_min, j;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = arr[i];
                n_min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min && arr[j] % 2 == 0)
                    {
                        min = arr[j];
                        n_min = j;
                        arr[n_min] = arr[i];
                        arr[i] = min;
                    }                    
                }
            }
        }
        
        static void Main(string[] args)
        {
            int length = ReadInt();
            int[] arr = CreateArray(length);
            PrintArray(arr);            
            SortChange(ref arr);            
            PrintArray(arr);
        }
    }
}