using SegundoParcialPrestamos.Datos;
using SegundoParcialPrestamos.Entidades;

namespace SegundoParcialPrestamos.Windows
{
    public partial class frmPrestamos : Form
    {
        public EntidadFinanciera entidad;
        public frmPrestamos()
        {
            InitializeComponent();
            entidad = EntidadFinanciera.CrearInstancia("Banco La Fortuna");
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPrestamoAE formPrestamo = new frmPrestamoAE();

            if (formPrestamo.ShowDialog() == DialogResult.OK)
            {
                var resultado = formPrestamo.PrestamoCreado;

                if (resultado.Item1)
                {
                    MessageBox.Show($"Préstamo agregado: {resultado.Item2}");
                    ActualizarGrillaYCantidad();
                }
                else
                {
                    MessageBox.Show($"Error: {resultado.Item2}");
                }
            }
        }

        private void ActualizarGrillaYCantidad()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = entidad.GetPrestamos(TipoPrestamo.Todos); 

            txtCantidad.Text = $"Cantidad de préstamos: {entidad.GetCantidad(TipoPrestamo.Todos)}";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
