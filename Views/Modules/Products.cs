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
        readonly SaleDTO _saleDTO;
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
        //Creamos metdo LoadGrid que nos ayuda a cargar los datos en el Grid
        private void LoadGrid()
        {
            int code = 0;
            // Obtengo la Lista de productos Actualizada atravez de mi Objeto DTO
            _productList = _objDTO.GetProductList();
            if (_productList == null)
                MessageHelper.ShowErrorMessage("La lista de productos está vacia. Agregue uno");
            else{
                //Creo variable "Anonima" con var que no necesita especificar un tipo de dato ya que toma el que venga 
                //en el metodo que se llame despues 
                var list = new BindingList<Product>(_productList);
                // Seteo la propiedad DataSource del Grid dgvProducts con la BindingList<Product>
                dgvProducts.DataSource = list;
                if (_productList.Count == 0)
                    code = 0;
                else
                    //Obtengo el ultimo codigo registrado encontrando el Ultimo index de producto registrado y el Modelo de Producto
                    code = int.Parse(_productList[_productList.Count - 1].Code);
                //Cargo el Combo Box con los elementos de la Lista _productList
                comboProducts.DataSource = _productList;
                // Seleciono la propiedad del modelo que quiero que sea la que se vea al usuario
                comboProducts.DisplayMember = "Description";
                // Seleciono la propiedad de valor en el Combo Box en este caso el Codigo de producto
                comboProducts.ValueMember = "Code";
            }
            //Luego en la caja de texto pongo el ultimo codigo de producto mas 1 que es el codigo del siguiente producto
            txtCodigo.Text = Convert.ToString(code + 1);
            //Seteo el campo de texto Consecutivo igual al campo texto
            txtConsecutivo.Text = txtCodigo.Text;
        }
        //Creamos el metodo CreateProduct
        private void CreateProduct()
        {
            //Usamos try para que intente todos los pasos entre los brackets 
            try
            {
                Product product = new()
                {
                    Code = txtCodigo.Text,
                    Price = float.Parse(txtPrecio.Text),
                    Quantity = int.Parse(txtCantidad.Text),
                    Description = txtDescripcion.Text
                };
                //Llamamos CreateProduct de DTO con parametro establecido product guardando esto en
                // guardando esto en CreateProductResponse
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
            //Atrapamos la excepcion y la mostramos con un mensaje de error en la clase predeterminada
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }
        //Creamos el metodo ClearFields para limpiar las celdas
        private void ClearFields()
        {
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = txtConsecutivo.Text;
            //Usamos .enable para dejar o no editar dependiendo del valor de verdad que le pasemos
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCrear.Enabled = true;
        }
        //Creamos otro metodo para registrar la venta
        private void RegisterSale()
        {
            //Llamamos ShowMessage desde MessageHelper para dar visibilidad del error
            //En caso que el usuario indique una cantidad
            if (txtCantidadaVender.Text == "") { 
                MessageHelper.ShowMessage("La cantidad a vender no puede ser 0");
                return;
            }
            //Si el  usuario no selecciona una opcion del combobox, mostramos el ErrorMessage
            if (comboProducts.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("Para vender debes Selecionar un producto");
                return;
            }
            //Instanciamos clase Sale (modelo)
            Sale sale = new()
            {
                ProductCode = comboProducts.SelectedValue.ToString(),
                Quantity = int.Parse(txtCantidadaVender.Text),
                SaleDate = DateTime.Now.ToShortDateString(),
                Description = comboProducts.Text
            };
            //Guardamos en saleResponse el metodo SaleProduct que llamamos desde DTO
            Sale saleResponse = _saleDTO.SaleProduct(sale);
            //Validamos que se venda el producto
            if (saleResponse.IsCorrect)
            {
                LoadGrid();
                MessageHelper.ShowMessage($"Venta registrada Correctamente total a pagar {sale.TotalSale}");
            }
            else
                MessageHelper.ShowErrorMessage("La venta no puede completarse la cantidad de productos no es Suficiente");
        } 
   
        #endregion

        #region Events
        //Evento Load que carga los productos
        private void Products_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtCodigo.Enabled = false;
            Dock = DockStyle.Fill;
            btnActualizar.Enabled = false;
        }
        //Evento click que acciona vender
        private void BtnVender_Click(object sender, EventArgs e)
        {
            //Llamamos RegisterSale para registrar la venta 
            RegisterSale();
        }
        //Evento click que crea un producto
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            //LLamamos el evento CreateProduct el cual despues de dar click el usuario, se crea el producto
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
        //Evento click de informedeVentas
        private void BtnInformedeVentas_Click(object sender, EventArgs e)
        {
            // Instanciamos salesReport
            SalesReport salesReport = new();
            //Llamamos OpenModule con parametro salesReport
            OpenModule(salesReport);
        }
        //Creamos metodo OpenModule que pone un control de tipo usercontrol(en la vista)
        private void OpenModule(UserControl control)
        {
            //instanciamos module con parametro salesReport
            Module module = new(control);
            module.ShowDialog();
        }
        //Evento click de venta cuando clickeamos en el DataGrid
        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            string productCode = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
            //Llamamos FillproductInfo para llenar la informacion del producto
            FillProductInfo(productCode);
        }
        //Creamos metodo FillProductInfo que nos llena la informacion de cada producto en los campos de texto
        private void FillProductInfo(string productCode)
        {
            _product = _objDTO.GetProductByCode(productCode);
            txtCodigo.Text = _product.Code;
            txtDescripcion.Text = _product.Description;
            txtPrecio.Text = Convert.ToString(_product.Price);
            txtCantidad.Text = Convert.ToString(_product.Quantity);
            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;
            btnEliminar.Enabled = true;
        }
        //Evento click buscar 
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtConsecutivo.Text;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            btnCrear.Enabled = true;
            btnActualizar.Enabled = false;
        }
        //Evento Clicl Actualizar 
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string productCode = txtCodigo.Text;
            UpdateSelectedProduct(productCode);
        }
        //Creamos metodo UpdateSelectedProduct que nos actualiza la informacion
        // Cada vez que el usuario seleccione el producto, cambie alguna informacion, y accione Actualizar
        private void UpdateSelectedProduct(string productCode)
        {
            _product = _productList.Find(p => p.Code == productCode);
            _product.Description = txtDescripcion.Text;
            _product.Price = float.Parse(txtPrecio.Text);
            _product.Quantity = int.Parse(txtCantidad.Text);
            _product = _objDTO.UpdateSelectedProduct(_product);
            MessageHelper.ShowMessage($"Producto {_product.Description} actualizado Correctamente");
            LoadGrid();
            ClearFields();
        }
        //Evento cick Eliminar
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string productCode = txtCodigo.Text;
            DeleteProduct(productCode);
        }
        //Creamos metodo DeleteProduct 
        private void DeleteProduct(string productCode)
        {
            //Creamos una variable de tipo bool y llamamos DeleteProduct del DTO con parametro productCode
            bool ifisDeleted = _objDTO.DeleteProduct(productCode);
            if (ifisDeleted) { 
                MessageHelper.ShowMessage("El producto se eliminó satisfactoriamente");
                //Limpio la Lista de productos en el Combo de Products
                comboProducts.Text = "";
                LoadGrid();
                ClearFields();
            }
            else
                MessageHelper.ShowMessage("Por alguna razón el producto no pudo ser eliminado");

        }

        private void btnCierredeCaja_Click(object sender, EventArgs e)
        {
            CloseSalesBox closedSaleBox = new();
            OpenModule(closedSaleBox);
        }
    }
}
