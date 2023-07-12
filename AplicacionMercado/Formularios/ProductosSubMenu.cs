using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMercado.Formularios
{
    public partial class ProductosSubMenu : Form
    {
        private int id = 0;
        public ProductosSubMenu(int t, int idSeleccionada)
        {
            InitializeComponent();

            if (t == 0)
            {
                btn_agregar.Visible = true;
                btn_editar.Visible = false;
            }
            if (t == 1)
            {
                btn_agregar.Visible = false;
                btn_editar.Visible = true;
            }

            this.id = idSeleccionada;

            if (id > 0)
            {
                ObtenerDatos(id);
            }
        }

        private async void ObtenerDatos(int id)
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
                    ViewModels.ProductosViewModel oProductos = JsonConvert
                        .DeserializeObject<ViewModels
                        .ProductosViewModel>(ContactoJsonString);
                    txt_nombre.Text = oProductos.Nombre;
                    txt_precio.Text = oProductos.Precio.ToString();
                    txt_cantidad.Text = oProductos.Cantidad.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede obtener el producto: " + response.StatusCode);
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            QuitarError();
            if (ValidarDatos())
            {
                AddProducto();
                this.Close();
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            QuitarError();
            if (ValidarDatos())
            {
                UpdateProducto(id);
                this.Close();
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AddProducto()
        {
            ViewModels.ProductosViewModel oProducto = new ViewModels.ProductosViewModel();
            oProducto.Nombre = txt_nombre.Text;
            oProducto.Precio = decimal.Parse(txt_precio.Text);
            oProducto.Cantidad = int.Parse(txt_cantidad.Text);
            using (var client = new HttpClient())
            {
                var serializedContacto = JsonConvert.
                    SerializeObject(oProducto);
                var content = new StringContent(serializedContacto,
                    Encoding.UTF8,
                    "application/json");
                var result = await client.PostAsync("https://localhost:44389/api/productos", content);

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto: "
                 + result.StatusCode);
                }
            }
        }

        private async void UpdateProducto(int id)
        {

            ViewModels.ProductosViewModel oProducto =
            new ViewModels.ProductosViewModel();
            oProducto.Id = id;
            oProducto.Nombre = txt_nombre.Text;
            oProducto.Precio = decimal.Parse(txt_precio.Text);
            oProducto.Cantidad = int.Parse(txt_cantidad.Text);

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
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Producto actualizado");
                else
                    MessageBox.Show("Error al actualizar el producto: "
                        + responseMessage.StatusCode);

            }
        }

        private bool ValidarDatos()
        {
            //Comprabando algunos datos del formulario
            bool comprobar = true;
            int numero = 0;
            decimal numeroDecimal = 0;

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_nombre, "Complete el campo.");
            }

            if (string.IsNullOrWhiteSpace(txt_precio.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_precio, "Complete el campo.");
            }

            if (string.IsNullOrWhiteSpace(txt_cantidad.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_cantidad, "Complete el campo.");
            }


            if (!decimal.TryParse(txt_precio.Text, out numeroDecimal))
            {
                comprobar = false;
                errorProvider1.SetError(txt_precio, "Ingresa el precio");

            }

            if (!int.TryParse(txt_cantidad.Text, out numero))
            {
                comprobar = false;
                errorProvider1.SetError(txt_cantidad, "Ingresa la cantidad");

            }

            if (decimal.TryParse(txt_precio.Text, out numeroDecimal))
            {
                if (decimal.Parse(txt_precio.Text)<= 0 || decimal.Parse(txt_precio.Text) > 500000)
                {
                    comprobar = false;
                    errorProvider1.SetError(txt_precio, "Ingresa un precio realista");
                }

            }


            if (int.TryParse(txt_cantidad.Text, out numero))
            {
                if (int.Parse(txt_cantidad.Text) <= 0 || decimal.Parse(txt_cantidad.Text) > 10000)
                {
                    comprobar = false;
                    errorProvider1.SetError(txt_cantidad, "Ingresa una cantidad realista.");
                }

            }
            return comprobar;
        }


        private void QuitarError()
        {
            //Reseteando los errores en la ventana
            errorProvider1.SetError(txt_nombre, "");
            errorProvider1.SetError(txt_precio, "");
            errorProvider1.SetError(txt_cantidad, "");
        }
    }
}
