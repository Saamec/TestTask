using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL
{
    public class FileEntityParser
    {
        public static List<Entity> Parser(List<string> valueList)
        {
            List<Entity> EntityList = new List<Entity>();
            for (int i = 1; i < valueList.Count; i++)
            {
                var entityContext = valueList[i].Split(";").ToArray();
                int value1 = int.Parse(entityContext[5]) - int.Parse(entityContext[4]);
                int value2 = int.Parse(entityContext[6]) - int.Parse(entityContext[5]);
                Entity newEntity = new Entity(int.Parse(entityContext[0]), entityContext[1],
                    int.Parse(entityContext[2]), int.Parse(entityContext[3]),
                    int.Parse(entityContext[4]), int.Parse(entityContext[5]),
                    int.Parse(entityContext[6]), value1, value2);
                EntityList.Add(newEntity);
            }
            return EntityList;
        }
    }

}
