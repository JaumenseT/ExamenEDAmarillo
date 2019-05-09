using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAmarillo {
    class Cliente {
        private string nombre;
        private string dni;
        private double saldo = 100;

        public string Nombre { get { return nombre; } }
        public string Dni { get { return dni; } }
        public double Saldo { get { return saldo; } }

        public Cliente(string nombre, string dni, double saldo) {
            this.nombre = nombre;
            this.dni = dni;
            this.saldo = saldo;
        }

        public Cliente() {

        }


    }
}
