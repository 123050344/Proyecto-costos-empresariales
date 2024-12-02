namespace Proyecto_costos_empresariales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar y guardar los datos ingresados
            try
            {
                DatosCostos.MateriaPrima = double.Parse(txtMateriaPrima.Text);
                DatosCostos.ManoObra = double.Parse(txtManoObra.Text);
                DatosCostos.CostosIndirectos = double.Parse(txtCostosIndirectos.Text);
                DatosCostos.VolumenProducido = double.Parse(txtVolumenProducido.Text);
                DatosCostos.VolumenTerminado = double.Parse(txtVolumenTerminado.Text);
                DatosCostos.GradoAvanceMP = double.Parse(txtGradoAvanceMP.Text) / 100;
                DatosCostos.GradoAvanceMO = double.Parse(txtGradoAvanceMO.Text) / 100;
                DatosCostos.GradoAvanceCI = double.Parse(txtGradoAvanceCI.Text) / 100;

                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private void btnCédula1_Click(object sender, EventArgs e)
        {
            cedula_1 formCedula1 = new cedula_1();
            formCedula1.Show();
        }

        private void btnCédula2_Click(object sender, EventArgs e)
        {
            cedula_2 formCedula2 = new cedula_2();
            formCedula2.Show();
        }

        private void btnCédula3_Click(object sender, EventArgs e)
        {
            cedula_3 formCedula3 = new cedula_3();
            formCedula3.Show();
        }

        private void btnCédula4_Click(object sender, EventArgs e)
        {
            cedula_4 formCedula4 = new cedula_4();
            formCedula4.Show();
        }
    }
}
