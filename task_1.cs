namespace task_6
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
        /// Проверка, является ли число простым
        /// </summary>
        /// <param name="n"></param>
        static void IsSimple(out int n)
        {
            n = ReadInt();
            int i = 2, res;
            do
            {
                res = n % i;
                i++;
                if (n == 0 | n == 1)
                {
                    Console.WriteLine($"{n} не простое");
                    break;
                }
                else if (n == 2)
                {
                    Console.WriteLine($"{n} простое");
                    break;
                }
                else if (res % i == 0)  //если остаток деления числа n на i равен 0, число составное
                {
                    Console.WriteLine($"{n} составное");
                }
                if (n == i)            //иначе увеличиваем i до тех пор, пока не выполнится условие n == i
                {
                    Console.WriteLine($"{n} простое");
                    break;
                }

            }
            while (res != 0);
        }

        static void Main(string[] args)
        {
            IsSimple(out int n);
        }
    }
}