using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Ventas
    {
        public Ventas(int id_venta, DateTime fecha_venta, decimal total_venta, int id_cliente, int id_producto, int id_Usuario)
        {
            Id_venta = id_venta;
            Fecha_venta = fecha_venta;
            Total_venta = total_venta;
            Id_cliente = id_cliente;
            Id_producto = id_producto;
            Id_Usuario = id_Usuario;
        }

        private int Id_venta { get; set; }
        private DateTime Fecha_venta { get; set; }
        private decimal Total_venta { get; set; }
        private int Id_cliente{ get; set; }
        private int Id_producto { get; set; }
        private int Id_Usuario { get; set; }
    }
}
