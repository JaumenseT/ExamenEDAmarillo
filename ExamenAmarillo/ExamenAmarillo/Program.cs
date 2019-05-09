using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAmarillo {
    class Program {
        static void Main(string[] args) {
            Cliente cliente = new Cliente("Antonio", "4567892Y");
            Cliente.SumaSaldo(234);
            Cliente.RestaSaldo(569);

            Console.WriteLine("El cliente con Nombre: " + cliente.Nombre + " dni: " + cliente.Dni + "\n" + "Saldo: " + cliente.Saldo + " Positivo/Negativo: " + Cliente.PositivoNegativo(cliente.Saldo));
            Console.ReadKey();
        }
    }
}
