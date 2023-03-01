using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL
{
    public class FileReader
    {
        public static List<string> Reader(string nameFile, List<string> readingAll)
        {
            using (var r = new StreamReader(nameFile))
            {
                while (!r.EndOfStream)
                {
                    var line = r.ReadLine();
                    if (line != null) readingAll.Add(line);
                }
            }
            return readingAll;
        }
    }
}
