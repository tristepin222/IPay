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
    public partial class Form1 : Form
    {
        HeadWaiter[] headWaiters;
        Waiter[] waiters;
        Chef[] chefs;
        Customer[] customers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            headWaiters = new HeadWaiter[2];
            waiters = new Waiter[4];
            chefs = new Chef[2];
            customers = new Customer[12];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void List_Click(object sender, EventArgs e)
        {
            ListPeople win = new ListPeople(headWaiters, waiters, chefs, customers);
            win.Show();
        }
     
    }
}
