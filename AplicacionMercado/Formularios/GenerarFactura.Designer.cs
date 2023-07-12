
namespace AplicacionMercado.Formularios
{
    partial class GenerarFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_productosFacturados = new System.Windows.Forms.DataGridView();
            this.btn_agregarProductos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombrProducto = new System.Windows.Forms.TextBox();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precioProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lbl_IVAIncluido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_generarFactura = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosFacturados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Generar factura";
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btn_buscarCliente.FlatAppearance.BorderSize = 0;
            this.btn_buscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarCliente.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_buscarCliente.Location = new System.Drawing.Point(317, 85);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(136, 28);
            this.btn_buscarCliente.TabIndex = 13;
            this.btn_buscarCliente.Text = "Buscar cliente";
            this.btn_buscarCliente.UseVisualStyleBackColor = false;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(129, 74);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.ReadOnly = true;
            this.txt_idCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_idCliente.TabIndex = 14;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(129, 112);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreCliente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // dgv_productosFacturados
            // 
            this.dgv_productosFacturados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productosFacturados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productosFacturados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_productosFacturados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.dgv_productosFacturados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productosFacturados.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_productosFacturados.Location = new System.Drawing.Point(26, 154);
            this.dgv_productosFacturados.Name = "dgv_productosFacturados";
            this.dgv_productosFacturados.ReadOnly = true;
            this.dgv_productosFacturados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productosFacturados.Size = new System.Drawing.Size(444, 197);
            this.dgv_productosFacturados.TabIndex = 18;
            this.dgv_productosFacturados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productosFacturados_CellClick);
            // 
            // btn_agregarProductos
            // 
            this.btn_agregarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btn_agregarProductos.FlatAppearance.BorderSize = 0;
            this.btn_agregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProductos.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_agregarProductos.Location = new System.Drawing.Point(510, 134);
            this.btn_agregarProductos.Name = "btn_agregarProductos";
            this.btn_agregarProductos.Size = new System.Drawing.Size(136, 29);
            this.btn_agregarProductos.TabIndex = 19;
            this.btn_agregarProductos.Text = "Buscar producto";
            this.btn_agregarProductos.UseVisualStyleBackColor = false;
            this.btn_agregarProductos.Click += new System.EventHandler(this.btn_agregarProductos_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(478, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre P:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(478, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "ID producto:";
            // 
            // txt_nombrProducto
            // 
            this.txt_nombrProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_nombrProducto.Location = new System.Drawing.Point(585, 221);
            this.txt_nombrProducto.Name = "txt_nombrProducto";
            this.txt_nombrProducto.ReadOnly = true;
            this.txt_nombrProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_nombrProducto.TabIndex = 21;
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_idProducto.Location = new System.Drawing.Point(585, 183);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.ReadOnly = true;
            this.txt_idProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_idProducto.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(478, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Precio:";
            // 
            // txt_precioProducto
            // 
            this.txt_precioProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_precioProducto.Location = new System.Drawing.Point(585, 259);
            this.txt_precioProducto.Name = "txt_precioProducto";
            this.txt_precioProducto.ReadOnly = true;
            this.txt_precioProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_precioProducto.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(478, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_cantidad.Location = new System.Drawing.Point(585, 297);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 26;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(143)))), ((int)(((byte)(12)))));
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregarProducto.Location = new System.Drawing.Point(553, 335);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(150, 34);
            this.btn_agregarProducto.TabIndex = 28;
            this.btn_agregarProducto.Text = "Agregar producto";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(71, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total:";
            // 
            // lb_total
            // 
            this.lb_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_total.Location = new System.Drawing.Point(141, 361);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(41, 29);
            this.lb_total.TabIndex = 30;
            this.lb_total.Text = "xxxx";
            // 
            // lbl_IVAIncluido
            // 
            this.lbl_IVAIncluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_IVAIncluido.AutoSize = true;
            this.lbl_IVAIncluido.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IVAIncluido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_IVAIncluido.Location = new System.Drawing.Point(267, 394);
            this.lbl_IVAIncluido.Name = "lbl_IVAIncluido";
            this.lbl_IVAIncluido.Size = new System.Drawing.Size(41, 29);
            this.lbl_IVAIncluido.TabIndex = 32;
            this.lbl_IVAIncluido.Text = "xxxx";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(71, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total (IVA INCLUIDO):";
            // 
            // btn_generarFactura
            // 
            this.btn_generarFactura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_generarFactura.FlatAppearance.BorderSize = 0;
            this.btn_generarFactura.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarFactura.Location = new System.Drawing.Point(347, 394);
            this.btn_generarFactura.Name = "btn_generarFactura";
            this.btn_generarFactura.Size = new System.Drawing.Size(167, 46);
            this.btn_generarFactura.TabIndex = 33;
            this.btn_generarFactura.Text = "Generar factura";
            this.btn_generarFactura.UseVisualStyleBackColor = true;
            this.btn_generarFactura.Click += new System.EventHandler(this.btn_generarFactura_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(12, 9);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(34, 23);
            this.btn_cerrar.TabIndex = 34;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(1)))), ((int)(((byte)(72)))));
            this.btn_eliminarProducto.FlatAppearance.BorderSize = 0;
            this.btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProducto.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminarProducto.Location = new System.Drawing.Point(553, 381);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(150, 34);
            this.btn_eliminarProducto.TabIndex = 35;
            this.btn_eliminarProducto.Text = "Eliminar producto";
            this.btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(2)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_generarFactura);
            this.Controls.Add(this.lbl_IVAIncluido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precioProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombrProducto);
            this.Controls.Add(this.txt_idProducto);
            this.Controls.Add(this.btn_agregarProductos);
            this.Controls.Add(this.dgv_productosFacturados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_idCliente);
            this.Controls.Add(this.btn_buscarCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarFactura";
            this.Text = "GenerarFactura";
            this.Load += new System.EventHandler(this.GenerarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosFacturados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarCliente;
        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_productosFacturados;
        private System.Windows.Forms.Button btn_agregarProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombrProducto;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precioProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_generarFactura;
        private System.Windows.Forms.Label lbl_IVAIncluido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminarProducto;
    }
}