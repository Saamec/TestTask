using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.BLL
{
    public class Entity
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int kv { get; set; }
        public int month1Pok { get; set; }
        public int month2Pok { get; set; }
        public int month3Pok { get; set; }
        public int perMon1Mon2 { get; set; }
        public int perMon2Mon3 { get; set; }

        public Entity(int id, string street, int house, int kv, int month1Pok, int month2Pok, int month3Pok, int perMon1Mon2, int perMon2Mon3)
        {
            Id = id;
            Street = street;
            House = house;
            this.kv = kv;
            this.month1Pok = month1Pok;
            this.month2Pok = month2Pok;
            this.month3Pok = month3Pok;
            this.perMon1Mon2 = perMon1Mon2;
            this.perMon2Mon3 = perMon2Mon3;
        }
    }
}
