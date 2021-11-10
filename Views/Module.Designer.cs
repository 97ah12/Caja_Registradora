
namespace Caja_Registradora.Views
{
    partial class Module
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnCloseSale = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnCloseSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 72);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 378);
            this.panelContainer.TabIndex = 1;
            // 
            // btnCloseSale
            // 
            this.btnCloseSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSale.Location = new System.Drawing.Point(315, 23);
            this.btnCloseSale.Name = "btnCloseSale";
            this.btnCloseSale.Size = new System.Drawing.Size(153, 30);
            this.btnCloseSale.TabIndex = 0;
            this.btnCloseSale.Text = "Cerrar Venta";
            this.btnCloseSale.UseVisualStyleBackColor = true;
            this.btnCloseSale.Click += new System.EventHandler(this.btnCloseSale_Click);
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Module";
            this.Text = "Module";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCloseSale;
    }
}