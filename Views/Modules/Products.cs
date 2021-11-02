using Caja_Registradora.DTO;
using Caja_Registradora.Helpers;
using Caja_Registradora.Models;
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
    public partial class Products : UserControl
    {
        /* Declaramos obj DTO
         * Declaramos ProductList
         */
        ProductDTO _objDTO;
        List<Models.Product> _productList;
        public Products()
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
            var list = new BindingList<Product>(_productList);
            dgvProducts.DataSource = list;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        private void CreateProduct()
        {
            try
            {
                Product product = new()
                {
                    Code = txtCodigo.Text,
                    Price = float.Parse(txtPrecio.Text),
                    Quantity = int.Parse(txtCantidad.Text),
                    Description = txtDescripcion.Text
                };
                bool createProductResponse = _objDTO.CreateProduct(product);
                if (createProductResponse)
                {
                    MessageHelper.ShowMessage("Producto creado satisfactoriamente");
                    LoadGrid();
                }
                else
                    MessageHelper.ShowErrorMessage("El producto no se creó, por alguna razón");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            Dock = DockStyle.Fill;
        }
    }
}
