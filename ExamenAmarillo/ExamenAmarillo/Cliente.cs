using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAmarillo {
    public class Cliente {
        private string nombre;
        private string dni;
        private static int saldo = 100;

        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public int Saldo { get { return saldo; } set { saldo = value; } }

        public Cliente(string nombre, string dni) {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Cliente() {

        }

		public static int SumaSaldo(int s)
		{
		    saldo += s;
            return saldo;
		}

		public static int RestaSaldo(int s)
		{
			saldo -= s;
            return saldo;
		}

		public static string PositivoNegativo(double s)
		{
			if (s >= 0) return "Positivo";
			else return "Negativo";
		}
    }
}
