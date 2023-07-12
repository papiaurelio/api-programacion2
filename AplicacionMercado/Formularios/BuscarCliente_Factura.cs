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
    public partial class BuscarCliente_Factura : Form
    {
        private int idSeleccionada1 = 0;

        public BuscarCliente_Factura()
        {
            InitializeComponent();
        }

        private async void GetAllCliente()
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
                        dgv_clientesFac.DataSource = JsonConvert
                            .DeserializeObject<List<ViewModels
                            .ClienteViewModel>>(ContactosJsonString).ToList();

                    }
                    else
                    {
                        MessageBox.Show("No se pueden encontrar a los clientes: "
                            + response.StatusCode);
                    }
                }
            }
        }

        private void BuscarCliente_Factura_Load(object sender, EventArgs e)
        {
            GetAllCliente();
        }

        private void dgv_clientesFac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_clientesFac.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idSeleccionada1 = int.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btn_seleccionCliente_Click(object sender, EventArgs e)
        {
            if (idSeleccionada1 > 0)
            {
                GenerarFactura.idSeleccionada = idSeleccionada1;
                this.Close();
            }

            else
            {
                MessageBox.Show("Selecciona un cliente");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
