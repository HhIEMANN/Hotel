using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Reserva
    {
        public Reserva() { }

        public Reserva(int id_reserva, int id_cliente, int id_habitacion, int id_usuario, DateTime fecha_inicio, DateTime fecha_fin)
        {
            Id_reserva = id_reserva;
            Id_cliente = id_cliente;
            Id_habitacion = id_habitacion;
            Id_usuario = id_usuario;
            Fecha_inicio = fecha_inicio;
            Fecha_fin = fecha_fin;
        }

        private int Id_reserva { get; set; }
        private int Id_cliente { get; set; }
        private int Id_habitacion{ get; set; }
        private int  Id_usuario { get; set; }
        private DateTime Fecha_inicio{ get; set; }
        private DateTime Fecha_fin { get; set; }
    }
}
