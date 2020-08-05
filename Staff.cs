using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    class Staff:Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff() { }
        public Staff(string School, double Pay, string Name, string Address) :base (Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string ToString()
        {
            return $"Staff: {Name}\tAddress: {Address}\nSchool: {School}\nPay: {Pay}";
        }
    }
}
