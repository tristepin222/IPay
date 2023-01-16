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
    public partial class ListPeople : Form
    {
        HeadWaiter[] headWaiters;
        Waiter[] waiters;
        Chef[] chefs;
        Customer[] customers;

        public ListPeople(HeadWaiter[] headWaiters, Waiter[] waiters, Chef[] chefs, Customer[] customers)
        {
            this.headWaiters = headWaiters;
            this.waiters = waiters;
            this.chefs = chefs;
            this.customers = customers;
            InitializeComponent();
        }

        private void ListPeople_Load(object sender, EventArgs e)
        {

            foreach(HeadWaiter head in headWaiters)
            {
                this.HeadWaiterList.AppendText(head.name + "\n");
            }

            foreach (Waiter waiter in waiters)
            {
                this.WaiterList.AppendText(waiter.name + "\n");
            }
            foreach (Chef chef in chefs)
            {
                this.ChefList.AppendText(chef.name + "\n");
            }
            foreach (Customer customer in customers)
            {
                this.CustomerList.AppendText(customer.name + "\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
