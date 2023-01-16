namespace IPay
{
    partial class ListObject
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BillList = new System.Windows.Forms.RichTextBox();
            this.TableList = new System.Windows.Forms.RichTextBox();
            this.OrderList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Orders";
            // 
            // BillList
            // 
            this.BillList.Location = new System.Drawing.Point(326, 40);
            this.BillList.Name = "BillList";
            this.BillList.ReadOnly = true;
            this.BillList.Size = new System.Drawing.Size(151, 398);
            this.BillList.TabIndex = 10;
            this.BillList.Text = "";
            // 
            // TableList
            // 
            this.TableList.Location = new System.Drawing.Point(169, 40);
            this.TableList.Name = "TableList";
            this.TableList.ReadOnly = true;
            this.TableList.Size = new System.Drawing.Size(151, 398);
            this.TableList.TabIndex = 9;
            this.TableList.Text = "";
            // 
            // OrderList
            // 
            this.OrderList.Location = new System.Drawing.Point(12, 40);
            this.OrderList.Name = "OrderList";
            this.OrderList.ReadOnly = true;
            this.OrderList.Size = new System.Drawing.Size(151, 398);
            this.OrderList.TabIndex = 8;
            this.OrderList.Text = "";
            // 
            // ListObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillList);
            this.Controls.Add(this.TableList);
            this.Controls.Add(this.OrderList);
            this.Name = "ListObject";
            this.Text = "ListObject";
            this.Load += new System.EventHandler(this.ListObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox BillList;
        private System.Windows.Forms.RichTextBox TableList;
        private System.Windows.Forms.RichTextBox OrderList;
    }
}