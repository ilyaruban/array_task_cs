namespace task_10._1
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
        /// Функция задания последовательности, за которой идет 0
        /// </summary>
        static void CheckSequence()
        {
            int n, i = 0, pos_max = 0, pos_min = 0;
            int max = 1, min = 1;
            Console.WriteLine("Задайте последовательность");
            do
            {
                n = ReadInt();
                i++;
                if (n == 0 && i == 1)
                {
                    Console.WriteLine("Нулевая последовательность, нет элементов");
                    break;
                }
                else
                {
                    if (n > max && n != 0)
                    {
                        max = n;
                        pos_max = i;
                    }
                    if (n < min && n != 0)
                    {
                        min = n;
                        pos_min = i;
                    }
                }
            }
            while (n != 0);
            Console.WriteLine($"max = {max}, позиция {pos_max}\nmin = {min}, позиция {pos_min}");
            Console.WriteLine($"Расстояние между max и min составляет {Math.Abs(pos_max - pos_min)}");
        }

        static void Main(string[] args)
        {
            CheckSequence();
        }
    }
}