using Ordenar.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos que aparecen en la operativa interfaz.
    /// <author>dmp - 160124</author>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void comprobarCliente(List<ClienteDto> listaCliente)
        {

           if(listaCliente.Count >= 3)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Clientes sin ordenar");
                Console.WriteLine("-------------------------");
                mostrarCampos(listaCliente);
                Console.WriteLine("-------------------------");
               ordenarCliente(listaCliente);
                Console.WriteLine("-------------------------");
                Console.WriteLine("Clientes ordenados");
                Console.WriteLine("-------------------------");
                mostrarCampos(listaCliente);
                Console.WriteLine("-------------------------");
            }
            else
            {
                Console.WriteLine("Es necesario tener al menos 3 clientes");
                
            }
        }

        public void darAltaCliente(List<ClienteDto> listaCliente)
        {

            ClienteDto cliente = aniadirCliente();

            listaCliente.Add(cliente);

        }
        /// <summary>
        /// Metodo el cual sirve para poder añadir los datos del cliente a los campos de la lista.
        /// <author>dmp - 160124</author>
        /// </summary>
        /// <returns></returns>
        private ClienteDto aniadirCliente() 
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Introduzca el id");
            cliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre");
            cliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el apellidos");
            cliente.ApellidosCliente = Console.ReadLine();

             cliente.NombreCompletoCliente = cliente.NombreCliente + cliente.ApellidosCliente;

            Console.WriteLine("Introduzca la edad");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());

            return cliente;
        }

        /// <summary>
        /// Metodo que ordena a los clientes de forma descendente, usando el algoritmo burbuja.
        /// <author>dmp - 160124</author>
        /// </summary>
        /// <param name="listaCliente">Es la lista de tipo clienteDto, que contiene todos los clientes creados</param>
        private void ordenarCliente(List<ClienteDto> listaCliente)
        {
            for (int i = 0; i < listaCliente.Count - 1; i++)
            {
                for (int j = 0; j < listaCliente.Count - 1 - i; j++)
                {
                    if (listaCliente[j].Edad < listaCliente[j + 1].Edad)
                    {
                        ClienteDto aux = listaCliente[j];
                        listaCliente[j] = listaCliente[j + 1];
                        listaCliente[j + 1] = aux;
                    }
                }
            }
        }
        /// <summary>
        /// Metodo que muestra solamente el nombre completo y la edad del cliente.
        /// </summary>
        /// <param name="listaCliente"></param>
        private void mostrarCampos(List<ClienteDto> listaCliente)
        {
            
            foreach (ClienteDto cliente in listaCliente)
            {
                Console.WriteLine(" Nombre Completo: " + cliente.NombreCompletoCliente + " Edad: " + cliente.Edad);
            }

        }
       
    }
}
