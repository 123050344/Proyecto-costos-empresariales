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
    public partial class cedula_2 : Form
    {
        public cedula_2()
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
                double volumenTerminado = DatosCostos.VolumenTerminado;
                double volumenProducido = DatosCostos.VolumenProducido;
                double costoUnitarioMP = DatosCostos.MateriaPrima / volumenProducido;
                double costoUnitarioMO = DatosCostos.ManoObra / volumenProducido;
                double costoUnitarioCI = DatosCostos.CostosIndirectos / volumenProducido;

                // Cálculos de costos totales para producción terminada
                double costoTotalMP = costoUnitarioMP * volumenTerminado;
                double costoTotalMO = costoUnitarioMO * volumenTerminado;
                double costoTotalCI = costoUnitarioCI * volumenTerminado;

                double costoProduccionTerminada = costoTotalMP + costoTotalMO + costoTotalCI;

                // Mostrar resultados
                txtCostoTotalMP.Text = costoTotalMP.ToString("N2");
                txtCostoTotalMO.Text = costoTotalMO.ToString("N2");
                txtCostoTotalCI.Text = costoTotalCI.ToString("N2");
                txtCostoProduccionTerminada.Text = costoProduccionTerminada.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la Cédula 2: " + ex.Message);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Validar que el valor de txtTotalProduccionTerminada es válido
            if (double.TryParse(txtCostoProduccionTerminada.Text, out double produccionTerminada))
            {
                DatosCostos.TotalProduccionTerminada = produccionTerminada;
                cedula_3 cedula3 = new cedula_3();
                cedula3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al obtener el costo de producción terminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

