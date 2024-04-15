using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Habitaciones
    {
        public Habitaciones(int id_habitacion, string tipo_habitacion, double precio_habitacion, bool estado_habitacion, string ubicacion_habitacion, string descripcion)
        {
            this.Id_habitacion = id_habitacion;
            this.Tipo_habitacion = tipo_habitacion;
            this.Precio_habitacion = precio_habitacion;
            this.Estado_habitacion = estado_habitacion;
            this.Ubicacion_habitacion = ubicacion_habitacion;
            this.Descripcion = descripcion;
        }

        private int Id_habitacion { get; set; }
        private String Tipo_habitacion { get; set; }
        private double Precio_habitacion { get; set; }
        private bool Estado_habitacion { get; set; }
        private String Ubicacion_habitacion { get; set; }
        private String Descripcion { get; set; }
    }
}
