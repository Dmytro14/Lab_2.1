using System;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Введiть номер мiсяця");
            m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                    Console.WriteLine(" Сiчень");
                    break;
                case 2:
                    Console.WriteLine(" Лютий");
                    break;
                case 3:
                    Console.WriteLine(" Березень");
                    break;
                case 4:
                    Console.WriteLine(" Квiтень");
                    break;
                case 5:
                    Console.WriteLine(" Травень");
                    break;
                case 6:
                    Console.WriteLine(" Червень");
                    break;
                case 7:
                    Console.WriteLine(" Липень");
                    break;
                case 8:
                    Console.WriteLine(" Серпень");
                    break;
                case 9:
                    Console.WriteLine(" Вересень");
                    break;
                case 10:
                    Console.WriteLine(" Жовтень");
                    break;
                case 11:
                    Console.WriteLine(" Листопад");
                    break;
                case 12:
                    Console.WriteLine(" Грудень");
                    break;
                default:
                    Console.WriteLine(" Невiрне число, iснує всього 12 мiсяцiв");
                    break;
            }
        }
    }
}
