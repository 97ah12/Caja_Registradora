
namespace Caja_Registradora.Views
{
    partial class Main
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonSales = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuPanel.Controls.Add(this.buttonSales);
            this.menuPanel.Controls.Add(this.productButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // buttonSales
            // 
            this.buttonSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Location = new System.Drawing.Point(6, 170);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(191, 32);
            this.buttonSales.TabIndex = 1;
            this.buttonSales.Text = "Ventas";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.ButtonSales_Click);
            // 
            // productButton
            // 
            this.productButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productButton.Location = new System.Drawing.Point(6, 118);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(191, 32);
            this.productButton.TabIndex = 0;
            this.productButton.Text = "Productos";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 450);
            this.mainPanel.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonSales;
    }
}