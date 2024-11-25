using SegundoParcialPrestamos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Datos
{
    public class EntidadFinanciera
    {
        private static EntidadFinanciera entidad;
        private List<Prestamo> prestamos;
        private string nombre;

        public static EntidadFinanciera CrearInstancia(string nombre)
        {
            return entidad = new EntidadFinanciera(nombre);
        }

        private EntidadFinanciera(string nombre)
        {
            this.nombre = nombre;
            prestamos = new List<Prestamo>();
        }

        public (bool, string) AgregarPrestamo(Prestamo prestamo)
        {
            if (ExistePrestamo(prestamo))
            {
                return (false, "El préstamo ya existe con los mismos datos.");
            }
            else
            {
                prestamos.Add(prestamo);
                return (true, $"Préstamo agregado: {prestamo.ToString()}");
            }
        }

        public bool ExistePrestamo(Prestamo prestamo)
        {
            return prestamos.Any(p =>
                p.Persona.Equals(prestamo.Persona) &&
                p.FechaInicio == prestamo.FechaInicio &&
                p.Monto == prestamo.Monto &&
                p.Plazo == prestamo.Plazo &&
                p.TasaInteres == prestamo.TasaInteres);
        }

        public Prestamo? GetPrestamo(Guid prestamoNro)
        {
            return prestamos.FirstOrDefault(p => p.PrestamoNro == prestamoNro);
        }

        public List<Prestamo> GetPrestamos(TipoPrestamo tipoPrestamo)
        {
            return prestamos.Where(p => (TipoPrestamo)p.TasaInteres == tipoPrestamo).ToList();
        }

        public int GetCantidad(TipoPrestamo tipoPrestamo)
        {
            return prestamos.Count(p => (TipoPrestamo)p.TasaInteres == tipoPrestamo);
        }

        public string Nombre => nombre;

    }
}
