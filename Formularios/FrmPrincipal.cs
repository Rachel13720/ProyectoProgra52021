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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //carga el formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            //Este control de seleccion permite el acceso a los formularios segun permiso que tena el rol del usuario ingresado
            switch (Locales.ObjetosGlobales.MiUsuarioGlobal.Rol.IDUsuarioRol)
            {
                //admin
                case 1:
                    //por el momento no haremos nada ya que el admin tiene acceso 
                    //a todo
                    break;
                case 2:
                    //ocultamos las opciones de menu que no le corresponden al usuario 
                    //normal
                    mantenimientosToolStripMenuItem.Visible = false;
                    rEPORTESToolStripMenuItem.Visible = false;

                    break;
            }
        }

        //Muestra el formulario de Gestion de Ventas
        private void gestionDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFromGestionCompras.Visible)
            {
                Locales.ObjetosGlobales.MiFromGestionCompras = new FrmVentasGestion();
                Locales.ObjetosGlobales.MiFromGestionCompras.Show();
            }
        }

        //Muestra el formulario de usuario
        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormGestionUsuarios.Visible)
            {
                Locales.ObjetosGlobales.MiFormGestionUsuarios = new FrmUsuariosGestion();
                Locales.ObjetosGlobales.MiFormGestionUsuarios.Show();
            }

        }

        //Cierra el formulario principal y sale de la aplicacion
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Muestra el fromulario de productos
        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormProductos.Visible)
            {
                Locales.ObjetosGlobales.MiFormProductos = new FrmProductos();
                Locales.ObjetosGlobales.MiFormProductos.Show();
            }
        }

        //muestra el formulario de clientes
        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormClientes.Visible)
            {
                Locales.ObjetosGlobales.MiFormClientes = new FrmClientesGestion();
                Locales.ObjetosGlobales.MiFormClientes.Show();
            }
        }
        
    }
}
