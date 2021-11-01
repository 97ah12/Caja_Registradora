using Caja_Registradora.DTO;
using Caja_Registradora.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Registradora.Views.Modules
{
    public partial class Product : UserControl
    {
        /* Declaramos obj DTO
         * Declaramos ProductList
         */
        ProductDTO _objDTO;
        List<Models.Product> _productList;
        public Product()
        {
            /*Instanciamos el obj DTO y ProductList
            Llamamos el metodo LoadGrid
            */
            InitializeComponent();
            _objDTO = new();
            _productList = new();
            LoadGrid();
        }

        private void LoadGrid()
        {
            _productList = _objDTO.GetProductList();
            dgvProducts.DataSource = _productList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        private void CreateProduct()
        {
            try
            {
                Models.Product product = new Models.Product()
                {
                    Code = txtCodigo.Text,
                    Price = float.Parse(txtPrecio.Text),
                    Quantity = int.Parse(txtPrecio.Text),
                    Description = txtDescripcion.Text
                };
                bool createProductResponse = _objDTO.CreateProduct(product);
                if (createProductResponse)
                {
                    MessageHelper.ShowMessage("Producto creado satisfactoriamente");
                }
                else
                    MessageHelper.ShowErrorMessage("El producto no se creó, por alguna razón");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }
        
        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
