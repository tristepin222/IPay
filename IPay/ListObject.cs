using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPay
{
    public partial class ListObject : Form
    {
        Order[] orders;
        Table[] tables;
        Bill[] bills;

        public ListObject(Order[] orders, Table[] tables, Bill[] bills)
        {
            InitializeComponent();
            this.orders = orders;
            this.tables = tables;   
            this.bills = bills;
        }

        private void ListObject_Load(object sender, EventArgs e)
        {

            foreach (Order order in orders)
            {
                this.OrderList.AppendText(order.id + "\n");
            }

            foreach (Table table in tables)
            {
                this.TableList.AppendText(table.id + "\n");
            }
            foreach (Bill bill in bills)
            {
                this.BillList.AppendText(bill.id + "\n");
            }
            
        }
    }
}
