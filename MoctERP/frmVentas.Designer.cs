namespace MoctERP
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDCliente = new System.Windows.Forms.Panel();
            this.txtPDescuento = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbxAgregar = new System.Windows.Forms.PictureBox();
            this.dgvDatosPAgregado = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCanasta = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dgvDatosP = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloG = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlDCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPAgregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosP)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pnlDCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(133, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 431);
            this.panel1.TabIndex = 7;
            // 
            // pnlDCliente
            // 
            this.pnlDCliente.Controls.Add(this.txtPDescuento);
            this.pnlDCliente.Controls.Add(this.lblDesc);
            this.pnlDCliente.Controls.Add(this.pbxAgregar);
            this.pnlDCliente.Controls.Add(this.dgvDatosPAgregado);
            this.pnlDCliente.Controls.Add(this.lblCanasta);
            this.pnlDCliente.Controls.Add(this.txtProducto);
            this.pnlDCliente.Controls.Add(this.lblProductos);
            this.pnlDCliente.Controls.Add(this.dtpFechas);
            this.pnlDCliente.Controls.Add(this.lblRFC);
            this.pnlDCliente.Controls.Add(this.lblSubtotal);
            this.pnlDCliente.Controls.Add(this.dgvDatosP);
            this.pnlDCliente.Controls.Add(this.btnSeleccionar);
            this.pnlDCliente.Controls.Add(this.btnCancelar);
            this.pnlDCliente.Controls.Add(this.btnQuitar);
            this.pnlDCliente.Controls.Add(this.btnGuardar);
            this.pnlDCliente.Controls.Add(this.txtRFC);
            this.pnlDCliente.Controls.Add(this.lblTotal);
            this.pnlDCliente.Controls.Add(this.lblDescuento);
            this.pnlDCliente.Controls.Add(this.lblImpuesto);
            this.pnlDCliente.Controls.Add(this.lblCant);
            this.pnlDCliente.Controls.Add(this.lblFecha);
            this.pnlDCliente.Controls.Add(this.lblCliente);
            this.pnlDCliente.Controls.Add(this.txtCliente);
            this.pnlDCliente.Controls.Add(this.txtTotal);
            this.pnlDCliente.Controls.Add(this.txtDescuento);
            this.pnlDCliente.Controls.Add(this.txtImpuesto);
            this.pnlDCliente.Controls.Add(this.txtCant);
            this.pnlDCliente.Controls.Add(this.txtSubtotal);
            this.pnlDCliente.Location = new System.Drawing.Point(3, 3);
            this.pnlDCliente.Name = "pnlDCliente";
            this.pnlDCliente.Size = new System.Drawing.Size(691, 420);
            this.pnlDCliente.TabIndex = 19;
            this.pnlDCliente.Visible = false;
            // 
            // txtPDescuento
            // 
            this.txtPDescuento.Location = new System.Drawing.Point(572, 12);
            this.txtPDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtPDescuento.Name = "txtPDescuento";
            this.txtPDescuento.Size = new System.Drawing.Size(110, 20);
            this.txtPDescuento.TabIndex = 3;
            this.txtPDescuento.Text = "0";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(493, 14);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(73, 13);
            this.lblDesc.TabIndex = 29;
            this.lblDesc.Text = "% Descuento:";
            // 
            // pbxAgregar
            // 
            this.pbxAgregar.Image = global::MoctERP.Properties.Resources.if_sign_add_299068;
            this.pbxAgregar.Location = new System.Drawing.Point(87, 164);
            this.pbxAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAgregar.Name = "pbxAgregar";
            this.pbxAgregar.Size = new System.Drawing.Size(23, 20);
            this.pbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregar.TabIndex = 28;
            this.pbxAgregar.TabStop = false;
            this.pbxAgregar.Click += new System.EventHandler(this.pbxAgregar_Click);
            // 
            // dgvDatosPAgregado
            // 
            this.dgvDatosPAgregado.AllowUserToAddRows = false;
            this.dgvDatosPAgregado.AllowUserToDeleteRows = false;
            this.dgvDatosPAgregado.AllowUserToResizeRows = false;
            this.dgvDatosPAgregado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPAgregado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosPAgregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPAgregado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Cantidad,
            this.Producto,
            this.Precio,
            this.SubtotalPartida});
            this.dgvDatosPAgregado.Location = new System.Drawing.Point(6, 190);
            this.dgvDatosPAgregado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosPAgregado.Name = "dgvDatosPAgregado";
            this.dgvDatosPAgregado.ReadOnly = true;
            this.dgvDatosPAgregado.RowHeadersVisible = false;
            this.dgvDatosPAgregado.RowTemplate.Height = 28;
            this.dgvDatosPAgregado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosPAgregado.Size = new System.Drawing.Size(676, 90);
            this.dgvDatosPAgregado.TabIndex = 27;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Código";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unit.";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // SubtotalPartida
            // 
            this.SubtotalPartida.HeaderText = "Subtotal por partida";
            this.SubtotalPartida.Name = "SubtotalPartida";
            this.SubtotalPartida.ReadOnly = true;
            // 
            // lblCanasta
            // 
            this.lblCanasta.AutoSize = true;
            this.lblCanasta.Location = new System.Drawing.Point(569, 174);
            this.lblCanasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanasta.Name = "lblCanasta";
            this.lblCanasta.Size = new System.Drawing.Size(112, 13);
            this.lblCanasta.TabIndex = 26;
            this.lblCanasta.Text = "Productos Agregados:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(553, 36);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(129, 20);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyUp);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(493, 38);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 13);
            this.lblProductos.TabIndex = 24;
            this.lblProductos.Text = "Productos:";
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(287, 36);
            this.dtpFechas.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(155, 20);
            this.dtpFechas.TabIndex = 2;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Location = new System.Drawing.Point(17, 38);
            this.lblRFC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(31, 13);
            this.lblRFC.TabIndex = 1;
            this.lblRFC.Text = "RFC:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(468, 292);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // dgvDatosP
            // 
            this.dgvDatosP.AllowUserToAddRows = false;
            this.dgvDatosP.AllowUserToDeleteRows = false;
            this.dgvDatosP.AllowUserToResizeRows = false;
            this.dgvDatosP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosP.Location = new System.Drawing.Point(6, 66);
            this.dgvDatosP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosP.Name = "dgvDatosP";
            this.dgvDatosP.ReadOnly = true;
            this.dgvDatosP.RowHeadersVisible = false;
            this.dgvDatosP.RowTemplate.Height = 28;
            this.dgvDatosP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosP.Size = new System.Drawing.Size(676, 94);
            this.dgvDatosP.TabIndex = 18;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionar.Location = new System.Drawing.Point(213, 7);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(51, 22);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "&Buscar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(614, 376);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 22);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitar.Location = new System.Drawing.Point(87, 291);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(67, 22);
            this.btnQuitar.TabIndex = 22;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(529, 376);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(67, 22);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(52, 36);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(155, 20);
            this.txtRFC.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(489, 358);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(461, 314);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(468, 336);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(53, 13);
            this.lblImpuesto.TabIndex = 1;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(3, 168);
            this.lblCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(32, 13);
            this.lblCant.TabIndex = 1;
            this.lblCant.Text = "Cant:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(338, 21);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 12);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(52, 10);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(155, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(529, 355);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(155, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Tag = "";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(529, 312);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(155, 20);
            this.txtDescuento.TabIndex = 18;
            this.txtDescuento.Tag = "";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(529, 333);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(155, 20);
            this.txtImpuesto.TabIndex = 19;
            this.txtImpuesto.Tag = "";
            this.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(46, 166);
            this.txtCant.Margin = new System.Windows.Forms.Padding(2);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(39, 20);
            this.txtCant.TabIndex = 5;
            this.txtCant.Tag = "";
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(529, 291);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(155, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.Tag = "";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.lblTituloVentas);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 49);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 431);
            this.panel4.TabIndex = 6;
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloVentas.Location = new System.Drawing.Point(34, 116);
            this.lblTituloVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(69, 17);
            this.lblTituloVentas.TabIndex = 1;
            this.lblTituloVentas.Text = "VENTAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MoctERP.Properties.Resources.VENTAS;
            this.pictureBox2.Location = new System.Drawing.Point(16, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlTitulo.Controls.Add(this.pbxCerrar);
            this.pnlTitulo.Controls.Add(this.lblTituloG);
            this.pnlTitulo.Controls.Add(this.pbxLogo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(836, 49);
            this.pnlTitulo.TabIndex = 5;
            this.pnlTitulo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::MoctERP.Properties.Resources.cerrar;
            this.pbxCerrar.Location = new System.Drawing.Point(802, 6);
            this.pbxCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(27, 26);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 4;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblTituloG
            // 
            this.lblTituloG.AutoSize = true;
            this.lblTituloG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloG.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTituloG.Location = new System.Drawing.Point(265, 12);
            this.lblTituloG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloG.Name = "lblTituloG";
            this.lblTituloG.Size = new System.Drawing.Size(296, 29);
            this.lblTituloG.TabIndex = 3;
            this.lblTituloG.Text = "MoctERP - Control Total";
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloG_MouseMove);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 1);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(89, 47);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseMove);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoctERP - Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVentas_MouseMove);
            this.panel1.ResumeLayout(false);
            this.pnlDCliente.ResumeLayout(false);
            this.pnlDCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPAgregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosP)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatosP;
        private System.Windows.Forms.Panel pnlDCliente;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTituloG;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgvDatosPAgregado;
        private System.Windows.Forms.Label lblCanasta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.PictureBox pbxAgregar;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPDescuento;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalPartida;
        private System.Windows.Forms.Button btnQuitar;
    }
}