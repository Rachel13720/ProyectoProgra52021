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
    public partial class FrmVentasDetalleItemGestion : Form
    {
        //Variables gloables
        public DataTable ListaProductos { get; set; }

        public DataTable ListaProductosConFiltro { get; set; }

        public LogicaProyecto.Producto MiProducto { get; set; }

        public FrmVentasDetalleItemGestion()
        {
            InitializeComponent();
            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();
            MiProducto = new LogicaProyecto.Producto();
        }

        //Se agregan los datos de la venta
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Se evalua que haya una fila seleccionada en la lista y la cantidad sea mayor a cero
            if (DgvListaItems.SelectedRows.Count == 1 && nudCantidad.Value > 0)
            {
                //se valida que exista el producto y el que el checbox este seleccionado

                if (ValidarExistenciaProducto() && CboxSumar.Checked)
                {

                    DataRow MiFila = Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.NewRow();

                    foreach (DataRow row in Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.Rows)
                    {
                        if (Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                            Convert.ToInt32(row["IDProducto"].ToString()))
                        {
                            MiFila["CantidadVendida"] = Convert.ToDecimal(row["CantidadVendida"]) + nudCantidad.Value;

                            this.DialogResult = DialogResult.OK;
                        }

                    }
                } //se valida que no exista el producto y el checbox no este seleccionado, o que no exista el producto y el checkbox este seleccionado
                else if (!ValidarExistenciaProducto() && !CboxSumar.Checked || !ValidarExistenciaProducto() && CboxSumar.Checked)
                {
                    DataRow NuevaFila = Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.NewRow();

                    NuevaFila["IDProducto"] = Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value);

                    NuevaFila["Nombre"] = DgvListaItems.SelectedRows[0].Cells["CNombre"].Value.ToString();

                    NuevaFila["PrecioVenta"] = DgvListaItems.SelectedRows[0].Cells["CPrecio"].Value.ToString();

                    NuevaFila["CantidadVendida"] = nudCantidad.Value;

                    Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.Rows.Add(NuevaFila);

                    this.DialogResult = DialogResult.OK;
                }//se valida que existe el producto y el checkbox no este seleccionado
                else if (ValidarExistenciaProducto() && !CboxSumar.Checked)
                {
                    MessageBox.Show("Ya existe, marcar el checkbox", ":)", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", ":)", MessageBoxButtons.OK);
            }
           

        }

        //se validan los datos de de la lista y que el numeric sea mayor a cero
        private bool ValidarDatos()
        {
            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 &&
                nudCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                if (nudCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero o negativa", "Error de validacion", MessageBoxButtons.OK);
                }
            }



            return R;
        }

        //Se cancela el formulario 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //llena los datos de la lista
        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnDetalle();

            DgvListaItems.DataSource = ListaProductos;

            DgvListaItems.ClearSelection();
        }

        //Carga los datos de la lista
        private void FrmVentasDetalleItemGestion_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        //se valida la existencia del producto con su Id
        private bool ValidarExistenciaProducto()
        {
            bool R = false;

            foreach (DataRow row in Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.Rows)
            {
                if (Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                    Convert.ToInt32(row["IDProducto"].ToString()))
                {
                    R = true;
                }

            }

            return R;

        }

    }
}
