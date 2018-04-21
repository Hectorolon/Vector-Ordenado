using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOrdenado
{
    class Producto
    {
        public int _codigo { get; }
        public string _nombre { get; }
        public string _descripcion { get; }
        public int _cantidad { get; }
        public int _precio { get; }

        public Producto(int codigo, string nombre, string descripcion, int cantidad, int precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _descripcion = descripcion;
            _cantidad = cantidad;
            _precio = precio;
        }

        public override string ToString()
        {
            return "Codigo: " + _codigo + Environment.NewLine +
                "Nombre: " + _nombre + Environment.NewLine +
                "Descripcion: " + _descripcion + Environment.NewLine +
                "Cantidad: " + _cantidad + Environment.NewLine +
                "Precio: "+ Environment.NewLine + Environment.NewLine;
        }
    }
}
