
namespace AplicacionMercado.Formularios
{
    partial class BuscarCliente_Factura
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
            this.dgv_clientesFac = new System.Windows.Forms.DataGridView();
            this.btn_seleccionCliente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientesFac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientesFac
            // 
            this.dgv_clientesFac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_clientesFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientesFac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_clientesFac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.dgv_clientesFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientesFac.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_clientesFac.Location = new System.Drawing.Point(68, 22);
            this.dgv_clientesFac.Name = "dgv_clientesFac";
            this.dgv_clientesFac.ReadOnly = true;
            this.dgv_clientesFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientesFac.Size = new System.Drawing.Size(509, 222);
            this.dgv_clientesFac.TabIndex = 13;
            this.dgv_clientesFac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientesFac_CellClick);
            // 
            // btn_seleccionCliente
            // 
            this.btn_seleccionCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.btn_seleccionCliente.FlatAppearance.BorderSize = 0;
            this.btn_seleccionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seleccionCliente.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_seleccionCliente.Location = new System.Drawing.Point(278, 260);
            this.btn_seleccionCliente.Name = "btn_seleccionCliente";
            this.btn_seleccionCliente.Size = new System.Drawing.Size(146, 33);
            this.btn_seleccionCliente.TabIndex = 14;
            this.btn_seleccionCliente.Text = "Seleccionar cliente";
            this.btn_seleccionCliente.UseVisualStyleBackColor = false;
            this.btn_seleccionCliente.Click += new System.EventHandler(this.btn_seleccionCliente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelar.Location = new System.Drawing.Point(546, 290);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(88, 33);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // BuscarCliente_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(660, 335);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_seleccionCliente);
            this.Controls.Add(this.dgv_clientesFac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarCliente_Factura";
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientesFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientesFac;
        private System.Windows.Forms.Button btn_seleccionCliente;
        private System.Windows.Forms.Button btn_cancelar;
    }
}