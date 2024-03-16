namespace task_13
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
        /// Функция поиска минимального элемента в массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        
        /// <summary>
        /// Функция удаления минимального элемента массива
        /// </summary>
        /// <param name="arr"></param>
        static void DeleteMin(ref int[] arr)
        {
            int[] temp = new int[arr.Length-1];
            int x = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != FindMin(arr))
                {
                    temp[j] = arr[i];
                    j++;
                }
            }
            arr = temp;
        }

        static void Main(string[] args)
        {
            int length = ReadInt();
            int[] arr = CreateArray(length);
            PrintArray(arr);
            int x = 0;
            if(arr.Length > 3)
            {
                while (x < 3)  //удаление первых 3 минимальных элементов из массива
                {
                    DeleteMin(ref arr);
                    x++;
                }
                PrintArray(arr);
            }
            else
            {
                Console.WriteLine("Возникла ошибка: OverflowException");
            }           
        }
    }
}