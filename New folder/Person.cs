using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIT
{
    class Person
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public List<Expense> Expenses { get; set; }


        public override String ToString()
        {
            return this.Name;
        }


    }
}
