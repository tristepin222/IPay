namespace IPay
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generate = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.GenerateObjects = new System.Windows.Forms.Button();
            this.ListObjects = new System.Windows.Forms.Button();
            this.TakeOrder = new System.Windows.Forms.Button();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(679, 12);
            this.Generate.Name = "Generate";
            this.Generate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Generate.Size = new System.Drawing.Size(109, 157);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate People";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(679, 175);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(109, 263);
            this.List.TabIndex = 1;
            this.List.Text = "List People";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // GenerateObjects
            // 
            this.GenerateObjects.Location = new System.Drawing.Point(564, 12);
            this.GenerateObjects.Name = "GenerateObjects";
            this.GenerateObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenerateObjects.Size = new System.Drawing.Size(109, 157);
            this.GenerateObjects.TabIndex = 2;
            this.GenerateObjects.Text = "Generate Objects";
            this.GenerateObjects.UseVisualStyleBackColor = true;
            this.GenerateObjects.Click += new System.EventHandler(this.GenerateObjects_Click);
            // 
            // ListObjects
            // 
            this.ListObjects.Location = new System.Drawing.Point(564, 175);
            this.ListObjects.Name = "ListObjects";
            this.ListObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListObjects.Size = new System.Drawing.Size(109, 263);
            this.ListObjects.TabIndex = 3;
            this.ListObjects.Text = "List Objects";
            this.ListObjects.UseVisualStyleBackColor = true;
            this.ListObjects.Click += new System.EventHandler(this.ListObjects_Click);
            // 
            // TakeOrder
            // 
            this.TakeOrder.Location = new System.Drawing.Point(12, 12);
            this.TakeOrder.Name = "TakeOrder";
            this.TakeOrder.Size = new System.Drawing.Size(193, 57);
            this.TakeOrder.TabIndex = 4;
            this.TakeOrder.Text = "Take order as waiter 0";
            this.TakeOrder.UseVisualStyleBackColor = true;
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.Location = new System.Drawing.Point(12, 75);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(193, 57);
            this.ConfirmOrder.TabIndex = 5;
            this.ConfirmOrder.Text = "Confirm Order as Chef 0";
            this.ConfirmOrder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.TakeOrder);
            this.Controls.Add(this.ListObjects);
            this.Controls.Add(this.GenerateObjects);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button GenerateObjects;
        private System.Windows.Forms.Button ListObjects;
        private System.Windows.Forms.Button TakeOrder;
        private System.Windows.Forms.Button ConfirmOrder;
    }
}

