using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos de funcionalidad del menú.
    /// <author>dmp - 090124</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y permite al usuario escoger una opción.
        /// <author>dmp - 090124</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
