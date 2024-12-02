using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_costos_empresariales
{
    public partial class cedula_4 : Form
    {
        public cedula_4()
        {
            InitializeComponent();
            txtMostrarProduccionTerminada.Text = DatosCostos.TotalProduccionTerminada.ToString("N2");
            txtMostrarInventarioFinal.Text = DatosCostos.TotalInventarioFinal.ToString("N2");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Mostrar el Form1 existente
            Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
            formPrincipal.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los valores desde la clase DatosCostos
                double costoProduccionTerminada = DatosCostos.TotalProduccionTerminada;
                double costoInventarioFinal = DatosCostos.TotalInventarioFinal;

                // Mostrar los valores en las cajas de texto adicionales
                txtMostrarProduccionTerminada.Text = costoProduccionTerminada.ToString("N2");
                txtMostrarInventarioFinal.Text = costoInventarioFinal.ToString("N2");

                // Calcular el Gran Total
                double granTotal = costoProduccionTerminada + costoInventarioFinal;

                // Mostrar el Gran Total en la caja de texto correspondiente
                txtGranTotal.Text = granTotal.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el Gran Total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra todos los formularios abiertos y termina la aplicación
            Application.Exit();
        }
    }
}
