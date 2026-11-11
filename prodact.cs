using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class prodact
    {

        //filePath=קובץ
        //directoryPath=תיקייה
        static public bool SplitNamesToSeparatedFiles(string filePath, string directoryPath, out string errStr, ref int numberStudents) 
        {
           
            
            
             
            //אם הנתיב של הקובץ לא קיים תחזיר NULL
                  if (!File.Exists(filePath)) 
                   {
                    errStr = "File not found";
                     return false;
                    }
            
            
            //אם הנתיב של התיקייה לא קיים תיצור אותה
            
                  if (!Directory.Exists(directoryPath))
                       Directory.CreateDirectory(directoryPath);
           
                      


            string products = File.ReadAllText(filePath);

            string[] str = products.Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                string name = str[i].Trim();
                string fullPath = Path.Combine(directoryPath, name + ".txt");
                File.WriteAllText(fullPath, "");
                numberStudents++;
                
            }
              return true;
            
        }


    }
}
