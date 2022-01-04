namespace ProyectoProgra52021.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtContrasennia = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContra = new System.Windows.Forms.Label();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnIngresoDirecto = new System.Windows.Forms.Button();
            this.LblRecuperarPassword = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtContrasennia
            // 
            this.TxtContrasennia.Location = new System.Drawing.Point(67, 248);
            this.TxtContrasennia.Name = "TxtContrasennia";
            this.TxtContrasennia.Size = new System.Drawing.Size(227, 20);
            this.TxtContrasennia.TabIndex = 1;
            this.TxtContrasennia.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(67, 184);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(227, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnIngresar.Location = new System.Drawing.Point(24, 309);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(102, 33);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(238, 309);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 33);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(141, 155);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(89, 27);
            this.LblUsuario.TabIndex = 5;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContra.Location = new System.Drawing.Point(123, 218);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(127, 27);
            this.LblContra.TabIndex = 6;
            this.LblContra.Text = "Contraseña";
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.Color.Indigo;
            this.BtnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVer.Location = new System.Drawing.Point(300, 241);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(52, 31);
            this.BtnVer.TabIndex = 7;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnVer_MouseDown);
            this.BtnVer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnVer_MouseUp);
            // 
            // BtnIngresoDirecto
            // 
            this.BtnIngresoDirecto.Location = new System.Drawing.Point(51, 274);
            this.BtnIngresoDirecto.Name = "BtnIngresoDirecto";
            this.BtnIngresoDirecto.Size = new System.Drawing.Size(96, 23);
            this.BtnIngresoDirecto.TabIndex = 8;
            this.BtnIngresoDirecto.Text = "Ingreso Directo";
            this.BtnIngresoDirecto.UseVisualStyleBackColor = true;
            this.BtnIngresoDirecto.Click += new System.EventHandler(this.BtnIngresoDirecto_Click);
            // 
            // LblRecuperarPassword
            // 
            this.LblRecuperarPassword.AutoSize = true;
            this.LblRecuperarPassword.Location = new System.Drawing.Point(249, 274);
            this.LblRecuperarPassword.Name = "LblRecuperarPassword";
            this.LblRecuperarPassword.Size = new System.Drawing.Size(106, 13);
            this.LblRecuperarPassword.TabIndex = 9;
            this.LblRecuperarPassword.TabStop = true;
            this.LblRecuperarPassword.Text = "Olvide mi contraseña";
            this.LblRecuperarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRecuperarPassword_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(375, 354);
            this.Controls.Add(this.LblRecuperarPassword);
            this.Controls.Add(this.BtnIngresoDirecto);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LblContra);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtContrasennia);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login del Sistema";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtContrasennia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnIngresoDirecto;
        private System.Windows.Forms.LinkLabel LblRecuperarPassword;
    }
}