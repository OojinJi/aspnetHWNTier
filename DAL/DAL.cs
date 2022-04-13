using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DAL
    {
        CustomerA c1 = new CustomerA(1, "Name1");
        List<CustomerA> custL = new List<CustomerA>();
        for (int i = 0; i<10; i++)
            {
                custL.Add(new CustomerA(i, "Name" + i);
        public List<CustomerA> GetCustomer_DAL()
        {
            return custL;
        }
    }

   

    }
}