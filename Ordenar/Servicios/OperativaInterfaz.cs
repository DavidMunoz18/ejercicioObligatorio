using Ordenar.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos relacionados con el cliente.
    /// <author>dmp - 090124</author>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que da de alta al cliente, para que aparezca en la aplicacion.
        /// <author>dmp - 090124</author>
        /// </summary>
        /// <param name="listaCliente">Es la lista de tipo clienteDto, que contiene todos los clientes creados</param>
        public void darAltaCliente(List<ClienteDto> listaCliente);

        /// <summary>
        /// Metodo que comprueba que haya al menos 3 clientes en la lista, si no los hay manda un mensaje.
        /// <author>dmp - 160124</author>
        /// </summary>
        /// <param name="listaCliente">Es la lista de tipo clienteDto, que contiene todos los clientes creados</param>

        public void comprobarCliente(List<ClienteDto> listaCliente);

        
    }
}
