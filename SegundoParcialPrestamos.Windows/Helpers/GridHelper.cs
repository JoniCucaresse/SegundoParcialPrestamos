namespace SegundoParcialPrestamos.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(r, dgv);
            }
        }

        private static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            //switch (obj)
            //{
            //    case Prestamo prestamo:
            //        r.Cells[0].Value = prestamo.PrestamoNro;
            //        r.Cells[1].Value = prestamo.Persona!.ToString();
            //        r.Cells[2].Value = prestamo.FechaInicio.ToShortDateString();
            //        r.Cells[3].Value = prestamo.GetType() == typeof(PrestamoDolares) ? "Dólares" : "Pesos";
            //        r.Cells[4].Value = prestamo.Monto.ToString("C2");
            //        r.Cells[5].Value = prestamo.Plazo.GetHashCode();
            //        r.Cells[6].Value = (prestamo.TasaInteres / 100).ToString("P2");
            //        break;
            //    case Cuota cuota:
            //        r.Cells[0].Value = cuota.Numero;
            //        r.Cells[1].Value = cuota.FechaVencimiento.ToShortDateString();
            //        r.Cells[2].Value = cuota.MontoTotal;
            //        r.Cells[3].Value = cuota.Capital;
            //        r.Cells[4].Value = cuota.Interes;
            //        break;

            //}
            r.Tag = obj;
        }

    }
}
