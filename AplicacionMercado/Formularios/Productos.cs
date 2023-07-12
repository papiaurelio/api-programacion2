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
    public partial class Productos : Form
    {
        private static int idSeleccionada = 0;
        public Productos()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            GetAllProductos();
        }

        private async void GetAllProductos()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await
                        client.GetAsync("https://localhost:44389/api/productos"))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ContactosJsonString =
                                await response.Content.ReadAsStringAsync();
                            dgv_prductos.DataSource = JsonConvert
                                .DeserializeObject<List<ViewModels
                                .ProductosViewModel>>(ContactosJsonString).ToList();

                        }
                        else
                        {
                            MessageBox.Show("No se pueden encontrar los productos. "
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

        private void dgv_prductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_prductos.Rows)
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
            ProductosSubMenu n = new ProductosSubMenu(0, idSeleccionada);
            n.ShowDialog();
            Thread.Sleep(1000);
            idSeleccionada = 0;
            GetAllProductos();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada > 0)
            {
                ProductosSubMenu n = new ProductosSubMenu(1, idSeleccionada);
                n.ShowDialog();
                Thread.Sleep(1000);
                GetAllProductos();
            }

            else
            {
                MessageBox.Show("Selecciona un Producto");
            }

            idSeleccionada = 0;
        }

        private async void DeleteProducto(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress =
                    new Uri("https://localhost:44389/api/productos");
                HttpResponseMessage responseMessage =
                    await client.DeleteAsync(String.Format("{0}/{1}",
                    "https://localhost:44389/api/productos", id));
                if (responseMessage.IsSuccessStatusCode)
                    MessageBox.Show("Producto eliminado con éxito");
                else
                    MessageBox.Show("No se pudo eliminar el Producto"
                        + responseMessage.StatusCode);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionada > 0)
            {
                if (MessageBox.Show($"¿Deseas eliminar el producto {idSeleccionada}?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteProducto(idSeleccionada);
                    Thread.Sleep(1000);
                    GetAllProductos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un Producto");
            }

            idSeleccionada = 0;
        }
    }
}
