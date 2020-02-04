using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter enter a 1) Student, 2) Teacher, 3) End:");
          var personRole=  Console.ReadLine();
            List<Person> People = new List<Person>();
            while (!personRole.Contains("3"))
            {
                if (personRole == "1")
                {
                    var p = new Student();

                    Console.WriteLine("Name: ");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    p.Age = Console.ReadLine();
                    Console.WriteLine("Id: ");
                    p.id = Console.ReadLine();
                    Console.WriteLine("Program: [1) Computer Science, 2) Accounting, 3) Marketing, 4)Nursing, 5)End ");
                    int program1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Credits Earned: ");
                    p.creditsEarned = Console.ReadLine();
                    p.program = (Program)program1;
                    People.Add(p);
                }
                if (personRole == "2")
                {
                    var p = new teacher();
                    Console.WriteLine("Name: ");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    p.Age = Console.ReadLine();
                    Console.WriteLine("Id: ");
                    p.id = Console.ReadLine();
                    Console.WriteLine("Program: [1) Computer Science, 2) Accounting, 3) Marketing, 4)Nursing, 5)End ");
                    int program1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Years of Service:  ");
                    p.yearsOfService = Console.ReadLine();
                    p.program = (Program)program1;
                    People.Add(p);
                }
                Console.WriteLine("Please enter enter a 1) Student, 2) Teacher, 3) End:");
                personRole = Console.ReadLine();
            }
            
                for (int i = 0; i < People.Count; i++)
                {
                    Console.WriteLine(People[i].ToString());
                }
            Console.ReadLine();
        }
    }
}
