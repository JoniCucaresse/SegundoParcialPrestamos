using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SegundoParcialPrestamos.Entidades
{
    public class Persona
    {
		private string? apellido;

		public string? Apellido
		{
			get { return apellido; }
			set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    apellido = value;
                else
                {
                    throw new ArgumentException("Apellido no válido");
                }


            }
        }

        private string? dni;

        public string? Dni
        {
            get { return dni; }
            set 
            {
                if (ValidarDni(value))
                    dni = value;
                else
                {
                    throw new ArgumentException("DNI no válido");
                }
            }
        }

        private string? nombres;

        public string? Nombres
        {
            get { return nombres; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nombres = value;
                else
                {
                    throw new ArgumentException("Nombre no válido");
                }
            }
        }

        public override string ToString()
        {
            return $"Apellido: {Apellido}, Nombres: {Nombres}, DNI: {Dni}";
        }

        public static bool ValidarDni(string dni)
        {
            string patron = @"^\d{8}$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(dni);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Persona otraPersona = (Persona)obj;

            return Dni == otraPersona.Dni;
        }
        public override int GetHashCode()
        {
            return Dni.GetHashCode();
        }

    }
}
