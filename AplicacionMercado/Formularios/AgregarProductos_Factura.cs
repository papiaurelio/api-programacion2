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
    public partial class AgregarProductos_Factura : Form
    {
        private int idSeleecionProducto = 0;
        public AgregarProductos_Factura()
        {
            InitializeComponent();
        }

        private async void GetAllProductos()
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
                        dgv_cproductosFac.DataSource = JsonConvert
                            .DeserializeObject<List<ViewModels
                            .ProductosViewModel>>(ContactosJsonString).ToList();

                    }
                    else
                    {
                        MessageBox.Show("No se pueden encontrar los prodcutos: "
                            + response.StatusCode);
                    }
                }
            }
        }

        private void dgv_cproductosFac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarProductos_Factura_Load(object sender, EventArgs e)
        {
            GetAllProductos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            if (idSeleecionProducto > 0)
            {
                GenerarFactura.idProductoSeleccionado = idSeleecionProducto;
                this.Close();
            }

            else
            {
                MessageBox.Show("Error al seleccionar el producto");
            }
        }

        private void dgv_cproductosFac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_cproductosFac.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idSeleecionProducto = int.Parse(row.Cells[0].Value.ToString());
                }
            }
        }
    }
}
