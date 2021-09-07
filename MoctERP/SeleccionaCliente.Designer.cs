namespace MoctERP
{
    partial class SeleccionaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionaCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTituloG = new System.Windows.Forms.Label();
            this.pnlDClienteGrid = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvDatosC = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlDClienteGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pnlDClienteGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 373);
            this.panel1.TabIndex = 6;
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
            this.pnlTitulo.Size = new System.Drawing.Size(921, 75);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTituloG
            // 
            this.lblTituloG.AutoSize = true;
            this.lblTituloG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloG.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTituloG.Location = new System.Drawing.Point(257, 19);
            this.lblTituloG.Name = "lblTituloG";
            this.lblTituloG.Size = new System.Drawing.Size(430, 40);
            this.lblTituloG.TabIndex = 3;
            this.lblTituloG.Text = "MoctERP - Control Total";
            // 
            // pnlDClienteGrid
            // 
            this.pnlDClienteGrid.Controls.Add(this.lblBuscar);
            this.pnlDClienteGrid.Controls.Add(this.txtBusqueda);
            this.pnlDClienteGrid.Controls.Add(this.btnCancelar);
            this.pnlDClienteGrid.Controls.Add(this.dgvDatosC);
            this.pnlDClienteGrid.Controls.Add(this.btnSeleccionar);
            this.pnlDClienteGrid.Location = new System.Drawing.Point(12, 6);
            this.pnlDClienteGrid.Name = "pnlDClienteGrid";
            this.pnlDClienteGrid.Size = new System.Drawing.Size(901, 349);
            this.pnlDClienteGrid.TabIndex = 23;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccionar.Location = new System.Drawing.Point(459, 9);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(110, 38);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
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
            this.dgvDatosC.Size = new System.Drawing.Size(874, 268);
            this.dgvDatosC.TabIndex = 18;
            this.dgvDatosC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosC_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(601, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(81, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(332, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Tag = "";
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
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::MoctERP.Properties.Resources.cerrar;
            this.pbxCerrar.Location = new System.Drawing.Point(1203, 9);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(40, 40);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 4;
            this.pbxCerrar.TabStop = false;
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
            // SeleccionaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "SeleccionaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionaCliente";
            this.Load += new System.EventHandler(this.SeleccionaCliente_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlDClienteGrid.ResumeLayout(false);
            this.pnlDClienteGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.Label lblTituloG;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlDClienteGrid;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDatosC;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}