using LogicaProyecto;
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
    public partial class FrmUsuariosGestion : Form
    {
        //variables locales

        private Usuario MiUsuarioLocal { get; set; }

        public DataTable ListaUsuariosNormal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaUsuariosFiltrada { get; set; }

        public bool FlagCambiarContrasennia { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Usuario();

        }

        //Carga los datos
        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {

            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaUsuarios();

            CargaDatosComboTipoRol();

            LimpiarFormulario();

            ActivarBotonAgregar();

        }

        //Llena la lista con los datos del usuario
        private void LlenarListaUsuarios(bool VerActivos = true, string FiltroBusqueda = "")
        {
            //se llama la clase usuario para manipular los datos
            Usuario MiUsuario = new Usuario();

            //valida los datos de la busqueda
            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                //Si hay datos de busqueda
                ListaUsuariosFiltrada = MiUsuario.Listar(VerActivos, FiltroBusqueda);
                DgvListaUsuarios.DataSource = ListaUsuariosFiltrada;

            }
            else
            {
                //listado normal
                ListaUsuariosNormal = MiUsuario.Listar(VerActivos);
                DgvListaUsuarios.DataSource = ListaUsuariosNormal;

            }

            //X
            DgvListaUsuarios.ClearSelection();
        }

        //Carga los datos del Combobox
        private void CargaDatosComboTipoRol()
        {
            UsuarioRol MiUsuarioRol = new UsuarioRol();

            DataTable datos = new DataTable();

            datos = MiUsuarioRol.Listar();

            CbTipoRol.ValueMember = "ID";

            CbTipoRol.DisplayMember = "Descripcion";

            CbTipoRol.DataSource = datos;

            CbTipoRol.SelectedIndex = -1;
        }

        //Limpia los datos del formulario
        private void LimpiarFormulario()
        {

            TxtID.Clear();
            TxtCedula.Text = TxtCedula.Tag.ToString();
            TxtNombre.Clear();

            TxtTelefono.Clear();
            TxtDireccion.Clear();
            CbTipoRol.SelectedIndex = -1;

            TxtEmail.Clear();
            TxtPassword1.Clear();
            CbActivo.Checked = false;

            FlagCambiarContrasennia = false;
        }

        //valida los datos
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) && TxtCedula.Text.Trim()
                != TxtCedula.Tag.ToString() &&
                !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                 CbTipoRol.SelectedIndex > -1)
            {
                if (BtnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtPassword1.Text.Trim()))
                    {
                        R = true;
                    }
                }

                //Se utiliza la herramienta para validar el email
                if (Herramientas.ValidarEmail(TxtEmail.Text.Trim()))
                {
                    //Se utiliza la herramienta para validar la contraseña
                    if (Herramientas.ValidarPass(TxtPassword1.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña inválida", "Aviso del Sistema", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Email invalido", "Aviso del Sistema", MessageBoxButtons.OK);
                }

                return R;
            }

            return R;
        }

        //valida el email
        private bool ValidarEmail()
        {
            bool r = false;

            if (Herramientas.ValidarEmail(TxtEmail.Text.Trim()))
            {

                r = true;

            }
            else
            {

                MessageBox.Show("El email no es válido", ":(", MessageBoxButtons.OK);

            }
            return r;
        }

        //valida la contraseña
        private bool ValidarContrasennia()
        {
            bool r = false;

            if (Herramientas.ValidarPass(TxtPassword1.Text.Trim()))
            {

                r = true;

            }
            else
            {

                MessageBox.Show("La contraseña no es válida", ":(", MessageBoxButtons.OK);

            }
            return r;
        }

        //Boton que agrega 
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //valida los datos y que todos los campos esten llenos
            if (ValidarDatosRequeridos())
            {
                DialogResult RespuestaUsuario = MessageBox.Show("¿Esta seguro de agregar el nuevo usuario?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (RespuestaUsuario == DialogResult.Yes)
                {

                    LogicaProyecto.Usuario Miusuario = new LogicaProyecto.Usuario();

                    Miusuario.Cedula = TxtCedula.Text.Trim();
                    Miusuario.Nombre = TxtNombre.Text.Trim();

                    Miusuario.Telefono = TxtTelefono.Text.Trim();
                    Miusuario.Direccion = TxtDireccion.Text.Trim();
                    Miusuario.Email = TxtEmail.Text.Trim();

                    Miusuario.Contrasennia  = TxtPassword1.Text.Trim();
                    Miusuario.Rol.IDUsuarioRol = Convert.ToInt32(CbTipoRol.SelectedValue);

                    bool CedulaExiste = Miusuario.ConsultarPorCedula();

                    bool EmailExiste = Miusuario.ConsultarPorEmail();

                    if (!CedulaExiste && !EmailExiste)
                    {
                        //se agrega el usuario
                        if (Miusuario.Agregar())
                        {
                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaUsuarios(true);
                            ActivarBotonAgregar();

                        }


                    }
                    else //valida que los datos ya existen
                    {
                        if (CedulaExiste)
                        {
                            MessageBox.Show("La Cedula ya esta siendo usada", ":(", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();

                        }
                        else if (EmailExiste)
                        {
                            MessageBox.Show("El Email ya esta siendo usada", ":(", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();

                        }

                    }

                }

            }
        }

        //Boton que edita los datos
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //valida los dattos
            if (ValidarDatosRequeridos())
            {
                Usuario Miusuario = new Usuario();

                Miusuario.IDUsuario = Convert.ToInt32(TxtID.Text.Trim());

                Miusuario.Cedula = TxtCedula.Text.Trim();
                Miusuario.Nombre = TxtNombre.Text.Trim();

                Miusuario.Telefono = TxtTelefono.Text.Trim();
                Miusuario.Direccion = TxtDireccion.Text.Trim();
                Miusuario.Email = TxtEmail.Text.Trim();


                Miusuario.Contrasennia = "";

                //valida el cmabio de la contraseña 
                if (FlagCambiarContrasennia)
                {
                    Miusuario.Contrasennia = TxtPassword1.Text.Trim();
                }

                Miusuario.Rol.IDUsuarioRol = Convert.ToInt32(CbTipoRol.SelectedValue);

                if (Miusuario.ConsultarPorID())
                { 
                    //Edita los datos
                    if (Miusuario.Editar())
                    {
                        MessageBox.Show("Usuario modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        //Boton que elimina los datos
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Usuario Miusuario = new Usuario();

            Miusuario.IDUsuario = Convert.ToInt32(TxtID.Text.Trim());

            if (Miusuario.ConsultarPorID())
            {
                //Activa los datos
                if (FlagActivar)
                {
                    if (Miusuario.Activar())
                    {
                        MessageBox.Show("Usuario activado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
                        ActivarBotonAgregar();
                    }
                }
                else
                {
                    //desactiva los datos
                    if (Miusuario.Desactivar())
                    {
                        MessageBox.Show("Usuario eliminado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        LlenarListaUsuarios(true);
                        ActivarBotonAgregar();
                    }
                }
            }
        }

        //Checkbox para mostrar los usuarios activos
        private void CbVerUsuariosActivos_CheckedChanged(object sender, EventArgs e)
        {
            //llena la lista con los datos de los usuarios 
            LlenarListaUsuarios(CbVerUsuariosActivos.Checked);

            if (!CbVerUsuariosActivos.Checked)
            {

                BtnEliminar.Text = "Activar";

            }
            else
            {

                BtnEliminar.Text = "Eliminar";

            }
        }

        //Boton para salir del formulario
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Barra de busqueda
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //valida que la no este barra vacia y la cantidad sea mayor o igual a dos letras 
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 2)
            {
                LlenarListaUsuarios(CbVerUsuariosActivos.Checked, TxtBuscar.Text.Trim());
            }
            else
            {
                LlenarListaUsuarios(CbVerUsuariosActivos.Checked);
            }
        }

        //Boton que limpia los datos del formulario
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBotonAgregar();
            DgvListaUsuarios.ClearSelection();
        }

        //Activa solo los botones editar y eliminar
        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCedula.Enabled = false;
        }

        //activa el boton agregar
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCedula.Enabled = true;
        }

        private void TxtCedula_Enter(object sender, EventArgs e)
        {
            //valida que la cedula exista, ya que es un dato requerido
            if (TxtCedula.Text == TxtCedula.Tag.ToString())
            {
                TxtCedula.Clear();
            }
        }

        //Cambia el color de la palabra de fondo, para que el usuario sepa que es un dato requerido
        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            TxtCedula.ForeColor = Color.Black;

            if (TxtCedula.Text == TxtCedula.Tag.ToString())
            {
                TxtCedula.ForeColor = Color.LightGray;

            }
        }

        //Se utiliza una herramienta que solo permite numeros
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //se utiliza una herramienta que permita numeros y letras pero solo en minuscula
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);
        }

        //se utiliza una herrmaienta que permita numeros y letras solo en mayuscula 
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        //Evento que selecciona una fila
        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //valida que la fila esta seleecionada
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                int IdUsuario = Convert.ToInt32(MiFila.Cells["ColIDUsuario"].Value);

                MiUsuarioLocal = new Usuario();

                MiUsuarioLocal = MiUsuarioLocal.Consultar(IdUsuario);

                TxtID.Text = MiUsuarioLocal.IDUsuario.ToString();
                TxtCedula.Text = MiUsuarioLocal.Cedula;
                TxtNombre.Text = MiUsuarioLocal.Nombre;

                TxtTelefono.Text = MiUsuarioLocal.Telefono;
                TxtDireccion.Text = MiUsuarioLocal.Direccion;
                CbTipoRol.SelectedValue = MiUsuarioLocal.Rol.IDUsuarioRol;

                TxtEmail.Text = MiUsuarioLocal.Email;

                CbActivo.Checked = MiUsuarioLocal.Activo;

                ActivarEditarYEliminar();
            }

        }

    }
}
