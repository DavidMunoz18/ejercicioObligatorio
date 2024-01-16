using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar.Dtos
{
    /// <summary>
    /// Clase que se usa para crear a los clientes.
    /// <author>dmp - 160124</author>
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        long idCliente;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string nombreCompletoCliente;
        int edad = 0;


        //Getter y setter
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int Edad { get => edad; set => edad = value; }
        
        
        //Constructores
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompletoCliente, int edad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + apellidosCliente;
            this.edad = edad;
        }

        public ClienteDto()
        {
        }

        //ToString

        public string ToString()
        {
            string textoString = "ID: " + this.idCliente + " "+
                "NOMBRE: " + this.nombreCliente + " " +
                "APELLIDOS: " +this.apellidosCliente +" "+
                "NOMBRE COMPLETO: " + this.nombreCompletoCliente + " " +
                "EDAD: " + this.edad;
            return textoString;
        }
    }
}
