using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string id { get; set; }
        public Program program;
        public override string ToString()
        {
            string s = "";
            switch ((int)program) {
                case 1: s = "ComputerScience";
                    break;
                case 2:
                    s = "Accounting";
                    break;
                case 3:
                    s = "Marketing";
                    break;
                case 4:
                    s = "Nursing";
                    break;

            }
            return "Name: " + Name + " Age: " + " Id: " + id + " program: " + s;
        }

    }
    public enum Program { ComputerScience =1, Accounting=2, Marketing=3, Nursing=4}
}
