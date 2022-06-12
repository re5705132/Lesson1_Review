using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Review
{
    interface ISaveToFile
    {
         string FullFileName { get; set; }
         string Content { get; set; }

    }
    static class SaveToFileImplement 
    {
        public static void SaveToFile(this ISaveToFile f) 
        {
            Console.WriteLine("saving in path:" + f.FullFileName + " content is:" + f.Content );
        }
    }
}
