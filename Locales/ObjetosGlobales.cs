using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra52021.Locales
{
    public static class ObjetosGlobales
    {
        //Objetos globales que se utilizan en los formularios
        public static Form MiFormPrincipal = new Formularios.FrmPrincipal();

        public static LogicaProyecto.Usuario MiUsuarioGlobal = new LogicaProyecto.Usuario();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        public static Formularios.FrmVentasGestion MiFromGestionCompras = new Formularios.FrmVentasGestion();

        public static Formularios.FrmProductos MiFormProductos = new Formularios.FrmProductos();

        public static Formularios.FrmClientesGestion MiFormClientes = new Formularios.FrmClientesGestion();

        public static Formularios.FrmProductos MiFormProducto = new Formularios.FrmProductos();

        public static Formularios.FrmRecuperacionContrasenia MiFormRecuperacion = new Formularios.FrmRecuperacionContrasenia();

    }
}
