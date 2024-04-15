using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.conexion
{
    internal class Producto
    {
        public Producto(int id_producto, string nombre_producto, string descripcion_producto, decimal precio_unidad, int existencias)
        {
            Id_producto = id_producto;
            Nombre_producto = nombre_producto;
            Descripcion_producto = descripcion_producto;
            Precio_unidad = precio_unidad;
            Existencias = existencias;
        }

        private int Id_producto { get; set; }
        private string Nombre_producto { get; set; }
        private String Descripcion_producto { get; set; }
        private decimal Precio_unidad { get; set; }
        private int Existencias { get; set; }
    }
}
