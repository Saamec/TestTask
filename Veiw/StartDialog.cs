using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Veiw
{
    public class StartDialog
    {
        public string fileDirection { get; set; }

        public string CheckDirection()
        {
            Console.WriteLine("Введите путь к файлу с показаниями счетчиков");
             
            try
            {
                fileDirection = Console.ReadLine();  
                if (!File.Exists(fileDirection)) throw new FileNotFoundException();
                    Console.WriteLine("Файл принят к обработке");
            }
            catch (Exception ex) { Console.WriteLine("Не удается распознать файл"); }
            
            return fileDirection;
        }
    }
}
