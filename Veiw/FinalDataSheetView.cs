using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BLL;

namespace TestTask.Veiw
{
    public class FinalDataSheetView
    {
        public static void Show(List<Entity> valueList)
        {
            Console.WriteLine("№ строки;Улица;№ дома;№ Квартиры;Апрель;Май;Июнь;Пок Апрель-Май;Пок Май-Июнь");
            foreach (var item in valueList) Console.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                item.Id, item.Street, item.House, item.kv, item.month1Pok, item.month2Pok,
                item.month3Pok, item.perMon1Mon2, item.perMon2Mon3);
        }
    }
}
