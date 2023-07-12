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
    public partial class ClientesSubMenu : Form
    {
        private int id = 0;
        public ClientesSubMenu(int t, int idSeleccionada)
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

        private void ClientesSubMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            QuitarError();
            if (ValidarDatos())
            {
                AddCliente();
                this.Close();
            }

        }

        private async void AddCliente()
        {
            ViewModels.ClienteViewModel oCliente = new ViewModels.ClienteViewModel();
            oCliente.Nombre = txt_nombre.Text;
            oCliente.Apellido = txt_apellido.Text;
            oCliente.Telefono = int.Parse(txt_telefono.Text);
            using (var client = new HttpClient())
            {
                var serializedContacto = JsonConvert.
                    SerializeObject(oCliente);
                var content = new StringContent(serializedContacto,
                    Encoding.UTF8,
                    "application/json");
                var result = await client.PostAsync("https://localhost:44389/api/clientes", content);

                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente agregado.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto: "
    + result.StatusCode);
                }

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            QuitarError();
            if (ValidarDatos())
            {
                UpdateCliente(id);
                this.Close();
            }

        }

        private async void UpdateCliente(int id)
        {

            ViewModels.ClienteViewModel oCliente =
            new ViewModels.ClienteViewModel();
            oCliente.Id = id;
            oCliente.Nombre = txt_nombre.Text;
            oCliente.Apellido = txt_apellido.Text;
            oCliente.Telefono = int.Parse(txt_telefono.Text);

            using (var client = new HttpClient())
            {
                var serializedContacto = JsonConvert.
                    SerializeObject(oCliente);
                var content = new StringContent(serializedContacto,
                    Encoding.UTF8,
                    "application/json");
                HttpResponseMessage responseMessage = await
                    client.PutAsync("https://localhost:44389/api/clientes?id="
                    + oCliente.Id, content);
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Cliente actualizado");
                else
                    MessageBox.Show("Error al actualizar el cliente: "
                        + responseMessage.StatusCode);

            }
        }


        private async void ObtenerDatos(int id)
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
                    txt_nombre.Text = oCliente.Nombre;
                    txt_apellido.Text = oCliente.Apellido;
                    txt_telefono.Text = oCliente.Telefono.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede obtener el cliente: " + response.StatusCode);
                }
            }
        }


        private bool ValidarDatos()
        {
            //Comprabando algunos datos del formulario
            bool comprobar = true;
            int numero = 0;

            if ( string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_nombre, "Complete el campo.");
            }

            if (string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_apellido, "Complete el campo.");
            }

            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                comprobar = false;
                errorProvider1.SetError(txt_telefono, "Complete el campo.");
            }


            if (!int.TryParse(txt_telefono.Text, out numero))
            {
                comprobar = false;
                errorProvider1.SetError(txt_telefono, "Ingresa un número de teléfono.");

            }



            if (int.TryParse(txt_telefono.Text, out numero))
            {
                if (txt_telefono.Text.Length != 8)
                {
                    comprobar = false;
                    errorProvider1.SetError(txt_telefono, "Teléfono (8 dígitos)");
                }

            }
            return comprobar;
        }


        private void QuitarError()
        {
            //Reseteando los errores en la ventana
            errorProvider1.SetError(txt_nombre, "");
            errorProvider1.SetError(txt_apellido, "");
            errorProvider1.SetError(txt_telefono, "");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
