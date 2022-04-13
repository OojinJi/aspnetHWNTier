using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class CustomerA
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public CustomerA(int id, string name)
        {

            Name = name;
            ID = id;
        }
    }
}
