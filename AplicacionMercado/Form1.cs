using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form formActivo = null;
        private void AbrirFormSecundario(Form formSecundario)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formSecundario;
            formSecundario.TopLevel = false;
            formSecundario.FormBorderStyle = FormBorderStyle.None;
            formSecundario.Dock = DockStyle.Fill;
            panelForm.Controls.Add(formSecundario);
            panelForm.Tag = formSecundario;
            formSecundario.BringToFront();
            formSecundario.Show();
        }

        private void tbn_clientes_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Formularios.Clientes());
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Formularios.Productos());
        }

        private void btn_mostrarFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Formularios.MostrarFactura());
        }

        private void tbn_factura_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Formularios.GenerarFactura());
        }
    }
}
