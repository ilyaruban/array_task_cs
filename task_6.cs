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
        /// Функция вычисления суммы выражения S с заданным количеством параметров
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SummInt(int n)
        {           
            int i = 0, sum = 5;
            int k = 6, j = 2;
            while (i < n - 1)
            {
                sum += j * k;
                j++;
                k++;
                i++;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int n = ReadInt();
            if (n > 0 && n != 0)
            {
                Console.WriteLine($"{SummInt(n)}");
            }
            else
            {
                Console.WriteLine("Число n не может быть меньше 0 или равно 0");
            }
        }
    }
}