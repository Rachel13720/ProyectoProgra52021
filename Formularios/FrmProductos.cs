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
    public partial class FrmProductos : Form
    {
        //variables globales
        public DataTable ListaProductos { get; set; }

        private Producto MiProductoLocal { get; set; }

        public FrmProductos()
        {
            InitializeComponent();

            MiProductoLocal = new Producto();
        }

        //boton que agrega los datos del producto
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Se valida que todos los campos tengan informacion
            if (ValidarDatosRequeridos())
            {
                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo producto?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    Producto Miproducto = new Producto();

                    Miproducto.Nombre = TxtNombre.Text.Trim();
                    Miproducto.CantidadStock = Convert.ToInt32(TxtCantidadStock.Text.Trim());
                    Miproducto.Precio = Convert.ToInt32(TxtPrecio.Text.Trim());
                    Miproducto.Categoria.IDProductoCategoria = Convert.ToInt32(CboxCategoria.SelectedValue);

                    //se agrega el producto 
                    if (Miproducto.Agregar())
                        {
                            MessageBox.Show("Producto agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaProductos();
                            ActivarBotonAgregar();

                    }


                }

            }
                
            
        }

        //valida los datos
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) && 
                !string.IsNullOrEmpty(TxtCantidadStock.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                 CboxCategoria.SelectedIndex > -1)
            {

                R = true;

            }

            return R;
        }

        //Selecciona la fila, esta ya sea para eliminarla o editarla
        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProductos.SelectedRows.Count == 1)
            {

                DataGridViewRow MiFila = DgvListaProductos.SelectedRows[0];


                TxtCodigo.Text = Convert.ToString(MiFila.Cells["IDProducto"].Value);

                TxtNombre.Text = Convert.ToString(MiFila.Cells["Nombre"].Value);
                TxtCantidadStock.Text = Convert.ToString(MiFila.Cells["CantidadStock"].Value);
                TxtPrecio.Text = Convert.ToString(MiFila.Cells["Precio"].Value);

                foreach(DataRowView data in CboxCategoria.Items)
                {
                    if(data.Row[1].ToString().Equals(MiFila.Cells["Categoria"].Value))
                    {
                        CboxCategoria.SelectedValue = data.Row[0];
                    }
                }

                ActivarModificarYEliminar();
            }
        }

        //Llena los datos de la lista
        private void LlenarListaProductos()
        {
            ListaProductos = MiProductoLocal.ListarEnDetalle();

            DgvListaProductos.DataSource = ListaProductos;


        }

        //carga los datos de la categoria
        private void CargarDatosCategoria()
        {
            ProductoCategoria MiCategoria = new ProductoCategoria();

            DataTable datos = new DataTable();

            datos = MiCategoria.Listar();

            CboxCategoria.ValueMember = "ID";

            CboxCategoria.DisplayMember = "Categoria";

            CboxCategoria.DataSource = datos;

            CboxCategoria.SelectedIndex = -1;
        }


        //limpia el formulario
        private void LimpiarFormulario()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtCodigo.Clear();
            TxtPrecio.Clear();

        }

        //activa solo los botones de modificar y eliminar
        private void ActivarModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCodigo.Enabled = false;
        }

        //activa solo el boton agregar
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCodigo.Enabled = true;
        }

        //sale del formulario
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Herramienta que permite que el texto sea en mayusculas
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);
        }

        //Carga el formulario y sus datos
        private void FrmProductos_Load(object sender, EventArgs e)
        {

            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            CargarDatosCategoria();

            LlenarListaProductos();

            LimpiarFormulario();

            ActivarBotonAgregar();
        }


        //Boton que modifica los datos
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //valida los datos existentes y los modifica
            if (ValidarDatosRequeridos())
            {
                Producto MiProducto = new Producto();

                MiProducto.IDProducto = Convert.ToInt32(TxtCodigo.Text.Trim());
                MiProducto.Nombre = TxtNombre.Text.Trim();
                MiProducto.CantidadStock = Convert.ToDecimal(TxtCantidadStock.Text.Trim());
                MiProducto.Precio = Convert.ToDecimal(TxtPrecio.Text.Trim());
                MiProducto.Categoria.IDProductoCategoria = Convert.ToInt32(CboxCategoria.SelectedValue);

                if (MiProducto.ConsultarPorID())
                {
                    //se editan los datos
                    if (MiProducto.Editar())
                    {
                        MessageBox.Show("Producto modificado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                        LlenarListaProductos();
                    }
                }
            }
           
        }

        //Boton que elimina los datos
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Producto MiProducto = new Producto();

                MiProducto.IDProducto = Convert.ToInt32(TxtCodigo.Text.Trim());

                if (MiProducto.ConsultarPorID())
                {
                    //desactiva los datos 
                    if (MiProducto.Desactivar())
                    {
                        MessageBox.Show("Producto eliminado correctamente", ":)", MessageBoxButtons.OK);
                        LimpiarFormulario();
                        ActivarBotonAgregar();
                        LlenarListaProductos();
                    }
                }
            }
            
        }

    }
}
