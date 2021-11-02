
namespace Caja_Registradora.Views.Modules
{
    partial class Products
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRefProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadaVender = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnInformedeVentas = new System.Windows.Forms.Button();
            this.btnCierredeCaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAJA REGISTRADORA ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(11, 72);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.ShowEditingIcon = false;
            this.dgvProducts.ShowRowErrors = false;
            this.dgvProducts.Size = new System.Drawing.Size(564, 313);
            this.dgvProducts.TabIndex = 100;
            this.dgvProducts.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(597, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 22);
            this.button5.TabIndex = 15;
            this.button5.Text = "CANTIDAD A VENDER";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(597, 83);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 22);
            this.button6.TabIndex = 16;
            this.button6.Text = "REF. PRODUCTO";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtRefProducto
            // 
            this.txtRefProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefProducto.Location = new System.Drawing.Point(597, 110);
            this.txtRefProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRefProducto.Name = "txtRefProducto";
            this.txtRefProducto.Size = new System.Drawing.Size(204, 23);
            this.txtRefProducto.TabIndex = 17;
            // 
            // txtCantidadaVender
            // 
            this.txtCantidadaVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadaVender.Location = new System.Drawing.Point(597, 184);
            this.txtCantidadaVender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadaVender.Name = "txtCantidadaVender";
            this.txtCantidadaVender.Size = new System.Drawing.Size(204, 23);
            this.txtCantidadaVender.TabIndex = 18;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.Location = new System.Drawing.Point(597, 232);
            this.btnVender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(204, 132);
            this.btnVender.TabIndex = 19;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnInformedeVentas
            // 
            this.btnInformedeVentas.Location = new System.Drawing.Point(17, 20);
            this.btnInformedeVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformedeVentas.Name = "btnInformedeVentas";
            this.btnInformedeVentas.Size = new System.Drawing.Size(171, 32);
            this.btnInformedeVentas.TabIndex = 0;
            this.btnInformedeVentas.Text = "INFORME DE VENTAS";
            this.btnInformedeVentas.UseVisualStyleBackColor = true;
            // 
            // btnCierredeCaja
            // 
            this.btnCierredeCaja.Location = new System.Drawing.Point(17, 56);
            this.btnCierredeCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCierredeCaja.Name = "btnCierredeCaja";
            this.btnCierredeCaja.Size = new System.Drawing.Size(171, 32);
            this.btnCierredeCaja.TabIndex = 1;
            this.btnCierredeCaja.Text = "CIERRE DE CAJA";
            this.btnCierredeCaja.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCierredeCaja);
            this.groupBox1.Controls.Add(this.btnInformedeVentas);
            this.groupBox1.Location = new System.Drawing.Point(597, 397);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(204, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "CONSECUTIVO";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(63, 7);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(110, 23);
            this.txtFecha.TabIndex = 2;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(664, 4);
            this.txtConsecutivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(110, 23);
            this.txtConsecutivo.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.txtConsecutivo);
            this.panelHeader.Controls.Add(this.txtFecha);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Location = new System.Drawing.Point(11, 21);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(789, 39);
            this.panelHeader.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.Location = new System.Drawing.Point(150, 75);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 22);
            this.btnActualizar.TabIndex = 112;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(307, 75);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 22);
            this.btnEliminar.TabIndex = 111;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Location = new System.Drawing.Point(445, 75);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 22);
            this.btnBuscar.TabIndex = 110;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescripcion.Location = new System.Drawing.Point(150, 38);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(110, 23);
            this.txtDescripcion.TabIndex = 109;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantidad.Location = new System.Drawing.Point(307, 38);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(110, 23);
            this.txtCantidad.TabIndex = 108;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecio.Location = new System.Drawing.Point(445, 38);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 23);
            this.txtPrecio.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "PRECIO";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 105;
            this.label5.Text = "DESCRIPCION";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigo.Location = new System.Drawing.Point(4, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 23);
            this.txtCodigo.TabIndex = 104;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrear.Location = new System.Drawing.Point(4, 75);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(109, 22);
            this.btnCrear.TabIndex = 103;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 101;
            this.label4.Text = "CODIGO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Location = new System.Drawing.Point(11, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 104);
            this.panel1.TabIndex = 113;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtCantidadaVender);
            this.Controls.Add(this.txtRefProducto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(816, 511);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRefProducto;
        private System.Windows.Forms.TextBox txtCantidadaVender;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCierredeCaja;
        private System.Windows.Forms.Button btnInformedeVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}
