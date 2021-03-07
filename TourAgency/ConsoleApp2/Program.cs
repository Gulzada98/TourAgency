using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            ALL_QUERY zz = new ALL_QUERY();
            int end = 0;
            int choice_operation = 0;
            int choice_klass = 0;
            while (end != 1)
            {
                Console.WriteLine("Выберите класс");
                Console.WriteLine("1 - Клиенты       2 - Отели       3 - Туроператоры       4 - Туры       5 - Заказ");
                choice_klass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите операцию");
                Console.WriteLine("0 - добавить данные  1 - показать данные       2 - Изменить       3 - Удалить       4 - Поиск");
                choice_operation = Convert.ToInt32(Console.ReadLine());

                if (choice_klass == 1)
                {
                    zz.Load_Klient();

                    if (choice_operation == 0)
                    {
                        zz.Add_Klient();
                    }
                    else if (choice_operation == 1)
                    {
                        zz.Show_Klient();
                    }
                    else if (choice_operation == 2)
                    {
                        Console.WriteLine("Вы можете изменить адрес, номер телефона и почту. Введите старые данные чтобы мы могли найти клиента ");
                        string tmp = Console.ReadLine();
                        zz.Update_Klient_Info(tmp);
                    }
                    else if (choice_operation == 3)
                    {
                        Console.WriteLine("Для удаления данных о клиенте введите ИИН чтобы мы могли найти клиента и удалить информацию о нем ");
                        string tmp = Console.ReadLine();
                        zz.Delete_Klient_Info(tmp);
                    }
                    else if (choice_operation == 4)
                    {
                        Console.WriteLine("Поиск можно осуществить по двум параметрам. Введите ИИН либо ФИО клиента");
                        string tmp = Console.ReadLine();
                        zz.Search_Klient_Info(tmp);
                    }
                }
                else if (choice_klass == 2)
                {
                    zz.Load_hotels();
                    if (choice_operation == 0)
                    {
                        zz.Add_Hotels();
                    }
                    else if (choice_operation == 1)
                    {
                        zz.Show_Hotels();
                    }
                    else if (choice_operation == 2)
                    {
                        Console.WriteLine("Вы можете изменить название отеля. Введите нынешнее название отеля чтобы мы могли найти и изменить данные ");
                        string tmp = Console.ReadLine();
                        zz.Update_Hotel_Info(tmp);
                    }
                    else if (choice_operation == 3)
                    {
                        Console.WriteLine("Для удаления данных об отеле введите код отеля чтобы мы могли найти и удалить информацию об отеле ");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Delete_Hotel_Info(tmp);
                    }
                    else if (choice_operation == 4)
                    {
                        Console.WriteLine("Поиск можно осуществить по трем параметрам. Введите Страну или город или название отеля");
                        string tmp = Console.ReadLine();
                        zz.Search_Hotel_Info(tmp);
                    }
                }
                else if (choice_klass == 3)
                {
                    zz.Load_Turoperators();
                    if (choice_operation == 1)
                    {
                        zz.Show_Turoperators();
                    }
                    else if (choice_operation == 2)
                    {
                        Console.WriteLine("Вы можете изменить адрес, номер телефона и почту. Введите старые данные чтобы мы могли найти туроператора ");
                        string tmp = Console.ReadLine();
                        zz.Update_Turoperator_Info(tmp);
                        Console.WriteLine("Информационная база после изменения ");
                        zz.Show_Turoperators();
                    }
                    else if (choice_operation == 3)
                    {
                        Console.WriteLine("Для удаления данных о туроператоре введите код туроператора чтобы мы могли найти и удалить информацию ");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Delete_Turoperator_Info(tmp);
                        Console.WriteLine("Информационная база после удаления ");
                        zz.Show_Turoperators();
                    }
                    else if (choice_operation == 4)
                    {
                        Console.WriteLine("Поиск можно осуществить по двум параметрам. Введите код туроператора или название туроператора");
                        string tmp = Console.ReadLine();
                        zz.Search_TurOperator_Info(tmp);
                    }
                }
                else if (choice_klass == 4)
                {
                    zz.Load_TUR();
                    if (choice_operation == 1)
                    {
                        zz.Show_TUR();
                    }
                    else if (choice_operation == 2)
                    {
                        Console.WriteLine("Информацию о ТУРах нельзя изменить ");
                        Console.WriteLine("Вы можете можете добавить новую информацию о ТУРе");
                        zz.Load_hotels();
                        zz.Add_Tur();
                    }
                    else if (choice_operation == 3)
                    {
                        Console.WriteLine("Для удаления данных о ТУРе введите код ТУРа чтобы мы могли найти и удалить информацию ");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Delete_TUR_Info(tmp);
                        Console.WriteLine("Информационная база после удаления ");
                        zz.Show_TUR();
                    }
                    else if (choice_operation == 4)
                    {
                        Console.WriteLine("Поиск можно осуществить по трем параметрам. Введите код ТУРа или цену или класс отеля");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Search_TUR_Info(tmp);
                    }
                }
                else if (choice_klass == 5)
                {
                    zz.Load_Zakaz();
                    zz.Load_Klient();
                    zz.Load_hotels();
                    zz.Load_Turoperators();
                    zz.Load_TUR();

             
                    if (choice_operation == 0)
                    {
                        zz.Add_Zakaz();
                    }
                   else if (choice_operation == 1)
                    {
                        zz.Show_Zakaz();
                    }
                    else if (choice_operation == 2)
                    {
                        Console.WriteLine("Информацию о заказе нельзя изменить ");
                    }
                    else if (choice_operation == 3)
                    {
                        Console.WriteLine("Для удаления данных о заказе введите код заказа чтобы мы могли найти и удалить информацию ");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Delete_ZAKAZ_Info(tmp);
                 
                    }
                    else if (choice_operation == 4)
                    {
                        Console.WriteLine("Поиск можно осуществить по коду заказа. Введите код заказа");
                        int tmp = Convert.ToInt32(Console.ReadLine());
                        zz.Search_ZAKAZ_Info(tmp);
                    }
                }

                Console.WriteLine("Хотите выполнить еще какие - нибудь операций? Если да нажмите 0 / Если хотите выйти нажмите 1");
                end = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}