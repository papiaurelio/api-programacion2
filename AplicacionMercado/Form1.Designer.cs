
namespace AplicacionMercado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mostrarFacturas = new System.Windows.Forms.Button();
            this.tbn_factura = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.tbn_clientes = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.panel1.Controls.Add(this.btn_mostrarFacturas);
            this.panel1.Controls.Add(this.tbn_factura);
            this.panel1.Controls.Add(this.btn_productos);
            this.panel1.Controls.Add(this.tbn_clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 471);
            this.panel1.TabIndex = 0;
            // 
            // btn_mostrarFacturas
            // 
            this.btn_mostrarFacturas.FlatAppearance.BorderSize = 0;
            this.btn_mostrarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarFacturas.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarFacturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mostrarFacturas.Location = new System.Drawing.Point(0, 353);
            this.btn_mostrarFacturas.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.btn_mostrarFacturas.Name = "btn_mostrarFacturas";
            this.btn_mostrarFacturas.Size = new System.Drawing.Size(200, 68);
            this.btn_mostrarFacturas.TabIndex = 3;
            this.btn_mostrarFacturas.Text = "Facturas";
            this.btn_mostrarFacturas.UseVisualStyleBackColor = true;
            this.btn_mostrarFacturas.Click += new System.EventHandler(this.btn_mostrarFacturas_Click);
            // 
            // tbn_factura
            // 
            this.tbn_factura.FlatAppearance.BorderSize = 0;
            this.tbn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_factura.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_factura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbn_factura.Location = new System.Drawing.Point(0, 245);
            this.tbn_factura.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.tbn_factura.Name = "tbn_factura";
            this.tbn_factura.Size = new System.Drawing.Size(200, 68);
            this.tbn_factura.TabIndex = 2;
            this.tbn_factura.Text = "Generar factura";
            this.tbn_factura.UseVisualStyleBackColor = true;
            this.tbn_factura.Click += new System.EventHandler(this.tbn_factura_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_productos.Location = new System.Drawing.Point(0, 137);
            this.btn_productos.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(200, 68);
            this.btn_productos.TabIndex = 1;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // tbn_clientes
            // 
            this.tbn_clientes.FlatAppearance.BorderSize = 0;
            this.tbn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbn_clientes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbn_clientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbn_clientes.Location = new System.Drawing.Point(0, 29);
            this.tbn_clientes.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.tbn_clientes.Name = "tbn_clientes";
            this.tbn_clientes.Size = new System.Drawing.Size(200, 68);
            this.tbn_clientes.TabIndex = 0;
            this.tbn_clientes.Text = "Clientes";
            this.tbn_clientes.UseVisualStyleBackColor = true;
            this.tbn_clientes.Click += new System.EventHandler(this.tbn_clientes_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(2)))), ((int)(((byte)(9)))));
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(734, 471);
            this.panelForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AplicacionMercado.Properties.Resources.real_dorado;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 471);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 510);
            this.Name = "Form1";
            this.Text = "Administrador tienda";
            this.panel1.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button tbn_clientes;
        private System.Windows.Forms.Button btn_mostrarFacturas;
        private System.Windows.Forms.Button tbn_factura;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

