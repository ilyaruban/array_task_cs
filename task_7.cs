namespace task_12
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
        /// Функция создания массивов
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
        /// Подсчет количества четных элементов в массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int CountNum(ref int[] arr)
        {
            int[] temp = new int[arr.Length];
            int j = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        
        /// <summary>
        /// Функция удаления четных элементов
        /// </summary>
        /// <param name="arr"></param>
        static void DeleteItem(ref int[] arr)
        {
            int[] temp = new int[arr.Length - CountNum(ref arr)]; //уменьшаем длину массива temp на количество четных элементов, полученных из функции CountNum(ref arr)
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    temp[j] = arr[i];
                    j++;
                }
            }
            arr = temp;  //присваиваем переменной arr ссылку на область памяти массива temp
        }
        static void Main(string[] args)
        {
            int length = ReadInt();
            int[] arr = CreateArray(length);
            PrintArray(arr);
            DeleteItem(ref arr);
            if(arr.Length == 0)
            {
                Console.WriteLine("Из массива удалены все элементы");
            }
            else
            {
                PrintArray(arr);
            }            
        }
    }
}