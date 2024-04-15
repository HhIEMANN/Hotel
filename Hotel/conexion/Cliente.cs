using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    class Cliente
    {
        public Cliente(int idCliente, string nombreCliente, string correoCliente, string documentoCliente, int telefonoCliente)
        {
            this.IdCliente = idCliente;
            this.NombreCliente = nombreCliente;
            this.CorreoCliente = correoCliente;
            this.DocumentoCliente = documentoCliente;
            this.TelefonoCliente = telefonoCliente;
        }

        private int IdCliente { get; set; }
        private String NombreCliente { get; set; }
        private String CorreoCliente{ get; set; }
        private String DocumentoCliente { get; set; }
        private int TelefonoCliente { get; set; }
        
    }
}
