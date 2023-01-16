using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPay
{
    public class HeadWaiter : Waiter
    {

        public HeadWaiter(string name) : base(name)
        {
            this.name = name;

        }
        public void validate(Order order)
        {

        }
        public void makeDiscount(Bill bill)
        {

        }
    }
}
