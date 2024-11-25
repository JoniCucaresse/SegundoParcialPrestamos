using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class PrestamoDolares: Prestamo
    {
        public PrestamoDolares():base()
        {
            
        }

        public PrestamoDolares(Persona persona, decimal monto, Plazo plazo, DateTime fechaInicio)
            : base(persona, monto, plazo, fechaInicio)
        {

            TasasPorPlazo.Add(Plazo.DoceMeses, 5.0m);
            TasasPorPlazo.Add(Plazo.VeinticuatroMeses, 6.0m);
            TasasPorPlazo.Add(Plazo.TreintaYSeisMeses, 7.0m);
            TasasPorPlazo.Add(Plazo.CuarentaYOchoMeses, 8.0m);
        }


        public override void ConfigurarTasaIntereses()
        {
            if (TasasPorPlazo.ContainsKey(Plazo))
            {
                TasaInteres = TasasPorPlazo[Plazo];
            }
            else
            {
                throw new InvalidOperationException("No hay tasa configurada para este plazo en Dólares.");
            }
        }
    }
}
