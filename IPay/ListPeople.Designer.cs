namespace IPay
{
    partial class ListPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.HeadWaiterList = new System.Windows.Forms.RichTextBox();
            this.WaiterList = new System.Windows.Forms.RichTextBox();
            this.CustomerList = new System.Windows.Forms.RichTextBox();
            this.ChefList = new System.Windows.Forms.RichTextBox();
=======
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
>>>>>>> a4aaa0db1cee0ac15d472d3cb54559fe42b3a9b1
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // HeadWaiterList
            // 
            this.HeadWaiterList.Location = new System.Drawing.Point(12, 40);
            this.HeadWaiterList.Name = "HeadWaiterList";
            this.HeadWaiterList.ReadOnly = true;
            this.HeadWaiterList.Size = new System.Drawing.Size(151, 398);
            this.HeadWaiterList.TabIndex = 0;
            this.HeadWaiterList.Text = "";
            // 
            // WaiterList
            // 
            this.WaiterList.Location = new System.Drawing.Point(169, 40);
            this.WaiterList.Name = "WaiterList";
            this.WaiterList.ReadOnly = true;
            this.WaiterList.Size = new System.Drawing.Size(151, 398);
            this.WaiterList.TabIndex = 1;
            this.WaiterList.Text = "";
            // 
            // CustomerList
            // 
            this.CustomerList.Location = new System.Drawing.Point(325, 40);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.ReadOnly = true;
            this.CustomerList.Size = new System.Drawing.Size(151, 398);
            this.CustomerList.TabIndex = 2;
            this.CustomerList.Text = "";
            // 
            // ChefList
            // 
            this.ChefList.Location = new System.Drawing.Point(482, 40);
            this.ChefList.Name = "ChefList";
            this.ChefList.ReadOnly = true;
            this.ChefList.Size = new System.Drawing.Size(151, 398);
            this.ChefList.TabIndex = 3;
            this.ChefList.Text = "";
=======
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(169, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(151, 398);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(325, 40);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(151, 398);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(482, 40);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(151, 398);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "";
>>>>>>> a4aaa0db1cee0ac15d472d3cb54559fe42b3a9b1
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HeadWaiters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waiters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chefs";
            // 
            // ListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
<<<<<<< HEAD
            this.Controls.Add(this.ChefList);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.WaiterList);
            this.Controls.Add(this.HeadWaiterList);
=======
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
>>>>>>> a4aaa0db1cee0ac15d472d3cb54559fe42b3a9b1
            this.Name = "ListPeople";
            this.Text = "ListPeople";
            this.Load += new System.EventHandler(this.ListPeople_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.RichTextBox HeadWaiterList;
        private System.Windows.Forms.RichTextBox WaiterList;
        private System.Windows.Forms.RichTextBox CustomerList;
        private System.Windows.Forms.RichTextBox ChefList;
=======
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
>>>>>>> a4aaa0db1cee0ac15d472d3cb54559fe42b3a9b1
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}