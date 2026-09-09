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
                if (choice == "1")
                {
                    for (int i = 0; i < count; i++)
                        Console.WriteLine($"{names[i]} - {prices[i]} руб.");
                }
                else if (choice == "2")
                {
                    double sum = 0, min = prices[0], max = prices[0];
                    for (int i = 0; i < count; i++)
                    {
                        sum += prices[i];
                        if (prices[i] < min) min = prices[i];
                        if (prices[i] > max) max = prices[i];
                    }
                    Console.WriteLine($"Сумма: {sum}, Среднее: {sum / count}, Мин: {min}, Макс: {max}");
                }
                else if (choice == "3")
                {
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = 0; j < count - i - 1; j++)
                        {
                            if (prices[j] > prices[j + 1])
                            {
                                double tempP = prices[j];
                                prices[j] = prices[j + 1];
                                prices[j + 1] = tempP;

                                string tempN = names[j];
                                names[j] = names[j + 1];
                                names[j + 1] = tempN;
                            }
                        }
                    }
                    Console.WriteLine("Отсортировано");
                }
                else if (choice == "4")
                {
                    Console.Write("Введите курс (например 90 для USD): ");
                    double rate = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                        Console.WriteLine($"{names[i]} — {prices[i] / rate}");
                }
            }

            }
        }
}
