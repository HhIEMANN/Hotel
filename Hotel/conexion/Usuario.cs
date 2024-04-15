using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Usuario
    {
        public Usuario(int id_usuario, string nombre_usuario, string tipo_usuario, string puesto_usuario, string contraseña, string estado_usuario)
        {
            Id_usuario = id_usuario;
            Nombre_usuario = nombre_usuario;
            Tipo_usuario = tipo_usuario;
            Puesto_usuario = puesto_usuario;
            Contraseña = contraseña;
            Estado_usuario = estado_usuario;
        }

        private int Id_usuario { get; set; }
        private string Nombre_usuario { get; set; }
        private String Tipo_usuario { get; set; }
        private String  Puesto_usuario { get; set; }
        private String Contraseña { get; set; }
        private String Estado_usuario { get; set; }
    }
}
