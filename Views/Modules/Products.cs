﻿using Caja_Registradora.DTO;
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
        SaleDTO _saleDTO;
        List<Product> _productList;
        Product _product;
        public Products()
        {
            /*Instanciamos el obj DTO y ProductList
            Llamamos el metodo LoadGrid
            */
            InitializeComponent();
            _objDTO = new();
            _saleDTO = new();
            _productList = new();
            _product = new();
            LoadGrid();
        }

        #region Methods

        private void LoadGrid()
        {
            //
            _productList = _objDTO.GetProductList();
            var list = new BindingList<Product>(_productList);
            dgvProducts.DataSource = list;
            //
            int code = _productList.Count + 1;
            txtCodigo.Text = Convert.ToString(code);
            txtConsecutivo.Text = txtCodigo.Text;
            //
            comboProducts.DataSource = _productList;
            comboProducts.DisplayMember = "Description";
            comboProducts.ValueMember = "Code";
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
            txtCodigo.Text = txtConsecutivo.Text;
        }
        private void RegisterSale()
        {
            Sale sale = new()
            {
                ProductCode = comboProducts.SelectedValue.ToString(),
                Quantity = int.Parse(txtCantidadaVender.Text),
                SaleDate = DateTime.Now
            };
            Sale saleResponse = _saleDTO.SaleProduct(sale);
            if (saleResponse.IsCorrect)
            {
                MessageHelper.ShowMessage($"Venta registrada Correctamente total a pagar {sale.TotalSale}");
            }
            else
                MessageHelper.ShowErrorMessage("La venta no puede completarse la cantidad de productos no es Suficiente");
        } 
   
        #endregion

        #region Events

        private void Products_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtCodigo.Enabled = false;
            Dock = DockStyle.Fill;
            btnActualizar.Enabled = false;
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            RegisterSale();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        // Evento Key Press para identificar cuando se presiona una tecla en este Combo se hace para Validar que solo se ingresen datos numericos 
        private void txtCantidadaVender_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada no sea control o algun digito Numerico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Aca permito los Numero flotantes y decimales
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void BtnInformedeVentas_Click(object sender, EventArgs e)
        {

        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productCode = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            FillProductInfo(productCode);
        }

        private void FillProductInfo(string productCode)
        {
            _product = _objDTO.GetProductByCode(productCode);
            txtCodigo.Text = _product.Code;
            txtDescripcion.Text = _product.Description;
            txtPrecio.Text = Convert.ToString(_product.Price);
            txtCantidad.Text = Convert.ToString(_product.Quantity);
            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtConsecutivo.Text;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            btnCrear.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string productCode = txtCodigo.Text;
            UpdateSelectedProduct(productCode);
        }

        private void UpdateSelectedProduct(string productCode)
        {
            _product = _productList.Find(p => p.Code == productCode);
            _product.Description = txtDescripcion.Text;
            _product.Price = float.Parse(txtPrecio.Text);
            _product.Quantity = int.Parse(txtCantidad.Text);
            _product = _objDTO.UpdateSelectedProduct(_product);
            LoadGrid();
            ClearFields();
        }
    }
}
