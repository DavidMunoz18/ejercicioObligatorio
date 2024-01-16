using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos relacionados con el menu que aparecen en el menu interfaz.
    /// <author>dmp - 090124</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionMenu;
            Console.WriteLine("##############################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar alta nuevo cliente");
            Console.WriteLine("2. Ordenar lista clientes");
            Console.WriteLine("##############################");
            opcionMenu = Console.ReadKey(true).KeyChar - '0';
            return opcionMenu;
        }
    }
}
