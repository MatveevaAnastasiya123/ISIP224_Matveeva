using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP224_Matveeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во операций от 2 до 40");
            int count = Convert.ToInt16(Console.ReadLine());
            if(count<2 || count > 40)
            {
                Console.WriteLine("Ошибка. Введите кол-во операций от 2 до 40");
                return;
            }
            string[] names = new string[count];
            double[] prices = new double[count];

            Console.WriteLine("Введите данные по очереди:");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Трата {i + 1} (Название; Цена): ");
                string[] parts = Console.ReadLine().Split(';');
                names[i] = parts[0].Trim();
                prices[i] = Convert.ToDouble(parts[1].Trim());
            }
            while (true)
            {
                Console.WriteLine("\n1-Вывод, 2-Статистика, 3-Сортировка, 4-Конвертация, 5-Поиск, 0-Выход");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                if (choice == "0") break;
            }
            }
        }
}
