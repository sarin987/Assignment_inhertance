using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_inhertance
{
    public class Students
    {
        public virtual void StudentDetails()
        {
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            

            Console.WriteLine("Enter your Roll no");
            int Rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your Name is {name} and your Roll no is {Rollno}");

        }
    }
}
