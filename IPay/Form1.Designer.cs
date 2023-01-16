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
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(679, 12);
            this.Generate.Name = "Generate";
            this.Generate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Generate.Size = new System.Drawing.Size(109, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate People";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(679, 41);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(109, 23);
            this.List.TabIndex = 1;
            this.List.Text = "List People";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

