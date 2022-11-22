using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_inhertance
{

    public class BcaStudents : Students
    {
        int Os, Python,Sap;
        public void Score()
        {
            Console.WriteLine("Enter Os Marks:");
            Os = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Python Marks:");
            Python = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sap Marks:");
            Sap = Convert.ToInt32(Console.ReadLine());
        }

        public void Sum()
        {
            int Total;
            float Result;
            Total = Os + Python + Sap;
            Result = Total * 100 / 300;
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

