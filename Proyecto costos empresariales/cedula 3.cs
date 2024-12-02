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
    public partial class cedula_3 : Form
    {
        public cedula_3()
        {
            InitializeComponent();
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
                // Datos ingresados
                double volumenInventarioFinal = DatosCostos.VolumenProducido - DatosCostos.VolumenTerminado;
                double gradoAvanceMP = DatosCostos.GradoAvanceMP;
                double gradoAvanceMO = DatosCostos.GradoAvanceMO;
                double gradoAvanceCI = DatosCostos.GradoAvanceCI;

                double costoUnitarioMP = DatosCostos.MateriaPrima / DatosCostos.VolumenProducido;
                double costoUnitarioMO = DatosCostos.ManoObra / DatosCostos.VolumenProducido;
                double costoUnitarioCI = DatosCostos.CostosIndirectos / DatosCostos.VolumenProducido;

                // Cálculos de costos totales
                double costoTotalMP = volumenInventarioFinal * costoUnitarioMP * gradoAvanceMP;
                double costoTotalMO = volumenInventarioFinal * costoUnitarioMO * gradoAvanceMO;
                double costoTotalCI = volumenInventarioFinal * costoUnitarioCI * gradoAvanceCI;

                double costoInventarioFinal = costoTotalMP + costoTotalMO + costoTotalCI;

                // Mostrar resultados
                txtCostoTotalMPInventario.Text = costoTotalMP.ToString("N2");
                txtCostoTotalMOInventario.Text = costoTotalMO.ToString("N2");
                txtCostoTotalCIInventario.Text = costoTotalCI.ToString("N2");
                txtCostoInventarioFinal.Text = costoInventarioFinal.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la Cédula 3: " + ex.Message);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Validar que el valor de txtTotalInventarioFinal es válido
            if (double.TryParse(txtCostoInventarioFinal.Text, out double inventarioFinal))
            {
                DatosCostos.TotalInventarioFinal = inventarioFinal;
                cedula_4 cedula4 = new cedula_4();
                cedula4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al obtener el costo del inventario final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
