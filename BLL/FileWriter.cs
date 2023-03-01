using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL
{
    public class FileWriter
    {
        public static void Writer(string nameFile, List<Entity> writingAll)
        {
            using (var writer = new StreamWriter(nameFile))
            {
                writer.WriteLine("№ строки;Улица;№ дома;№ Квартиры;Апрель;Май;Июнь;Пок Апрель-Май;Пок Май-Июнь");
                foreach (var entity in writingAll)
                {
                    writer.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                        entity.Id, entity.Street, entity.House,
                        entity.kv, entity.month1Pok, entity.month2Pok,
                        entity.month3Pok, entity.perMon1Mon2, entity.perMon2Mon3);
                }
            }
        }
    }
}
