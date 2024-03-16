namespace task_9._1
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
            int n, i = 0;
            int count_k1 = 0, count_k2 = 0;
            Console.WriteLine("Введите число k1");
            int k1 = ReadInt();
            Console.WriteLine("Введите число k2");
            int k2 = ReadInt();
            if (k1 != 0 && k2 != 0)
            {
                Console.WriteLine("Задайте последовательность");
                do
                {
                    n = ReadInt();
                    i++;
                    if (n % k1 == 0 && n != 0)
                    {
                        count_k1++;
                    }
                    if (n % k2 == 0 && n != 0)
                    {
                        count_k2++;
                    }
                } while (n != 0);

                if (count_k1 == 0)
                {
                    Console.WriteLine($"Количество элементов кратных k1 = {k1}: {count_k1}, k2 = {k2}: {count_k2}");
                }
                else if (count_k2 == 0)
                {
                    Console.WriteLine($"Количество элементов кратных k1 = {k1}: {count_k1}, k2 = {k2}: {count_k2}");
                }
                else if (count_k1 == 0 && count_k2 == 0)
                {
                    Console.WriteLine($"Количество элементов кратных k1 = {k1}: {count_k1}, k2 = {k2}: {count_k2}");
                }
                else
                {
                    Console.WriteLine($"Количество элементов кратных k1 = {k1}: {count_k1}, k2 = {k2}: {count_k2}");
                }
            }
            else
            {
                Console.WriteLine("На 0 делить нельзя");
            }            
        }
       
        static void Main(string[] args)
        {
            CheckSequence();
        }
    }
}