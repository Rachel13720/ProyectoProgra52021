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
    public partial class FrmRecuperacionContrasenia : Form
    {
        //variables globales
        public bool CorreoEnviado { get; set; }

        public LogicaProyecto.Email MyEmail { get; set; }

        public LogicaProyecto.Usuario MyUser { get; set; }

        public FrmRecuperacionContrasenia()
        {
            InitializeComponent();

            CorreoEnviado = false;
            MyEmail = new LogicaProyecto.Email();
            MyUser = new LogicaProyecto.Usuario();
        }

        //boton qu envia el codigo al correo
        private void BtnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) && Herramientas.ValidarEmail(TxtUsuario.Text.Trim()))
            {

                MyUser.Email = TxtUsuario.Text.Trim();

                if (MyUser.ConsultarPorEmail())
                {
                    if (MyUser.GuardarCodigoRecuperacionContrasennia(CodigoContrasennia()))
                    {
                        LogicaProyecto.Email MiCorreo = new LogicaProyecto.Email();

                        MiCorreo.Asunto = "CORREO DE RECCUPERACION DE CONTRASEÑA SISTEMA DE COMPRAS PROGRA 5 ";

                        MiCorreo.CorreoDestino = TxtUsuario.Text.Trim();

                        string Mensaje = string.Format("Su codigo de recuperacion de contraseña es: {0}", CodigoContrasennia());

                        MiCorreo.Mensaje = Mensaje;

                        if (MiCorreo.EnviarCorreo_Net_Mail_SmtpClient())
                        {

                            MessageBox.Show("Correo enviado con exito", ":)", MessageBoxButtons.OK);


                            TxtCodigoVerificacion.Enabled = true;
                            TxtNuevaContrasennia.Enabled = true;
                            TxtConfirmarContrasennia.Enabled = true;

                        }

                    }

                }
                else
                {

                    MessageBox.Show("El email no existe", "Error de validacion de datos", MessageBoxButtons.OK);
                }

            }
        }

        //metodo que crea un codigo de recuperacion
        private string CodigoContrasennia()
        {
            string CodigoParaEnviar = "";

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string num = "1234567890";
            string caracter = "%$&*!/@#";

            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                int indice = rand.Next(alfabeto.Length);
                CodigoParaEnviar += alfabeto[indice];
            }

            for (int i = 0; i < 3; i++)
            {
                int indice = rand.Next(num.Length);
                CodigoParaEnviar += num[indice];
            }

            for (int i = 0; i < 3; i++)
            {
                int indice = rand.Next(caracter.Length);
                CodigoParaEnviar += caracter[indice];
            }

            return CodigoParaEnviar;

        }

        //Carga los datos del formulario 
        private void FrmRecuperacionContrasenia_Load(object sender, EventArgs e)
        {
            TxtCodigoVerificacion.Enabled = false;
            TxtNuevaContrasennia.Enabled = false;
            TxtConfirmarContrasennia.Enabled = false;
        }

        //boton que acepta los datos ingresados
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //valida los datos
            if (ValidarCampos())
            {
                //valida que el codigo sea el correcto
                MyUser.Email = TxtUsuario.Text.Trim();

                MyUser.Contrasennia = TxtNuevaContrasennia.Text.Trim();

                //valida el codigo de verifiacion
                if (MyUser.ValidarCodigoVerificacion(TxtUsuario.Text.Trim(), TxtCodigoVerificacion.Text.Trim()))
                {
                    //edita la contraseña
                    if (MyUser.EditarPassword())
                    {

                        MessageBox.Show("Contraseña actualiza con éxito!!", ":)", MessageBoxButtons.OK);
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Codigo de verificación es incorrecto", ":(", MessageBoxButtons.OK);
                    TxtCodigoVerificacion.Focus();
                    TxtCodigoVerificacion.SelectAll();
                }

            }
        }

        //valida los campos respectivos
        private bool ValidarCampos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCodigoVerificacion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNuevaContrasennia.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtConfirmarContrasennia.Text.Trim()) &&
                TxtNuevaContrasennia.Text.Trim() == TxtConfirmarContrasennia.Text.Trim())
            {
                R = true;
            }

            return R;

        }

        //boton que permite salir del formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
