using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPay
{
    public class Bill
    {
        public int id;
        public Bill(int id)
        {
            this.id = id;
        }
        private Customer customer;
    }
}
