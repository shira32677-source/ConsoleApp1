using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            string error = "";

            
            //תיקייה
            string folderPath = "C:\\Users\\amsalem\\Desktop\\תקייה של שירה גזל גמור למי שפותח\\תכנות\\C#\\ConsoleApp1\\C1";
            folderPath.Trim().Trim('"');
            Console.WriteLine(folderPath);
            

            // הגדרת הנתיב המלא של קובץ הטקסט
            string filePath1 = "C:\\Users\\amsalem\\Desktop\\תקייה של שירה גזל גמור למי שפותח\\תכנות\\C#\\c2.txt.txt";
            // 

            
            bool success = prodact.SplitNamesToSeparatedFiles(filePath1, folderPath, out error, ref count);

            if(success==true)
               Console.WriteLine("Created " + count + " files");

            else 
                Console.WriteLine("error");


        }
    }
}
