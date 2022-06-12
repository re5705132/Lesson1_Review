using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Review
{
    class Secretary : Employee, ISaveToFile
    {
        public int Experience { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Experience:" + Experience);
        }

        public override int Driving
        {
            get { return driving * 6; }
            set { driving = value; }
        }

        public string FullFileName
        {
            get
            { return "d:\\dd.txt"; }
            set { }
        }
        public string Content
        {
            get { return "אני מזכירה מהוללה"; }
            set { }
        }
    }
}
