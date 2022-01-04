namespace ProyectoProgra52021.Formularios
{
    partial class FrmRecuperacionContrasenia
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
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtCodigoVerificacion = new System.Windows.Forms.TextBox();
            this.TxtNuevaContrasennia = new System.Windows.Forms.TextBox();
            this.TxtConfirmarContrasennia = new System.Windows.Forms.TextBox();
            this.BtnEnviarCodigo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(46, 41);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(227, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtCodigoVerificacion
            // 
            this.TxtCodigoVerificacion.Location = new System.Drawing.Point(46, 169);
            this.TxtCodigoVerificacion.Name = "TxtCodigoVerificacion";
            this.TxtCodigoVerificacion.Size = new System.Drawing.Size(227, 20);
            this.TxtCodigoVerificacion.TabIndex = 1;
            // 
            // TxtNuevaContrasennia
            // 
            this.TxtNuevaContrasennia.Location = new System.Drawing.Point(46, 245);
            this.TxtNuevaContrasennia.Name = "TxtNuevaContrasennia";
            this.TxtNuevaContrasennia.Size = new System.Drawing.Size(227, 20);
            this.TxtNuevaContrasennia.TabIndex = 2;
            // 
            // TxtConfirmarContrasennia
            // 
            this.TxtConfirmarContrasennia.Location = new System.Drawing.Point(46, 308);
            this.TxtConfirmarContrasennia.Name = "TxtConfirmarContrasennia";
            this.TxtConfirmarContrasennia.Size = new System.Drawing.Size(227, 20);
            this.TxtConfirmarContrasennia.TabIndex = 3;
            // 
            // BtnEnviarCodigo
            // 
            this.BtnEnviarCodigo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviarCodigo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEnviarCodigo.Location = new System.Drawing.Point(91, 78);
            this.BtnEnviarCodigo.Name = "BtnEnviarCodigo";
            this.BtnEnviarCodigo.Size = new System.Drawing.Size(144, 42);
            this.BtnEnviarCodigo.TabIndex = 4;
            this.BtnEnviarCodigo.Text = "Enviar Codigo";
            this.BtnEnviarCodigo.UseVisualStyleBackColor = false;
            this.BtnEnviarCodigo.Click += new System.EventHandler(this.BtnEnviarCodigo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de usuario (Email)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite el codigo de verificacion enviado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar contraseña";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(188, 387);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 30);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAceptar.Location = new System.Drawing.Point(46, 387);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(89, 30);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmRecuperacionContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnviarCodigo);
            this.Controls.Add(this.TxtConfirmarContrasennia);
            this.Controls.Add(this.TxtNuevaContrasennia);
            this.Controls.Add(this.TxtCodigoVerificacion);
            this.Controls.Add(this.TxtUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecuperacionContrasenia";
            this.Text = "Recuperacion de la contraseña";
            this.Load += new System.EventHandler(this.FrmRecuperacionContrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtCodigoVerificacion;
        private System.Windows.Forms.TextBox TxtNuevaContrasennia;
        private System.Windows.Forms.TextBox TxtConfirmarContrasennia;
        private System.Windows.Forms.Button BtnEnviarCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}