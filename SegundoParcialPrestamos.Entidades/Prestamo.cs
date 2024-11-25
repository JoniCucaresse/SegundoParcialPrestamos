using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public abstract class Prestamo
    {
        public Dictionary<Plazo, decimal> TasasPorPlazo { get; set; }

        private TipoPrestamo tipoPrestamo;

        public TipoPrestamo TipoPrestamo
        {
            get { return tipoPrestamo; }
            set { tipoPrestamo = value; }
        }


        private Persona persona;
        public Persona Persona 
        { get => persona; set => persona = value; }

        private Plazo plazo;

        public Plazo Plazo 
        { get => plazo; set => plazo = value; }


        private DateTime fechaInicio;

		public DateTime FechaInicio
		{
			get { return fechaInicio; }
			set { fechaInicio = value; }
		}

        private decimal monto;

        public decimal Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        private Guid prestamoNro;

        public Guid PrestamoNro
        {
            get { return prestamoNro; }
            set { prestamoNro = value; }
        }

        private decimal tasaInteres;

        public decimal TasaInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }



        public Prestamo()
        {
            
        }

        public Prestamo(Persona persona, decimal monto, Plazo plazo, DateTime fechaInicio)
        {
            Persona = persona;
            Monto = monto;
            Plazo = plazo;
            FechaInicio=fechaInicio;
            PrestamoNro=Guid.NewGuid();
            TasasPorPlazo = new Dictionary<Plazo, decimal>();

        }

        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Tipo de Prestamo: {TipoPrestamo}");
            sb.AppendLine($"Fecha: {FechaInicio}");
            sb.AppendLine($"Monto: {Monto}");
            sb.AppendLine($"Intereses: {TasaInteres}");
            sb.AppendLine($"Plazo: {Plazo}");
            return sb.ToString();
        }

        public virtual void ConfigurarTasaIntereses()
        {
            if (TasasPorPlazo.ContainsKey(Plazo))
            {
                TasaInteres = TasasPorPlazo[Plazo];
            }
            else
            {
                throw new InvalidOperationException("No hay tasa configurada para este plazo.");
            }
        }

        public List<decimal> CalcularCuotas(int numeroCuotas)
        {
            List<decimal> cuotas = new List<decimal>();
            decimal cuotaMensual = Monto * (1 + TasaInteres / 100) / numeroCuotas;

            for (int i = 0; i < numeroCuotas; i++)
            {
                cuotas.Add(cuotaMensual);
            }

            return cuotas;
        }
    }
}
