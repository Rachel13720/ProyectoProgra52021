using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra52021.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        //boton que permite ingresar el usuario al sistema
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //valida el usuario y su contraseña
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string u = TxtUsuario.Text.Trim();
                string p = TxtContrasennia.Text.Trim();

                LogicaProyecto.Usuario MiUsuario = new LogicaProyecto.Usuario();

                int IdUsuarioValidado = MiUsuario.ValidarLogin(u, p);

                //si los datos del usuario son correctos ingreas al formulario principal
                if (IdUsuarioValidado > 0)
                {
                    Locales.ObjetosGlobales.MiUsuarioGlobal = MiUsuario.Consultar(IdUsuarioValidado);

                    Locales.ObjetosGlobales.MiFormPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son incorrectos", ":(", MessageBoxButtons.OK);
                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }
            }
        }

        //evento que se ejecuta al presionar el boton
        private void BtnVer_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        //evento que se ejecuta al soltar el boton
        private void BtnVer_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        //boton cierra el formulario, y sale de la ap´licacion
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton secreto que permite el ingreso directo al formulario principal
        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario = 1;
            Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre = "Steven";
            Locales.ObjetosGlobales.MiUsuarioGlobal.Email = "steven@gmail.com";
            Locales.ObjetosGlobales.MiUsuarioGlobal.Rol.IDUsuarioRol = 1;


            Locales.ObjetosGlobales.MiFormPrincipal.Show();
            this.Hide();
        }

        //Evento que permite utilizar las teclas de funcion
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.Shift & e.KeyCode == Keys.Tab)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }
        //evento que llama al formulario de la recuperacion de la contraseña al hacer click encima del link
        private void LblRecuperarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Locales.ObjetosGlobales.MiFormRecuperacion.Text = TxtUsuario.Text;
            Locales.ObjetosGlobales.MiFormRecuperacion.Show();
        }

    }
}
