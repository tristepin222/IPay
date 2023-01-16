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

        Order[] orders;
        Table[] tables;
        Bill[] bills;

        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            headWaiters = new HeadWaiter[2];
            for (int i = 0; i < headWaiters.Length; i++) { headWaiters[i] = new HeadWaiter("bill" + i); };
            waiters = new Waiter[4];
            for (int i = 0; i < waiters.Length; i++) { waiters[i] = new Waiter("franc" + i); };
            chefs = new Chef[2];
            for (int i = 0; i < chefs.Length; i++) { chefs[i] = new Chef("peter" + i); };
            customers = new Customer[12];
            for (int i = 0; i < customers.Length; i++) { customers[i] = new Customer("henry" + i); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void List_Click(object sender, EventArgs e)
        {
           
            ListPeople win = new ListPeople(headWaiters, waiters, chefs, customers);
            win.Show();
        }

        private void GenerateObjects_Click(object sender, EventArgs e)
        {

            orders = new Order[12];
            for (int i = 0; i < orders.Length; i++) { orders[i] = new Order(i); };
            tables = new Table[4];
            for (int i = 0; i < tables.Length; i++) { tables[i] = new Table(i); };
            bills = new Bill[4];
            for (int i = 0; i < bills.Length; i++) { bills[i] = new Bill(i); };
        }

        private void ListObjects_Click(object sender, EventArgs e)
        {
            ListObject win = new ListObject(orders, tables, bills);
            win.Show();
        }
    }
}
