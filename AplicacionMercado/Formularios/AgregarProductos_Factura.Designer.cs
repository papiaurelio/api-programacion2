
namespace AplicacionMercado.Formularios
{
    partial class AgregarProductos_Factura
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
            this.dgv_cproductosFac = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cproductosFac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cproductosFac
            // 
            this.dgv_cproductosFac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cproductosFac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cproductosFac.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_cproductosFac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.dgv_cproductosFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cproductosFac.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_cproductosFac.Location = new System.Drawing.Point(48, 12);
            this.dgv_cproductosFac.Name = "dgv_cproductosFac";
            this.dgv_cproductosFac.ReadOnly = true;
            this.dgv_cproductosFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cproductosFac.Size = new System.Drawing.Size(550, 235);
            this.dgv_cproductosFac.TabIndex = 14;
            this.dgv_cproductosFac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cproductosFac_CellClick);
            this.dgv_cproductosFac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cproductosFac_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancelar.Location = new System.Drawing.Point(552, 300);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 31);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(1)))), ((int)(((byte)(5)))));
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_agregarProducto.Location = new System.Drawing.Point(244, 263);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(146, 32);
            this.btn_agregarProducto.TabIndex = 17;
            this.btn_agregarProducto.Text = "Agregar prodcuto";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // AgregarProductos_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(660, 335);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_cproductosFac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarProductos_Factura";
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.AgregarProductos_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cproductosFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cproductosFac;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregarProducto;
    }
}