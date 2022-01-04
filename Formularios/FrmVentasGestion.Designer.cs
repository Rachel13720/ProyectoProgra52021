namespace ProyectoProgra52021.Formularios
{
    partial class FrmVentasGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasGestion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboxClientes = new System.Windows.Forms.ComboBox();
            this.LblUsuarioRegistra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAgregarItem = new System.Windows.Forms.ToolStripButton();
            this.BtnModicarfItem = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminarItem = new System.Windows.Forms.ToolStripButton();
            this.dgvListaItems = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalVenta = new System.Windows.Forms.TextBox();
            this.BtnCrearVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtComentario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboxClientes);
            this.groupBox1.Controls.Add(this.LblUsuarioRegistra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNumeroFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comentario (opcional)";
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(346, 109);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(290, 105);
            this.TxtComentario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // CboxClientes
            // 
            this.CboxClientes.FormattingEnabled = true;
            this.CboxClientes.Location = new System.Drawing.Point(346, 53);
            this.CboxClientes.Name = "CboxClientes";
            this.CboxClientes.Size = new System.Drawing.Size(290, 21);
            this.CboxClientes.TabIndex = 5;
            // 
            // LblUsuarioRegistra
            // 
            this.LblUsuarioRegistra.AutoSize = true;
            this.LblUsuarioRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioRegistra.Location = new System.Drawing.Point(36, 201);
            this.LblUsuarioRegistra.Name = "LblUsuarioRegistra";
            this.LblUsuarioRegistra.Size = new System.Drawing.Size(47, 15);
            this.LblUsuarioRegistra.TabIndex = 4;
            this.LblUsuarioRegistra.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de la factura de la venta";
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(39, 135);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(200, 20);
            this.TxtNumeroFactura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de registro de la venta";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(39, 50);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.dgvListaItems);
            this.groupBox2.Location = new System.Drawing.Point(28, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregarItem,
            this.BtnModicarfItem,
            this.BtnEliminarItem});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAgregarItem
            // 
            this.BtnAgregarItem.BackColor = System.Drawing.Color.Green;
            this.BtnAgregarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAgregarItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarItem.Image")));
            this.BtnAgregarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregarItem.Name = "BtnAgregarItem";
            this.BtnAgregarItem.Size = new System.Drawing.Size(121, 22);
            this.BtnAgregarItem.Text = "Agregar Producto";
            this.BtnAgregarItem.Click += new System.EventHandler(this.BtnAgregarItem_Click_1);
            // 
            // BtnModicarfItem
            // 
            this.BtnModicarfItem.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnModicarfItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModicarfItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnModicarfItem.Image")));
            this.BtnModicarfItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModicarfItem.Name = "BtnModicarfItem";
            this.BtnModicarfItem.Size = new System.Drawing.Size(130, 22);
            this.BtnModicarfItem.Text = "Modificar Producto";
            this.BtnModicarfItem.Click += new System.EventHandler(this.BtnModicarfItem_Click);
            // 
            // BtnEliminarItem
            // 
            this.BtnEliminarItem.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarItem.Image")));
            this.BtnEliminarItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminarItem.Name = "BtnEliminarItem";
            this.BtnEliminarItem.Size = new System.Drawing.Size(122, 22);
            this.BtnEliminarItem.Text = "Eliminar Producto";
            this.BtnEliminarItem.Click += new System.EventHandler(this.BtnEliminarItem_Click);
            // 
            // dgvListaItems
            // 
            this.dgvListaItems.AllowUserToAddRows = false;
            this.dgvListaItems.AllowUserToDeleteRows = false;
            this.dgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CNombre,
            this.CCantidadVendida,
            this.CPrecioVenta});
            this.dgvListaItems.Location = new System.Drawing.Point(0, 44);
            this.dgvListaItems.Name = "dgvListaItems";
            this.dgvListaItems.ReadOnly = true;
            this.dgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaItems.Size = new System.Drawing.Size(668, 274);
            this.dgvListaItems.TabIndex = 0;
            // 
            // CIDProducto
            // 
            this.CIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Cod.Producto";
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            this.CIDProducto.Width = 85;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Producto";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CCantidadVendida
            // 
            this.CCantidadVendida.DataPropertyName = "CantidadVendida";
            this.CCantidadVendida.HeaderText = "Cantidad";
            this.CCantidadVendida.Name = "CCantidadVendida";
            this.CCantidadVendida.ReadOnly = true;
            // 
            // CPrecioVenta
            // 
            this.CPrecioVenta.DataPropertyName = "PrecioVenta";
            this.CPrecioVenta.HeaderText = "Precio";
            this.CPrecioVenta.Name = "CPrecioVenta";
            this.CPrecioVenta.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total de la venta:";
            // 
            // TxtTotalVenta
            // 
            this.TxtTotalVenta.Location = new System.Drawing.Point(203, 659);
            this.TxtTotalVenta.Name = "TxtTotalVenta";
            this.TxtTotalVenta.Size = new System.Drawing.Size(291, 20);
            this.TxtTotalVenta.TabIndex = 3;
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCrearVenta.Location = new System.Drawing.Point(539, 649);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Size = new System.Drawing.Size(157, 39);
            this.BtnCrearVenta.TabIndex = 4;
            this.BtnCrearVenta.Text = "Crear Venta";
            this.BtnCrearVenta.UseVisualStyleBackColor = false;
            this.BtnCrearVenta.Click += new System.EventHandler(this.BtnCrearVenta_Click);
            // 
            // FrmVentasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(735, 702);
            this.Controls.Add(this.BtnCrearVenta);
            this.Controls.Add(this.TxtTotalVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVentasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Ventas";
            this.Load += new System.EventHandler(this.FrmVentasGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUsuarioRegistra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboxClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAgregarItem;
        private System.Windows.Forms.ToolStripButton BtnModicarfItem;
        private System.Windows.Forms.ToolStripButton BtnEliminarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalVenta;
        private System.Windows.Forms.Button BtnCrearVenta;
        public System.Windows.Forms.DataGridView dgvListaItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioVenta;
    }
}