
using System;

namespace Assignment_inhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Students stud= new Students();
            stud.StudentDetails();
            McaStudents mca=new McaStudents();
            BcaStudents bca=new BcaStudents();

            Console.WriteLine("Enter the stream Mca or Bca");
            string stream=Console.ReadLine();
            if(stream=="mca" ) 
            {
                
                mca.Score();
                mca.Sum();

            }
            else
            {
                bca.Score();
                bca.Sum();
            }
        }
    }
}