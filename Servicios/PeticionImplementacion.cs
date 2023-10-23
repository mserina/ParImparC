using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParOImpar.Servicios
{
    /// <summary>
    /// Clase donde se especifica la logica de la aplicacion
    /// </summary>
    internal class PeticionImplementacion : PeticionInterfaz
    {
        public double solicitudNumero() {
            double numero;
            Console.WriteLine("Inserte un numero");
            numero = Double.Parse(Console.ReadLine());
            return numero;
            
        }

    }
}
