using System;
using System.Collections.Generic;
using System.Text;

namespace Raphael
{
    class Manager : Employee
    {
        public const int bonus = 100;
        public override int GetPrice()
        {
            return pay + bonus* (DateTime.Now.Year- dateOfEmployment.Year);
        }
        public Manager(string Name, DateTime DateOfEmployment, int Pay)
        : base(Name, DateOfEmployment, Pay){}
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Число рабочих бонусов: " + bonus);
        }
    }
}