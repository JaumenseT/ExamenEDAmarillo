using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase cliente
/// </summary>
namespace ExamenAmarillo {
    public class Cliente {
        private string nombre;
        private string dni;
        private static int saldo = 100;

        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public int Saldo { get { return saldo; } set { saldo = value; } }

		/// <summary>
		/// Constructor de la clase sobrecargado
		/// </summary>
		/// <param name="nombre">Nombre del cliente</param>
		/// <param name="dni">DNI del cliente</param>
        public Cliente(string nombre, string dni) {
            this.nombre = nombre;
            this.dni = dni;
        }

		/// <summary>
		/// Constructor para instanciar el objeto
		/// </summary>
        public Cliente() {

        }

		/// <summary>
		/// Metodo para sumar al saldo del cliente  una cantidad
		/// </summary>
		/// <param name="s">Cantidad a sumar</param>
		/// <returns>Saldo actual</returns>
		public static int SumaSaldo(int s)
		{
		    saldo += s;
            return saldo;
		}

		/// <summary>
		/// Metodo para restar al saldo del cliente  una cantidad
		/// </summary>
		/// <param name="s">cantidad a restar</param>
		/// <returns>sueldo actual</returns>
		public static int RestaSaldo(int s)
		{
			saldo -= s;
            return saldo;
		}

		/// <summary>
		/// Metodo para saber si el saldo del cliente es positivo o negativo
		/// </summary>
		/// <param name="s">sueldo del cliente</param>
		/// <returns>String para saber si es positivo o negativo</returns>
		public static string PositivoNegativo(double s)
		{
			if (s >= 0) return "Positivo";
			else return "Negativo";
		}
    }
}
