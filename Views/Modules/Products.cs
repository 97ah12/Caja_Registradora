using Caja_Registradora.DTO;
using Caja_Registradora.Helpers;
using Caja_Registradora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Caja_Registradora.Views.Modules
{
    public partial class Products : UserControl
    {
        /* Declaramos obj DTO y lo ponemos readOnly ya que su instancia solo se creara desde el Constructos de Products
         * Declaramos ProductList
         */
        readonly ProductDTO _objDTO;
        List<Product> _productList;
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
            int code = _productList.Count + 1;
            txtCodigo.Text = Convert.ToString(code);
            txtConsecutivo.Text = txtCodigo.Text;
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
                    ClearFields();
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

        private void ClearFields()
        {
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void Products_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtCodigo.Enabled = false;
            Dock = DockStyle.Fill;
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            RegisterSale();
        }

        private void RegisterSale()
        {
            Sale sale = new()
            {
                ProductCode = int.Parse(txtRefProducto.Text),
                Quantity = int.Parse(txtCantidadaVender.Text),
            };
        }
    }
}
