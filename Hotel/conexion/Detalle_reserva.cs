using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Detalle_reserva
    {
        public Detalle_reserva() { }

        public Detalle_reserva(int id_detalle_reserva, decimal cargo_adicional, string comentarios, int id_reserva)
        {
            Id_detalle_reserva = id_detalle_reserva;
            Cargo_adicional = cargo_adicional;
            Comentarios = comentarios;
            Id_reserva = id_reserva;
        }

        private int Id_detalle_reserva { get; set; }
        private decimal Cargo_adicional { get; set; }
        private String Comentarios{ get; set; }
        private int Id_reserva { get; set; }
    }
}
