using System;
using System.Collections.Generic;
using System.Text;

namespace Raphael
{
    class KitchenWorker:Employee
    {
        public int workTime;

        public KitchenWorker(string Name, DateTime DateOfEmployment, int Pay, int WorkTime)
        : base(Name, DateOfEmployment, Pay)
        {
            workTime = WorkTime;
        }
        public override int GetPrice() 
        {
            return pay * workTime;
        }
        public override void GetInfo()
        {
            Оплата;
            base.GetInfo();
            Console.WriteLine("Кол-во раб. ч.: " + workTime);
           

        }
    }
}
