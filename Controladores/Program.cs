using EjercicioParOImpar.Servicios;

namespace EjercicioParOImpar
{
    /// <summary>
    /// Clase Principal de la aplicacion
    /// 231023 - msm
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PeticionInterfaz pe = new PeticionImplementacion();
            double n1;
            n1 = pe.solicitudNumero();

            if ((n1 % 2) == 0)
            {
                Console.WriteLine("Es par");
            }

            else
            {
                Console.WriteLine("Es impar");
            }
            }
        }
    }