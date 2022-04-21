using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
   public  class Personel:IEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string  Name { get; set; }

    }
}
