using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class PrestamoPesos: Prestamo
    {
        public PrestamoPesos():base()
        {
            
        }
        public PrestamoPesos(Persona persona, decimal monto, Plazo plazo, DateTime fechaInicio)
            : base(persona, monto, plazo, fechaInicio)
        {
            TasasPorPlazo.Add(Plazo.DoceMeses, 25.0m);
            TasasPorPlazo.Add(Plazo.VeinticuatroMeses, 30.0m);
            TasasPorPlazo.Add(Plazo.TreintaYSeisMeses, 35.0m);
            TasasPorPlazo.Add(Plazo.CuarentaYOchoMeses, 40.0m);
        }

        public override void ConfigurarTasaIntereses()
        {
            if (TasasPorPlazo.ContainsKey(Plazo))
            {
                TasaInteres = TasasPorPlazo[Plazo];
            }
            else
            {
                throw new InvalidOperationException("No hay tasa configurada para este plazo en Pesos.");
            }
        }
    }
}
