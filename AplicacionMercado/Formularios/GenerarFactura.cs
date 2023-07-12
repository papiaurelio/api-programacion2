using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMercado.Formularios
{
    public partial class GenerarFactura : Form
    {
        public static int idSeleccionada = 0;
        public static int idProductoSeleccionado = 0;

        private ViewModels.ClienteViewModel clienteSeleccionado = null;
        private ViewModels.ProductosViewModel productoSeleccionado = null;
        private ViewModels.DescipcionFactura descripcionProducto = null;

        List<ViewModels.DescipcionFactura> listaProductosFacturados = new List<ViewModels.DescipcionFactura>();
        List<ViewModels.ProductosViewModel> lst = new List<ViewModels.ProductosViewModel>();
        public GenerarFactura()
        {
            InitializeComponent();
        }

        private async Task<ViewModels.ClienteViewModel> ObtenerDatos(int id)
        {
            using (var client = new HttpClient())
            {
                string URI =
                    "https://localhost:44389/api/clientes?id=" + id.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var ContactoJsonString = await response.Content
                        .ReadAsStringAsync();
                    ViewModels.ClienteViewModel oCliente = JsonConvert
                        .DeserializeObject<ViewModels
                        .ClienteViewModel>(ContactoJsonString);
                    clienteSeleccionado = new ViewModels.ClienteViewModel();
                    clienteSeleccionado.Id = oCliente.Id;
                    clienteSeleccionado.Nombre = oCliente.Nombre;
                    clienteSeleccionado.Apellido = oCliente.Apellido;
                    clienteSeleccionado.Telefono = oCliente.Telefono;

                    return clienteSeleccionado;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener al cliente: " + response.StatusCode);
                    return clienteSeleccionado;
                }
            }
        }

        private async void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente_Factura n = new BuscarCliente_Factura();
            n.ShowDialog();
            await ObtenerDatos(idSeleccionada);
            if (idSeleccionada > 0)
            {
                txt_idCliente.Text = clienteSeleccionado.Id.ToString();
                txt_nombreCliente.Text = clienteSeleccionado.Nombre;
            }


        }
        private void GenerarFactura_Load(object sender, EventArgs e)
        {
            GetIdFactura();
        }
        private int nFactura = 0;

        private async void GetIdFactura()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await
                        client.GetAsync("https://localhost:44389/api/facturas"))

                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ContactosJsonString =
                                await response.Content.ReadAsStringAsync();
                            var list = JsonConvert
                                .DeserializeObject<List<ViewModels
                                .FacturasViewModel>>(ContactosJsonString).ToList();


                            ViewModels.FacturasViewModel obj = list.Last();
                            nFactura = obj.Id + 1;

                        }
                        else
                        {
                            MessageBox.Show("Error: "
                                + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la conexión");
                nFactura = 1;
            }
            
        }

        private async void btn_agregarProductos_Click(object sender, EventArgs e)
        {
            AgregarProductos_Factura n = new AgregarProductos_Factura();
            n.ShowDialog();
            await ObtenerProducto(idProductoSeleccionado);
            if (idProductoSeleccionado > 0)
            {
                descripcionProducto = new ViewModels.DescipcionFactura();
                descripcionProducto.IdProducto = productoSeleccionado.Id;
                descripcionProducto.NombreProducto = productoSeleccionado.Nombre;
                descripcionProducto.Precio = productoSeleccionado.Precio;
                descripcionProducto.CantidadVendida = 0;

                idProductoSeleccionado = 0;
                txt_idProducto.Text = productoSeleccionado.Id.ToString();
                txt_nombrProducto.Text = productoSeleccionado.Nombre;
                txt_precioProducto.Text = productoSeleccionado.Precio.ToString();
            }

            idSeleccionada = 0;

        }

        private async Task<ViewModels.ProductosViewModel> ObtenerProducto(int id)
        {
            using (var client = new HttpClient())
            {
                string URI =
                    "https://localhost:44389/api/productos?id=" + id.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var ContactoJsonString = await response.Content
                        .ReadAsStringAsync();
                    ViewModels.ProductosViewModel oProducto = JsonConvert
                        .DeserializeObject<ViewModels
                        .ProductosViewModel>(ContactoJsonString);
                    productoSeleccionado = new ViewModels.ProductosViewModel();
                    productoSeleccionado.Id = oProducto.Id;
                    productoSeleccionado.Nombre = oProducto.Nombre;
                    productoSeleccionado.Cantidad = oProducto.Cantidad;
                    productoSeleccionado.Precio = oProducto.Precio;

                    //Agregando informacion del producto facturado.


                    return productoSeleccionado;
                }
                else
                {
                    MessageBox.Show("Error al obtener el producto: " + response.StatusCode);
                    return productoSeleccionado;
                }
            }
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            QuitarError();
            if (ValidarTextBox())
            {

                ComprabarExistenciaProductos();
                ActualizarProductosFactura();
                txt_idProducto.Text = "";
                txt_nombrProducto.Text = "";
                txt_cantidad.Text = "";
                txt_precioProducto.Text = "";
                txt_cantidad.Text = "";

                CalculoEnTiempoReal();
            }



            else
            {
                MessageBox.Show("Selecciona un producto.");
            }


        }

        private void ComprabarExistenciaProductos()
        {
            if (int.Parse(txt_cantidad.Text) <= productoSeleccionado.Cantidad && int.Parse(txt_cantidad.Text) > 0)
            {
                descripcionProducto.IdProducto = productoSeleccionado.Id;
                descripcionProducto.NombreProducto = productoSeleccionado.Nombre;
                descripcionProducto.Precio = productoSeleccionado.Precio;
                descripcionProducto.CantidadVendida = int.Parse(txt_cantidad.Text);

                productoSeleccionado.Cantidad -= descripcionProducto.CantidadVendida;
                listaProductosFacturados.Add(descripcionProducto);
                lst.Add(productoSeleccionado);
            }

            else
            {
                MessageBox.Show("No hay cantidad suficiente");
            }
        }

        private void ActualizarProductosFactura()
        {
            dgv_productosFacturados.DataSource = null;
            if (listaProductosFacturados.Count > 0)
            {
                dgv_productosFacturados.DataSource = listaProductosFacturados;
            }

        }

        private bool ValidarTextBox()
        {
            bool comprobar = true;
            int numero = 0;

            if (string.IsNullOrWhiteSpace(txt_nombrProducto.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_nombrProducto, "Agrega un producto.");
            }

            if (string.IsNullOrWhiteSpace(txt_cantidad.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_cantidad, "Complete el campo.");
            }


            if (!int.TryParse(txt_cantidad.Text, out numero))
            {
                comprobar = false;
                errorProvider1.SetError(txt_cantidad, "Ingresa un número válido.");

            }

            return comprobar;
        }

        private void QuitarError()
        {
            errorProvider1.SetError(txt_nombrProducto, "");
            errorProvider1.SetError(txt_cantidad, "");
        }



        private void RegistroFacturaDB()
        {
            for (int i = 0; i < lst.Count; i++)
            {
                UpdateProducto(lst[i].Id, lst[i]);
            }
        }

        private async void UpdateProducto(int id, ViewModels.ProductosViewModel prod)
        {

            ViewModels.ProductosViewModel oProducto =
            new ViewModels.ProductosViewModel();
            oProducto.Id = prod.Id;
            oProducto.Nombre = prod.Nombre;
            oProducto.Precio = prod.Precio;
            oProducto.Cantidad = prod.Cantidad;

            using (var client = new HttpClient())
            {
                var serializedContacto = JsonConvert.
                    SerializeObject(oProducto);
                var content = new StringContent(serializedContacto,
                    Encoding.UTF8,
                    "application/json");
                HttpResponseMessage responseMessage = await
                    client.PutAsync("https://localhost:44389/api/productos?id="
                    + oProducto.Id, content);
                //if (responseMessage.IsSuccessStatusCode)
                //    MessageBox.Show("Producto actualizado");
                //else
                //    MessageBox.Show("Error al actualizar el producto: "
                //        + responseMessage.StatusCode);

            }
        }

        private void btn_generarFactura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_nombreCliente.Text) && listaProductosFacturados.Count > 0)
            {              
                GenerarPDF();
                RegistroFacturaDB();
                AddFactura();
                MessageBox.Show("Factura generada.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Completa la información.");
            }


        }

        private void CalculoEnTiempoReal()
        {

            decimal Total = 0;
            decimal TotalIva = 0;
            decimal IVA = 0.15M;

            for (int i = 0; i < listaProductosFacturados.Count; i++)
            {
                decimal PrecioXUnidad = 0;
                PrecioXUnidad = listaProductosFacturados[i].CantidadVendida * listaProductosFacturados[i].Precio;
                Total += PrecioXUnidad;
            }
            lb_total.Text = Total.ToString();
            TotalIva = (Total * IVA) + Total;
            lbl_IVAIncluido.Text = TotalIva.ToString();
        }

        private async void AddFactura()
        {

            ViewModels.FacturasViewModel oFactura = new ViewModels.FacturasViewModel();
            oFactura.IdCliente = clienteSeleccionado.Id;
            oFactura.NombreCliente = clienteSeleccionado.Nombre;
            oFactura.Subtotal = decimal.Parse(lb_total.Text);
            oFactura.IVA = (decimal.Parse(lbl_IVAIncluido.Text) - decimal.Parse(lb_total.Text));
            oFactura.Total = decimal.Parse(lbl_IVAIncluido.Text);
            oFactura.FechaFactura = DateTime.Now;
            using (var client = new HttpClient())
            {
                var serializedContacto = JsonConvert.
                    SerializeObject(oFactura);
                var content = new StringContent(serializedContacto,
                    Encoding.UTF8,
                    "application/json");
                var result = await client.PostAsync("https://localhost:44389/api/facturas", content);

                if (result.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error al agregar la factura: "
                     + result.StatusCode);
                }
            }
        }


        private void GenerarPDF()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = clienteSeleccionado.Nombre + DateTime.Now.ToString("ddMMyyyHHmmss") + ".pdf";
            string plantillaFactura = Properties.Resources.PlantillaFactura.ToString();


            plantillaFactura = plantillaFactura.Replace("@CLIENTE", clienteSeleccionado.Nombre + " " + clienteSeleccionado.Apellido);
            plantillaFactura = plantillaFactura.Replace("@IDCLIENTE", clienteSeleccionado.Id.ToString());
            plantillaFactura = plantillaFactura.Replace("@FECHA", DateTime.Now.ToString());
            plantillaFactura = plantillaFactura.Replace("@SUBTOTAL", lb_total.Text.ToString());
            decimal IVA = decimal.Parse(lbl_IVAIncluido.Text) - decimal.Parse(lb_total.Text);
            IVA = decimal.Round(IVA, 2);
            plantillaFactura = plantillaFactura.Replace("@IVA",  IVA.ToString());
            plantillaFactura = plantillaFactura.Replace("@TOTAL", lbl_IVAIncluido.Text.ToString());
            plantillaFactura = plantillaFactura.Replace("@FACTURA", nFactura.ToString());

            string filas = String.Empty;

            foreach (var x in listaProductosFacturados)
            {
                filas += "<tr>";
                filas += "<td>" + x.NombreProducto.ToString() + "</td>";
                filas += "<td>" + x.CantidadVendida.ToString() + "</td>";
                filas += "<td>" + x.Precio.ToString() + "</td>";
                filas += "</tr>";

            }

            plantillaFactura = plantillaFactura.Replace("@FILAS", filas);

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    iTextSharp.text.Image img =
                        iTextSharp.text.Image.GetInstance(Properties.Resources.real_dorado, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 80);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.Right - 60, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(plantillaFactura))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();

                }

            }


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //btn_eliminarProducto...
        private void button1_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            ActualizarProductosFactura();
            CalculoEnTiempoReal();
        }

        private void EliminarProducto()
        {
            if (idProduc >= 0 && listaProductosFacturados.Count > 0)
            {
                if (MessageBox.Show("¿Quieres eliminar el producto?", "Confimación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listaProductosFacturados.RemoveAt(idProduc);
                    lst.RemoveAt(idProduc);
                }
            }
            else
            {
                MessageBox.Show("Producto no seleccionado.");
            }

        }

        private int idProduc = 0;
        private void dgv_productosFacturados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_productosFacturados.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idProduc = int.Parse(row.Index.ToString());
                }
            }
        }
    }
}
