using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    class Student:Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student() { }
        public Student(string Program, int Year, double Fee, string Name, string Address) :base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public override string ToString()
        {
            return $"Staff: {Name}\tAddress: {Address}\nProgram: {Program}\nYear: {Year}\nFee: {Fee}";
        }
    }
}
