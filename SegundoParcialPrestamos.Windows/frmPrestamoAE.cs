using SegundoParcialPrestamos.Entidades;
using SegundoParcialPrestamos.Windows.Helpers;

namespace SegundoParcialPrestamos.Windows
{
    public partial class frmPrestamoAE : Form
    {
        public Tuple<bool, string> PrestamoCreado { get; private set; }
        public frmPrestamoAE()
        {
            InitializeComponent();
            CargarPlazos();
        }
        private void CargarPlazos()
        {
            cboPlazos.Items.Clear();
            cboPlazos.Items.Add(Plazo.DoceMeses);
            cboPlazos.Items.Add(Plazo.VeinticuatroMeses);
            cboPlazos.Items.Add(Plazo.TreintaYSeisMeses);
            cboPlazos.Items.Add(Plazo.CuarentaYOchoMeses);
        }

        //private void rbtDolares_CheckedChanged(object sender, EventArgs e)
        //{
        //    tipoPrestamo = TipoPrestamo.Dolares;
        //    plazosTasas = PrestamoDolares.TasasPorPlazo;
        //    cboPlazos.SelectedIndex = 0;
        //    MostrarTasaInteres();
        //}

        //private void rbtPesos_CheckedChanged(object sender, EventArgs e)
        //{
        //    tipoPrestamo = TipoPrestamo.Pesos;
        //    plazosTasas = PrestamoPesos.TasasPorPlazo;
        //    cboPlazos.SelectedIndex = 0;
        //    MostrarTasaInteres();


        //}

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (Persona.ValidarDni(txtDni.Text))
            {
                MessageBox.Show("DNI válido");
            }
            else
            {
                MessageBox.Show("DNI no válido");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var persona = new Persona
                {
                    Nombres = txtNombres.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDni.Text
                };

                Plazo plazo = (Plazo)cboPlazos.SelectedItem;
                decimal monto = decimal.Parse(txtMonto.Text);
                Prestamo prestamo = null;

                if (rbtDolares.Checked)
                {
                    prestamo = new PrestamoDolares(persona, monto, plazo, DateTime.Now);
                }
                else if (rbtPesos.Checked)
                {
                    prestamo = new PrestamoPesos(persona, monto, plazo, DateTime.Now);
                }
                else
                {
                    MessageBox.Show("Tipo de préstamo no válido");
                    return;
                }

                prestamo.ConfigurarTasaIntereses();

                var resultado = entidad.AgregarPrestamo(prestamo);
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
            }
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrEmpty(txtNombres.Text) &&
                   !string.IsNullOrEmpty(txtApellido.Text) &&
                   !string.IsNullOrEmpty(txtDni.Text) &&
                   cboPlazos.SelectedItem != null;
        }
    }
}
