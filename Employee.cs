using System;
using System.Collections.Generic;
using System.Text;

namespace Raphael
{
    abstract class Employee
    {
        protected string name;
        protected DateTime dateOfEmployment;
        protected int pay;
        public virtual void GetInfo() 
        {
            Console.WriteLine("Имя: " + name + "\nДата найма: " + dateOfEmployment + "\nСтавка " + pay);
        }
        public virtual int GetPrice() { return 0; }
        public Employee(string Name, DateTime DateOfEmployment, int Pay)
        {
            name = Name;
            dateOfEmployment = DateOfEmployment;
            pay = Pay;

        }
    }
}
