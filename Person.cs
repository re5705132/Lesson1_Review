using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Review
{
    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public virtual void Print() 
        {
            Console.WriteLine("name:" + LastName+ "  " + FirstName);
        }
    }
   abstract class Employee : Person 
    {
        protected int driving;
        public int SalaryPerHour { get; set; }
        public int NumHours { get; set; }
        /* public new void Print()
         {
             base.Print();
             Console.WriteLine("SalaryPerHour:" + SalaryPerHour + "  " + NumHours);
         }*/
        public override void Print()
        {
            base.Print();
            Console.WriteLine("SalaryPerHour:" + SalaryPerHour + "  " + NumHours);

        }
        public abstract int Driving { get; set; }
    }
}
