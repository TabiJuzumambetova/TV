using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            int channelLimit = 20; 
            TV tv = new TV(1, channelLimit);

            Console.WriteLine("Добро пожаловать в имитацию работы телевизора!");

            while (true)
            {
                tv.ShowCurrentChannel();

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Переключить на следующий канал");
                Console.WriteLine("2 - Переключить на предыдущий канал");
                Console.WriteLine("3 - Перейти к каналу по номеру");
                Console.WriteLine("0 - Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Пожалуйста, введите число от 0 до 3.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Программа завершена.");
                        return;
                    case 1:
                        tv.NextChannel();
                        break;
                    case 2:
                        tv.PreviousChannel();
                        break;
                    case 3:
                        Console.WriteLine("Введите номер канала:");
                        int channelNumber;
                        if (int.TryParse(Console.ReadLine(), out channelNumber))
                        {
                            tv.MoveToChannel(channelNumber);
                        }
                        else
                        {
                            Console.WriteLine("Введите число от 1 до " + channelLimit);
                        }
                        break;
                    default:
                        Console.WriteLine("Пожалуйста, выберите от 0 до 3.");
                        break;
                }
            }
        }
    }
}
