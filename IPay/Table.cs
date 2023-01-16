using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPay
{
    public class Table
    {
        public int id;
        public Table(int id)
        {
            this.id = id;
        }
        private Order order;
    }
}
