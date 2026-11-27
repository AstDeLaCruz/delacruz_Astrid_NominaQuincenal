using System.Globalization;

namespace NominaQuincenal
{
    public partial class Form1 : Form
    {
        const int HORAS_REGULARES = 88;
        const double RECARGO_EXTRA = 1.35;
        const double INCENTIVO = 1500;
        const double AFP = 0.0287;
        const double SFS = 0.0304;
        const double TARIFA_AUXILIAR = 180;
        const double TARIFA_TECNICO = 250;
        const double TARIFA_SUPERVISOR = 350;
        const double TARIFA_GERENTE = 500;
        const int HORAS_MINIMAS = 1;
        const int HORAS_MAXIMAS = 120;
        int cantidadEmpleados = 0;
        double totalBruto = 0;
        double totalDeducciones = 0;
        double totalNeto = 0;

        private void LimpiarCampos()
        {
            txtEmpleado.Clear();
            txtHoras.Clear();
            rdbFijo.Checked = true;
            rdbTemporal.Checked = false;
            cmbCargo.SelectedIndex = -1;
            chkTransporte.Checked = false;
            txtEmpleado.Focus();
        }


        private void PonerResumenEnCero()
        {
            lblEmmpleados.Text = "0";
            lblBruto.Text = "RD$ 0.00";
            lblDeducciones.Text = "RD$ 0.00";
            lblNeto.Text = "RD$ 0.00";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtEmpleado.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el nombre del empleado.");
                txtEmpleado.Focus();
                return;
            }

            if (rdbFijo.Checked == false && rdbTemporal.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de contrato.");
                return;
            }


            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo.");
                return;
            }

            int horas;
            if (int.TryParse(txtHoras.Text, out horas) == false || horas < HORAS_MINIMAS || horas > HORAS_MAXIMAS)
            {
                MessageBox.Show("Las horas deben ser un número entero de " + HORAS_MINIMAS + " a " + HORAS_MAXIMAS + ".");
                txtHoras.Focus();
                return;
            }

            double tarifa = 0;
            if (cmbCargo.Text == "Auxiliar")
            {
                tarifa = TARIFA_AUXILIAR;
            }
            else if (cmbCargo.Text == "Técnico")
            {
                tarifa = TARIFA_TECNICO;
            }
            else if (cmbCargo.Text == "Supervisor")
            {
                tarifa = TARIFA_SUPERVISOR;
            }
            else if (cmbCargo.Text == "Gerente")
            {
                tarifa = TARIFA_GERENTE;
            }
            int horasNormales = horas;
            int horasExtra = 0;
            if (horas > HORAS_REGULARES)
            {
                horasNormales = HORAS_REGULARES;
                horasExtra = horas - HORAS_REGULARES;
            }


            double salarioRegular = horasNormales * tarifa;
            double pagoExtra = horasExtra * tarifa * RECARGO_EXTRA;

            double incentivo = 0;
            if (chkTransporte.Checked == true)
            {
                incentivo = INCENTIVO;
            }

            double bruto = salarioRegular + pagoExtra + incentivo;

            double deducciones = 0;
            if (rdbFijo.Checked == true)
            {
                deducciones = (salarioRegular + pagoExtra) * (AFP + SFS);
            }

            double neto = bruto - deducciones;

            lstNomina.Items.Add(txtEmpleado.Text.Trim() + " · " + cmbCargo.Text + " · RD$ " + neto.ToString("N2"));


            cantidadEmpleados = cantidadEmpleados + 1;
            totalBruto = totalBruto + bruto;
            totalDeducciones = totalDeducciones + deducciones;
            totalNeto = totalNeto + neto;

            LimpiarCampos();


        }





        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lstNomina.Items.Clear();

            cantidadEmpleados = 0;
            totalBruto = 0;
            totalDeducciones = 0;
            totalNeto = 0;

            PonerResumenEnCero();
        }


        private void lstNomina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

          private void Form1_Load(object sender, EventArgs e)
        {
            
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

           
            cmbCargo.Items.Add("Auxiliar");
            cmbCargo.Items.Add("Técnico");
            cmbCargo.Items.Add("Supervisor");
            cmbCargo.Items.Add("Gerente");

            PonerResumenEnCero();
        }
        

        private void btnResumen_Click(object sender, EventArgs e)
        {

            if (cantidadEmpleados == 0)
            {
                MessageBox.Show("No hay empleados registrados.");
                return;
            }

            lblEmmpleados.Text = cantidadEmpleados.ToString();
            lblBruto.Text = "RD$ " + totalBruto.ToString("N2");
            lblDeducciones.Text = "RD$ " + totalDeducciones.ToString("N2");
            lblNeto.Text = "RD$ " + totalNeto.ToString("N2");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}


