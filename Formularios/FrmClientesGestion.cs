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
    public partial class FrmClientesGestion : Form
    {
        //variables globales
        private Cliente MiClienteLocal { get; set; }

        public DataTable ListaClientesNormal { get; set; }

        private bool FlagActivar { get; set; }

        public DataTable ListaClientesFiltrada { get; set; }

        public FrmClientesGestion()
        {
            InitializeComponent();

            MiClienteLocal = new Cliente();
        }

        //Boton que elimina los datos del cliente
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Cliente MiCliente = new Cliente();

                MiCliente.IDCliente = Convert.ToInt32(TxtCodigo.Text.Trim());


                if (MiCliente.ConsultarPorID())
                {
                    if (FlagActivar)
                    {
                        if (MiCliente.Activar())
                        {
                            MessageBox.Show("Cliente activado correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            LlenarListaClientes(CbVerClientesActivos.Checked);
                            ActivarBtnAgregar();
                        }
                    }
                    else
                    {
                        if (MiCliente.Desactivar())
                        {
                            MessageBox.Show("Cliente eliminado correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            LlenarListaClientes(true);
                            ActivarBtnAgregar();
                        }
                    }
                }
            }
            
        }

        //carga los datos del cliente
        private void FrmClientesGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaClientes();

            LimpiarFormulario();

            ActivarBtnAgregar();
        }

        //llena la lista con los datos del cliente
        private void LlenarListaClientes(bool VerActivos = true, string FiltroBusqueda = "")
        {
            Cliente MiCliente = new Cliente();


            if (!string.IsNullOrEmpty(FiltroBusqueda.Trim()))
            {
                ListaClientesFiltrada = MiCliente.Listar(VerActivos, FiltroBusqueda);
                DgvListaClientes.DataSource = ListaClientesFiltrada;

            }
            else
            {
                //listado normal
                ListaClientesNormal = MiCliente.Listar(VerActivos);
                DgvListaClientes.DataSource = ListaClientesNormal;

            }

            //X
            DgvListaClientes.ClearSelection();
        }

        //limpia los datos del cliente en el formulario
        private void LimpiarFormulario()
        {
            TxtCodigo.Clear();
            TxtCedula.Text = TxtCedula.Tag.ToString();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            CbActivo.Checked = false;

        }

        //Activa solo el boton agregar
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCedula.Enabled = true;

        }

        //Activa solo el boton modificar y eliminar
        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCedula.Enabled = false;

        }

        //valida los datos del cliente
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()) && TxtCedula.Text.Trim()
                != TxtCedula.Tag.ToString() && !string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtDireccion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                 CbActivo.Checked)
            {
                R = true;
            }

            return R;
        }

        //Boton que agrega los datos del cliente 
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo cliente?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    Cliente MiCliente = new Cliente();

                    MiCliente.Cedula = TxtCedula.Text.Trim();
                    MiCliente.Nombre = TxtNombre.Text.Trim();

                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();
                    MiCliente.Email = TxtEmail.Text.Trim();

                    bool CedulaExiste = MiCliente.ConsultarPorCedula();

                    bool EmailExiste = MiCliente.ConsultarPorEmail();

                    if (!CedulaExiste && !EmailExiste)
                    {
                        //agrega el cliente
                        if (MiCliente.Agregar())
                        {
                            MessageBox.Show("Cliente agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaClientes(true);
                            ActivarBtnAgregar();

                        }


                    }
                    else
                    {
                        //valida que los datos ya existen
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

        //boton que modifica los  datos del cliente
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //valida los datos del cliente
            if (ValidarDatosRequeridos())
            {
                 Cliente MiCliente = new Cliente();

                MiCliente.IDCliente = Convert.ToInt32(TxtCodigo.Text.Trim());

                MiCliente.Cedula = TxtCedula.Text.Trim();
                MiCliente.Nombre = TxtNombre.Text.Trim();

                MiCliente.Telefono = TxtTelefono.Text.Trim();
                MiCliente.Direccion = TxtDireccion.Text.Trim();
                MiCliente.Email = TxtEmail.Text.Trim();

                    //consulta al cliente por su ID
                    if (MiCliente.ConsultarPorID())
                    {
                         //Edita al cliente
                        if (MiCliente.Editar())
                        {
                            MessageBox.Show("Cliente modificado correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            LlenarListaClientes(CbVerClientesActivos.Checked);
                            ActivarBtnAgregar();
                        }
                    }
                }
            
        }

        //Checkbox que muestra los cliente activos
        private void CbVerClientesActivos_CheckedChanged(object sender, EventArgs e)
        {
            LlenarListaClientes(CbVerClientesActivos.Checked);

            if (!CbVerClientesActivos.Checked)
            {

                BtnEliminar.Text = "Activar";

            }
            else
            {

                BtnEliminar.Text = "Eliminar";

            }
        }

        //Boton que cierra el formulario
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton que limpia los datos del cliente
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarBtnAgregar();
            DgvListaClientes.ClearSelection();
        }

        //Evento que selecciona una fila
        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //valida si se ha seleccionado una fila en el datagridview
            if (DgvListaClientes.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                int IdCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

                MiClienteLocal = new Cliente();

                MiClienteLocal = MiClienteLocal.Consultar(IdCliente);

                TxtCodigo.Text = MiClienteLocal.IDCliente.ToString();
                TxtCedula.Text = MiClienteLocal.Cedula;
                TxtNombre.Text = MiClienteLocal.Nombre;

                TxtTelefono.Text = MiClienteLocal.Telefono;
                TxtDireccion.Text = MiClienteLocal.Direccion;

                TxtEmail.Text = MiClienteLocal.Email;

                CbActivo.Checked = MiClienteLocal.Activo;

                ActivarBtnModificarYEliminar();
            }
        }

    }
}
