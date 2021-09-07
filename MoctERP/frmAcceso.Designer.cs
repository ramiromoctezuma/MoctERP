namespace MoctERP
{
    partial class frmAcceso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnContinuarU = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblLinea = new System.Windows.Forms.Label();
            this.pnlContraseña = new System.Windows.Forms.Panel();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnContinuarC = new System.Windows.Forms.Button();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsuario.SuspendLayout();
            this.pnlContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(47, 40);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(122, 24);
            this.lblIniciarSesion.TabIndex = 0;
            this.lblIniciarSesion.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(88, 107);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(49, 128);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 13);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "1";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContinuarU
            // 
            this.btnContinuarU.Location = new System.Drawing.Point(73, 155);
            this.btnContinuarU.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinuarU.Name = "btnContinuarU";
            this.btnContinuarU.Size = new System.Drawing.Size(73, 20);
            this.btnContinuarU.TabIndex = 3;
            this.btnContinuarU.Text = "Continuar";
            this.btnContinuarU.UseVisualStyleBackColor = true;
            this.btnContinuarU.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.lblIniciarSesion);
            this.pnlUsuario.Controls.Add(this.btnContinuarU);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Controls.Add(this.txtUsuario);
            this.pnlUsuario.Controls.Add(this.lblLinea);
            this.pnlUsuario.Location = new System.Drawing.Point(18, 31);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(220, 224);
            this.pnlUsuario.TabIndex = 4;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(43, 130);
            this.lblLinea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(133, 13);
            this.lblLinea.TabIndex = 6;
            this.lblLinea.Text = "_____________________";
            // 
            // pnlContraseña
            // 
            this.pnlContraseña.Controls.Add(this.txtNombreU);
            this.pnlContraseña.Controls.Add(this.lblBienvenida);
            this.pnlContraseña.Controls.Add(this.btnContinuarC);
            this.pnlContraseña.Controls.Add(this.lblContrasena);
            this.pnlContraseña.Controls.Add(this.txtContrasena);
            this.pnlContraseña.Controls.Add(this.label2);
            this.pnlContraseña.Location = new System.Drawing.Point(20, 29);
            this.pnlContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContraseña.Name = "pnlContraseña";
            this.pnlContraseña.Size = new System.Drawing.Size(220, 224);
            this.pnlContraseña.TabIndex = 5;
            this.pnlContraseña.Visible = false;
            // 
            // txtNombreU
            // 
            this.txtNombreU.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreU.Enabled = false;
            this.txtNombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreU.Location = new System.Drawing.Point(15, 77);
            this.txtNombreU.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreU.MaxLength = 15;
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(193, 22);
            this.txtNombreU.TabIndex = 10;
            this.txtNombreU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(6, 39);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(212, 24);
            this.lblBienvenida.TabIndex = 8;
            this.lblBienvenida.Text = "Te damos la bienvenida";
            // 
            // btnContinuarC
            // 
            this.btnContinuarC.Location = new System.Drawing.Point(75, 154);
            this.btnContinuarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinuarC.Name = "btnContinuarC";
            this.btnContinuarC.Size = new System.Drawing.Size(73, 20);
            this.btnContinuarC.TabIndex = 3;
            this.btnContinuarC.Text = "&Continuar";
            this.btnContinuarC.UseVisualStyleBackColor = true;
            this.btnContinuarC.Click += new System.EventHandler(this.btnContinuarC_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(81, 106);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.Menu;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Location = new System.Drawing.Point(51, 127);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasena.MaxLength = 15;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(120, 13);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.Text = "1";
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "_____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(220, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmAcceso
            // 
            this.AcceptButton = this.btnContinuarU;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(258, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlContraseña);
            this.Controls.Add(this.pnlUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso - MoctERP";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlContraseña.ResumeLayout(false);
            this.pnlContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnContinuarU;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlContraseña;
        private System.Windows.Forms.Button btnContinuarC;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

