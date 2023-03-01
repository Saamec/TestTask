using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL
{
    public class СonsumerСhecker
    {
        public static void Check(List<Entity> valueTable)
        {
            var countStreets = valueTable.Select(c => c.Street).ToHashSet().Count();
            var uniqStreets = valueTable.Select(c => c.Street).ToHashSet().ToList();
            for (int i = 0; i < countStreets; i++)
            {
                var countHouse = valueTable.Where(x => x.Street == uniqStreets[i]).
                Select(y => y.House).Max();
                for (int j = 1; j <= countHouse; j++)
                {
                    var sumCheck = valueTable.Where(x => x.Street == uniqStreets[i]).
                                    Where(y => y.House == j).Where(z => z.kv > 0).Select(c => c.perMon1Mon2).Sum();
                    var controlCheck = valueTable.Where(x => x.Street == uniqStreets[i]).
                        Where(y => y.House == j).Where(z => z.kv == 0).Select(c => c.perMon1Mon2).Sum();
                    if (sumCheck != controlCheck) Console.WriteLine("Внимание! Улица {0} Дом {1} Неверные показания!", uniqStreets[i], j);
                }

            }
            
        }
    }
}
