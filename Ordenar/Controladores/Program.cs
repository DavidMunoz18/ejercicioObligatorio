using Ordenar.Dtos;
using Ordenar.Servicios;

namespace Ordenar.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// <author>dmp - 090124</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada a la aplicación.
        /// <author>dmp - 090124</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            OperativaInterfaz oi = new OperativaImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrarMenu = false;
            int opcionIntroducida;
            while(!cerrarMenu)
            {
                opcionIntroducida = mi.mostrarMenuYSeleccion();
                switch (opcionIntroducida)
                {
                    case 0:
                        Console.WriteLine("Se ejecuta el caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se ejecuta el caso 1");

                        oi.darAltaCliente(listaCliente);
                        foreach(ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta el caso 2");
                        oi.comprobarCliente(listaCliente);
                        
                        break;

                        default:
                        Console.WriteLine("No existe la opcion seleccionada");
                        break;
                }
            }
        }
    }
}
