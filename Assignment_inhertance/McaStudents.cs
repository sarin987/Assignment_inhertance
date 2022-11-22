using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_inhertance
{
   public class McaStudents : Students
    {
        int Maths, Java, Php;
        public void Score()
        {
            Console.WriteLine("Enter Maths Marks:");
           Maths= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Java Marks:");
             Java = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Php Marks:");
            Php = Convert.ToInt32(Console.ReadLine());
        }

        public void Sum()
        {
            int Total;
            float Result;
            Total=Maths + Java + Php;
            Result=Total * 100/300;
            Console.WriteLine($"Your Total Marks:{Total}");
            Console.WriteLine($"Your Percentage is:{Result}");
        }

        public override void StudentDetails()
        {
            Sum();
            Score();

        }
    }
}
