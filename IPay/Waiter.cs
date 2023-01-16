using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPay
{
    public class Waiter
    {
       
        private Order[] orders;

        //bogus attribute so something can be displayed in the list
        public string name;

        public Waiter(string name)
        {
            this.name = name;
        }
        public void take(Order order)
        {

        }
        public void send (Order order)
        {

        }
    }
}
