using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Detalle_venta
    {
        public Detalle_venta() { }

        public Detalle_venta(int id_Detalle_venta, int id_venta, DateTime fecha_venta, decimal total_Venta, decimal total_pagar)
        {
            Id_Detalle_venta = id_Detalle_venta;
            Id_venta = id_venta;
            Fecha_venta = fecha_venta;
            Total_Venta = total_Venta;
            Total_pagar = total_pagar;
        }

        private int Id_Detalle_venta { get; set; }
        private int Id_venta { get; set; }
        private DateTime Fecha_venta { get; set; }
        private decimal Total_Venta { get; set; }
        private decimal Total_pagar { get; set; }
    }
}
