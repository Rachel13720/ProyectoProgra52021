using CrystalDecisions.CrystalReports.Engine;
using LogicaProyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra52021.Formularios
{
    public partial class FrmVentasGestion : Form
    {
        public Venta MiVentaLocal { get; set; }

        public DataTable DtListaProductos { get; set; }

        public FrmVentasGestion()
        {
            InitializeComponent();

            MiVentaLocal = new Venta();

            DtListaProductos = new DataTable();
        }

        private void FrmVentasGestion_Load(object sender, EventArgs e)
        {

            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LblUsuarioRegistra.Text = "Venta registrada por " + Locales.ObjetosGlobales.MiUsuarioGlobal.Nombre;

            CargarDatosCliente();

            Limpiar();

        }

        private void Limpiar()
        {
            DtpFecha.Value = DateTime.Now.Date;

            TxtNumeroFactura.Clear();
            CboxClientes.SelectedIndex = -1;
            TxtComentario.Clear();

            //cargar el esquema que debe tener el datatable
            //este esquema no tiene datos, solamente asigna la estructua adecuada al datatable
            //segun el SP proporcionado

            DtListaProductos = MiVentaLocal.AsignarEsquemaDetalle();

            dgvListaItems.DataSource = DtListaProductos;


        }

        private void CargarDatosCliente()
        {
            LogicaProyecto.Cliente ObjCliente = new LogicaProyecto.Cliente();

            DataTable Datos = new DataTable();

            Datos = ObjCliente.Listar();

            CboxClientes.ValueMember = "IDCliente";
            CboxClientes.DisplayMember = "Nombre";

            CboxClientes.DataSource = Datos;

            CboxClientes.SelectedIndex = -1;

        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            //TODO: Vefificar si es necesario que el form de busqueda este en globales.

            Form FormBuscarItem = new Formularios.FrmVentasDetalleItemGestion();

            //el form de busqueda deberia mostrarse en modo dialog para que este form 
            //espere una respuesta del form de busqueda

            DialogResult Resp = FormBuscarItem.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                //indica que se ha seleccionado un item en el form de busqueda
                //TODO: Se debe realizar una totalizacion de las lineas

                dgvListaItems.DataSource = DtListaProductos;

                TxtTotalVenta.Text = string.Format("{0:C2}", Totalizar());

            }

        }

        //metodo que totaliza la cantidad 
        private decimal Totalizar()
        {
            decimal R = 0;

            if (DtListaProductos.Rows.Count > 0)
            {
                //valida que existan datos en la lista
                foreach (DataRow item in DtListaProductos.Rows)
                {
                    R += Convert.ToDecimal(item["CantidadVendida"]) * Convert.ToDecimal(item["PrecioVenta"]);

                }

            }


            return R;

        }

        //valida los datos, para realizar la venta
        private bool ValidarVenta()
        {

            bool R = false;

            if (DtpFecha.Value.Date <= DateTime.Now.Date
                && CboxClientes.SelectedIndex > -1 &&
                !string.IsNullOrEmpty(TxtNumeroFactura.Text.Trim()) &&
                DtListaProductos.Rows.Count > 0)
            {
                R = true;

            }
            else
            { //valida que la fecha no sea mayor a la actual
                if (DtpFecha.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show(@"La fecha de la factura no puede ser superior a la fecha actual", "Error de validacion", MessageBoxButtons.OK);

                    return false;
                }

                //Hace demas validaciones
                if (ValidarVenta ())
                {

                    MiVentaLocal.Fecha = DtpFecha.Value.Date;
                    MiVentaLocal.MiCliente.IDCliente = Convert.ToInt32(CboxClientes.SelectedIndex);
                    MiVentaLocal.UsuarioRegistra.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                    MiVentaLocal.NumeroFactura = TxtNumeroFactura.Text.Trim();
                    MiVentaLocal.Comentario = TxtComentario.Text.Trim();

                    LlenarDetallesDeVenta();

                    //Se agrega la venta y se realiza el reporte
                    if (MiVentaLocal.Agregar())
                    {
                        MessageBox.Show("La venta se registro correctamente", ":)", MessageBoxButtons.OK);

                        ReportDocument MiReporteVenta = new ReportDocument();

                        Limpiar();

                    }




                }

            }


            return R;


        }

        //Llena los datos de lista de detalles de la venta
        private void LlenarDetallesDeVenta()
        {
            //Valida las filas de la lista
            foreach (DataRow fila in DtListaProductos.Rows)
            {
                LogicaProyecto.VentaDetalle detalle = new LogicaProyecto.VentaDetalle();

                detalle.MiProducto.IDProducto = Convert.ToInt32(fila["IDProducto"]);
                detalle.CantidadVendida = Convert.ToDecimal(fila["CantidadVendida"]);
                detalle.PrecioVenta = Convert.ToDecimal(fila["PrecioVenta"]);

                detalle.MiProducto.Nombre = fila["Nombre"].ToString();

                MiVentaLocal.ListaDetalles.Add(detalle);

            }



        }

        //Boton que agrega los datos de la venta a la lista
        private void BtnAgregarItem_Click_1(object sender, EventArgs e)
        {
            Form FormBuscarItem = new Formularios.FrmVentasDetalleItemGestion();

            DialogResult Resp = FormBuscarItem.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                dgvListaItems.DataSource = DtListaProductos;

                TxtTotalVenta.Text = string.Format("{0:C2}", Totalizar());

            }

        }

        //Boton que crea una Venta
        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            //Valida los datos de la venta
            if (ValidarVenta())
            {
                MiVentaLocal.Fecha = DtpFecha.Value.Date;
                MiVentaLocal.MiCliente.IDCliente = Convert.ToInt32(CboxClientes.SelectedValue);
                MiVentaLocal.UsuarioRegistra.IDUsuario = Locales.ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

                MiVentaLocal.NumeroFactura = TxtNumeroFactura.Text.Trim();
                MiVentaLocal.Comentario = TxtComentario.Text.Trim();

                LlenarDetallesDeVenta();

                //Agrega la venta y permite que se imprima el reporte
                if (MiVentaLocal.Agregar())
                {
                    MessageBox.Show("La venta se registro correctamente", ":)", MessageBoxButtons.OK);

                    ReportDocument MiReporteVenta = new ReportDocument();

                    MiReporteVenta = new Reportes.VentaReporte();

                    MiReporteVenta = MiVentaLocal.Imprimir(MiReporteVenta);

                    FrmVisualizadorReportes MiFormCRV = new FrmVisualizadorReportes();

                    MiFormCRV.CrvVisualizador.ReportSource = MiReporteVenta;
                    MiFormCRV.Show();

                    //Se visualiza el reporte
                    MiFormCRV.CrvVisualizador.Zoom(1);


                    Limpiar();
                }
            }
        }

        //Boton que modifica los datos de la venta
        private void BtnModicarfItem_Click(object sender, EventArgs e)
        {
            Form FormCambio = new Formularios.FrmCambio();

            DialogResult Resp = FormCambio.ShowDialog();

            if (Resp == DialogResult.OK)
            {
                dgvListaItems.DataSource = DtListaProductos;
            }
        }

        //Boton que elimina los datos de la venta
        private void BtnEliminarItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DtListaProductos.Rows.Count; i++)
            {
                DataRow row = DtListaProductos.Rows[i];

                if (Convert.ToInt32(dgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                    Convert.ToInt32(row["IDProducto"].ToString()))
                {
                    row.Delete();
                }

            }
            DtListaProductos.AcceptChanges();
            dgvListaItems.DataSource = DtListaProductos;


            TxtTotalVenta.Text = string.Format("{0:C2}", Totalizar());

        }

    }
}
