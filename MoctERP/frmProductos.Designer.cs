namespace MoctERP
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDProductoGrid = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvDatosC = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlDProducto = new System.Windows.Forms.Panel();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.rbtProductoT = new System.Windows.Forms.RadioButton();
            this.rbtMaterial = new System.Windows.Forms.RadioButton();
            this.cboLinea = new System.Windows.Forms.ComboBox();
            this.btnAplicarM = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnSeleccionaI = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtFotografia = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblTituloG = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlDProductoGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosC)).BeginInit();
            this.pnlDProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
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
            this.panel1.Controls.Add(this.pnlDProductoGrid);
            this.panel1.Controls.Add(this.pnlDProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 602);
            this.panel1.TabIndex = 7;
            // 
            // pnlDProductoGrid
            // 
            this.pnlDProductoGrid.Controls.Add(this.lblBuscar);
            this.pnlDProductoGrid.Controls.Add(this.txtBusqueda);
            this.pnlDProductoGrid.Controls.Add(this.btnModificar);
            this.pnlDProductoGrid.Controls.Add(this.dgvDatosC);
            this.pnlDProductoGrid.Controls.Add(this.btnConsultar);
            this.pnlDProductoGrid.Controls.Add(this.btnEliminar);
            this.pnlDProductoGrid.Controls.Add(this.btnNuevo);
            this.pnlDProductoGrid.Location = new System.Drawing.Point(22, 9);
            this.pnlDProductoGrid.Name = "pnlDProductoGrid";
            this.pnlDProductoGrid.Size = new System.Drawing.Size(1021, 574);
            this.pnlDProductoGrid.TabIndex = 23;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(63, 20);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(81, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(332, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Tag = "";
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(601, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 38);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvDatosC
            // 
            this.dgvDatosC.AllowUserToAddRows = false;
            this.dgvDatosC.AllowUserToDeleteRows = false;
            this.dgvDatosC.AllowUserToResizeRows = false;
            this.dgvDatosC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosC.Location = new System.Drawing.Point(17, 60);
            this.dgvDatosC.Name = "dgvDatosC";
            this.dgvDatosC.ReadOnly = true;
            this.dgvDatosC.RowHeadersVisible = false;
            this.dgvDatosC.RowTemplate.Height = 28;
            this.dgvDatosC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosC.Size = new System.Drawing.Size(994, 506);
            this.dgvDatosC.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(885, 11);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 34);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(743, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(459, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 38);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlDProducto
            // 
            this.pnlDProducto.Controls.Add(this.pbxFoto);
            this.pnlDProducto.Controls.Add(this.rbtProductoT);
            this.pnlDProducto.Controls.Add(this.rbtMaterial);
            this.pnlDProducto.Controls.Add(this.cboLinea);
            this.pnlDProducto.Controls.Add(this.btnAplicarM);
            this.pnlDProducto.Controls.Add(this.lblFoto);
            this.pnlDProducto.Controls.Add(this.lblPrecio);
            this.pnlDProducto.Controls.Add(this.btnEliminarC);
            this.pnlDProducto.Controls.Add(this.btnSeleccionaI);
            this.pnlDProducto.Controls.Add(this.btnCancelar);
            this.pnlDProducto.Controls.Add(this.btnAgregar);
            this.pnlDProducto.Controls.Add(this.lblDescripcion);
            this.pnlDProducto.Controls.Add(this.txtDescripcion);
            this.pnlDProducto.Controls.Add(this.txtUnidadMedida);
            this.pnlDProducto.Controls.Add(this.txtCosto);
            this.pnlDProducto.Controls.Add(this.txtPrecio);
            this.pnlDProducto.Controls.Add(this.txtExistencia);
            this.pnlDProducto.Controls.Add(this.lblTipo);
            this.pnlDProducto.Controls.Add(this.txtFotografia);
            this.pnlDProducto.Controls.Add(this.lblExistencia);
            this.pnlDProducto.Controls.Add(this.lblUnidadMedida);
            this.pnlDProducto.Controls.Add(this.lblLinea);
            this.pnlDProducto.Controls.Add(this.lblCosto);
            this.pnlDProducto.Location = new System.Drawing.Point(103, 9);
            this.pnlDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDProducto.Name = "pnlDProducto";
            this.pnlDProducto.Size = new System.Drawing.Size(856, 454);
            this.pnlDProducto.TabIndex = 19;
            this.pnlDProducto.Visible = false;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(473, 54);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(305, 306);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 24;
            this.pbxFoto.TabStop = false;
            // 
            // rbtProductoT
            // 
            this.rbtProductoT.AutoSize = true;
            this.rbtProductoT.Location = new System.Drawing.Point(260, 338);
            this.rbtProductoT.Name = "rbtProductoT";
            this.rbtProductoT.Size = new System.Drawing.Size(177, 24);
            this.rbtProductoT.TabIndex = 7;
            this.rbtProductoT.TabStop = true;
            this.rbtProductoT.Text = "Producto Terminado";
            this.rbtProductoT.UseVisualStyleBackColor = true;
            // 
            // rbtMaterial
            // 
            this.rbtMaterial.AutoSize = true;
            this.rbtMaterial.Location = new System.Drawing.Point(98, 338);
            this.rbtMaterial.Name = "rbtMaterial";
            this.rbtMaterial.Size = new System.Drawing.Size(131, 24);
            this.rbtMaterial.TabIndex = 6;
            this.rbtMaterial.TabStop = true;
            this.rbtMaterial.Text = "Materia Prima";
            this.rbtMaterial.UseVisualStyleBackColor = true;
            // 
            // cboLinea
            // 
            this.cboLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinea.FormattingEnabled = true;
            this.cboLinea.Location = new System.Drawing.Point(172, 242);
            this.cboLinea.Name = "cboLinea";
            this.cboLinea.Size = new System.Drawing.Size(228, 28);
            this.cboLinea.TabIndex = 4;
            // 
            // btnAplicarM
            // 
            this.btnAplicarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAplicarM.Location = new System.Drawing.Point(325, 388);
            this.btnAplicarM.Name = "btnAplicarM";
            this.btnAplicarM.Size = new System.Drawing.Size(100, 34);
            this.btnAplicarM.TabIndex = 10;
            this.btnAplicarM.Text = "&Aplicar";
            this.btnAplicarM.UseVisualStyleBackColor = true;
            this.btnAplicarM.Click += new System.EventHandler(this.btnAplicarM_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(449, 14);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(86, 20);
            this.lblFoto.TabIndex = 1;
            this.lblFoto.Text = "Fotografía:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(101, 152);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarC.Location = new System.Drawing.Point(447, 388);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(100, 34);
            this.btnEliminarC.TabIndex = 11;
            this.btnEliminarC.Text = "C&onfirmar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnSeleccionaI
            // 
            this.btnSeleccionaI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionaI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionaI.Location = new System.Drawing.Point(735, 3);
            this.btnSeleccionaI.Name = "btnSeleccionaI";
            this.btnSeleccionaI.Size = new System.Drawing.Size(43, 35);
            this.btnSeleccionaI.TabIndex = 8;
            this.btnSeleccionaI.Text = "...";
            this.btnSeleccionaI.UseVisualStyleBackColor = true;
            this.btnSeleccionaI.Click += new System.EventHandler(this.btnSeleccionaI_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(569, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "C&ancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(203, 388);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(68, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(170, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 26);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(170, 289);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(230, 26);
            this.txtUnidadMedida.TabIndex = 5;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(170, 101);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(230, 26);
            this.txtCosto.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(170, 149);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 26);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.Tag = "";
            this.txtPrecio.Text = "3";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(170, 197);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(230, 26);
            this.txtExistencia.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(33, 340);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtFotografia
            // 
            this.txtFotografia.Location = new System.Drawing.Point(541, 11);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.Size = new System.Drawing.Size(184, 26);
            this.txtFotografia.TabIndex = 14;
            this.txtFotografia.Tag = "";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(79, 200);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(85, 20);
            this.lblExistencia.TabIndex = 1;
            this.lblExistencia.Text = "Existencia:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(13, 292);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(142, 20);
            this.lblUnidadMedida.TabIndex = 1;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(103, 250);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(52, 20);
            this.lblLinea.TabIndex = 1;
            this.lblLinea.Text = "Linea:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(105, 104);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(55, 20);
            this.lblCosto.TabIndex = 1;
            this.lblCosto.Text = "Costo:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.lblTituloProductos);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 602);
            this.panel4.TabIndex = 6;
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloProductos.Location = new System.Drawing.Point(27, 177);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(149, 25);
            this.lblTituloProductos.TabIndex = 1;
            this.lblTituloProductos.Text = "PRODUCTOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MoctERP.Properties.Resources.PRODUCTOS;
            this.pictureBox2.Location = new System.Drawing.Point(24, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 154);
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
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1257, 75);
            this.pnlTitulo.TabIndex = 5;
            //this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::MoctERP.Properties.Resources.cerrar;
            this.pbxCerrar.Location = new System.Drawing.Point(1203, 9);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(40, 40);
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
            this.lblTituloG.Location = new System.Drawing.Point(398, 18);
            this.lblTituloG.Name = "lblTituloG";
            this.lblTituloG.Size = new System.Drawing.Size(430, 40);
            this.lblTituloG.TabIndex = 3;
            this.lblTituloG.Text = "MoctERP - Control Total";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(4, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(134, 72);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "frmProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoctERP - Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDProductoGrid.ResumeLayout(false);
            this.pnlDProductoGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosC)).EndInit();
            this.pnlDProducto.ResumeLayout(false);
            this.pnlDProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
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
        private System.Windows.Forms.Panel pnlDProductoGrid;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvDatosC;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlDProducto;
        private System.Windows.Forms.ComboBox cboLinea;
        private System.Windows.Forms.Button btnAplicarM;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtFotografia;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTituloG;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.RadioButton rbtProductoT;
        private System.Windows.Forms.RadioButton rbtMaterial;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button btnSeleccionaI;
    }
}