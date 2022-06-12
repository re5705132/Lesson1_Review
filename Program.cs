using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Person p = new Person { LastName="Cohen",FirstName="tamar"};
             Employee employee = new Secretary { LastName="Levi",FirstName="shira",SalaryPerHour=50,NumHours=200};
             Console.WriteLine("------------p.Print() -----------");
             p.Print();
             Console.WriteLine("------------employee.Print(); -----------");

             employee.Print();
             Console.WriteLine("------------Person p1 = employee; p1.Print();-----------");

             Person p1 = employee;
             p1.Print();
             //interface:
             Secretary sec = new Secretary 
             { 
                 LastName = "Levi", FirstName = "shira"
                 , SalaryPerHour = 50, NumHours = 200 
                 ,Driving=5
                 ,Experience=3};
             ISaveToFile c = sec;
             SaveToFileImplement.SaveToFile(c);
             SaveToFileImplement.SaveToFile(sec);
             SaveToFileImplement.SaveToFile(employee as Secretary);
             sec.SaveToFile();*/
            List<Person> people = new List<Person>() 
            {
            new Person{ LastName = "Levi", FirstName = "shira" },
            new Person{ LastName = "Israeli", FirstName = "shani" },
            new Person{ LastName = "Levi", FirstName = "shoshi" },
            new Person{ LastName = "Levi", FirstName = "shiffi" },
            new Person{ LastName = "Levi", FirstName = "chani" },
            new Person{ LastName = "Levi", FirstName = "chavi" },
            new Person{ LastName = "Levi", FirstName = "chagai" }
            };
            for (int i = 0; i < people.Count; i++)
            {
               // if(people[i].FirstName[0]=='c')
                  //  people[i].Print();
            }
            //משתנה מקומי מוגדר
            var i = 8;
            var ss = "shalom";
            //var q = null;//אין לבצע השמה של נאל
            //טיפוס אנונימי
            var fruit = new { FruitName = "peach", Weigt = 100, Color = ConsoleColor.Red };
            fruit = new { FruitName = "olive", Weigt = 50, Color = ConsoleColor.DarkGreen };

            //שאילתת לינק בתחביר ארוך
            var q = from Person p //משתנה האיטרציה
                    in people//שם האוסף
                    where p.FirstName[0] == 'c'//תנאי
                    orderby p.FirstName ascending
                    select p;//העמודה שתישלף
           // foreach (var item in q)
               // item.Print();

             var q1 = from Person p //משתנה האיטרציה
                   in people//שם האוסף
                    
                    orderby p.FirstName ascending
                    select new { FullName = p.FirstName + " " + p.LastName,FirstLetter=p.FirstName[0] };//העמודה שתישלף
            
            foreach (var item in q1)
            {
                Console.WriteLine("Full name:" +item.FullName + "  first letter:"+ item.FirstLetter);
            }
            //select
            
        }
    }
}
