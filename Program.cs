using System;
using System.Collections.Generic;

namespace Raphael
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mass = new List<Employee> {

            new KitchenWorker("Константин", new DateTime(2014, 03, 09), 15000, 1),
            new KitchenWorker("Ренат", new DateTime(2021, 04, 09), 65000, 3),
            new Waiter("Данил", new DateTime(2022, 12, 31), 1000, 1, 12500),
            new Waiter("Кирилл", new DateTime(2017, 04, 07), 16352, 8, 780),
            new Manager("Данияр", new DateTime(2011, 08, 17), 21750),
            new JuniorManager("Петр", new DateTime(2023, 05, 05), 12500)
            };
            /*foreach (Employee Emp in massмладший менеджер)
            {
                Emp.GetInfo();
                Console.WriteLine("Пересчитанная зарплата: " + Emp.GetPrice());
            }*/

            foreach (Employee Emp in mass)
            {
               Emp.GetInfo();
               Console.WriteLine("Пересчитанная зарплата: " + Emp.GetPrice());
               if(Emp is KitchenWorker)
                {
                    Console.WriteLine("Должность - Работник кухни");
                    
                }
               else if(Emp is Waiter)
                {
                    Console.WriteLine("Должность - Официант");
                }
                else if (Emp is JuniorManager)
                {
                    Console.WriteLine("Должность - Младший Менеджер");
                }

                else if (Emp is Manager)
                {
                    Console.WriteLine("Должность - Менеджер");
                }
                Console.WriteLine("==============");
            }


          /*  foreach (Employee Emp in mass)
            {
                switch (Emp)
                {
                    case KitchenWorker:

                }
            }*/
        }
    }
}
