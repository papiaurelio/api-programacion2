using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMercado.Formularios
{
    public partial class Clientes : Form
    {
        private static int idSeleccionada = 0;
        public Clientes()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            GetAllClientes();
        }

        private async void GetAllClientes()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await
                        client.GetAsync("https://localhost:44389/api/clientes"))

                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ContactosJsonString =
                                await response.Content.ReadAsStringAsync();
                            dgv_clientes.DataSource = JsonConvert
                                .DeserializeObject<List<ViewModels
                                .ClienteViewModel>>(ContactosJsonString).ToList();

                        }
                        else
                        {
                            MessageBox.Show("No se pueden encontrar los clientes: "
                                + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la conexión");
            }
            
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_clientes.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idSeleccionada = int.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            idSeleccionada = 0;
            ClientesSubMenu n = new ClientesSubMenu(0, idSeleccionada);
            n.ShowDialog();
            Thread.Sleep(1000);
            idSeleccionada = 0;
            GetAllClientes();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada> 0)
            {
                ClientesSubMenu n = new ClientesSubMenu(1, idSeleccionada);
                n.ShowDialog();
                Thread.Sleep(1000);
                GetAllClientes();
            }

            else
            {
                MessageBox.Show("Selecciona un cliente");
            }

            idSeleccionada = 0;
        }

        private async void DeteleteCliente(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress =
                    new Uri("https://localhost:44389/api/clientes");
                HttpResponseMessage responseMessage =
                    await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:44389/api/clientes", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Cliente eliminado con éxito");
                else
                    MessageBox.Show("No se pudo eliminar el cliente"
                        + responseMessage.StatusCode);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada > 0)
            {
                if (MessageBox.Show($"¿Deseas eliminar el cliente {idSeleccionada}?","Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeteleteCliente(idSeleccionada);
                    Thread.Sleep(1000);
                    GetAllClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente");
            }

            idSeleccionada = 0;
        }
       
    }
}
