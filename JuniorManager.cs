using System;
using System.Collections.Generic;
using System.Text;

namespace Raphael
{
    class JuniorManager : Manager
    {
        public override int GetPrice()
        {
            if (DateTime.Now.Month == 12 || DateTime.Now.Month == 6)
                return pay + bonus * (DateTime.Now.Year - dateOfEmployment.Year);
            else
                return -pay;
        }
        public JuniorManager(string Name, DateTime DateOfEmployment, int Pay)
        : base(Name, DateOfEmployment, Pay){ }
    }
}
