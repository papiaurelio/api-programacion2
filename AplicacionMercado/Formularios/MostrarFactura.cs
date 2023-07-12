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
    public partial class MostrarFactura : Form
    {
        public MostrarFactura()
        {
            InitializeComponent();
        }

        private void MostrarFactura_Load(object sender, EventArgs e)
        {
            GetAllFacturas();
        }

        private async void GetAllFacturas()
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
                            dgv_muestraFacturas.DataSource = JsonConvert
                                .DeserializeObject<List<ViewModels
                                .FacturasViewModel>>(ContactosJsonString).ToList();

                        }
                        else
                        {
                            MessageBox.Show("No se pueden encontrar las facturas: "
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
