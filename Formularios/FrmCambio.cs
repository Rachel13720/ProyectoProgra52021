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
    public partial class FrmCambio : Form
    {
        public FrmCambio()
        {
            InitializeComponent();
        }
        //Boton aceptar que envia la cantidad a la lista
        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in Locales.ObjetosGlobales.MiFromGestionCompras.DtListaProductos.Rows)
            {
                if (Convert.ToInt32(Locales.ObjetosGlobales.MiFromGestionCompras.dgvListaItems.SelectedRows[0].Cells["CIDProducto"].Value) ==
                    Convert.ToInt32(row["IDProducto"].ToString()))
                {
                    row["CantidadVendida"] = NudCantidad.Value;

                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        //Boton que cierra el formulario
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
