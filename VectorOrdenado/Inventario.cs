using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOrdenado
{
    class Inventario
    {
        private Producto[] _producto;
        private int _contador;

        public Inventario(int tamaño)
        {
            _producto = new Producto[tamaño];
            _contador = 0;
        }

        public string agregar(Producto prod)
        {
            if (_contador < _producto.Length)
            {
                _producto[_contador] = prod;
                _contador++;
                return "Producto agregado";
            }
            else
            {
                return "Producto no agregado, ya no hay espacio";
            }
        }

        public string eliminar(int posicion)
        {
            for (int i = posicion; i < _contador - 1; i++)
            {
                _producto[i] = _producto[i + 1];
            }
            if (_contador - 1 > 0)
            {
                _producto[_contador - 1] = null;
                _contador--;
            }
            return "Producto eliminado";
        }

        public Producto buscar(int codigo)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_producto[i] != null)
                {
                    if (_producto[i]._codigo == codigo)
                        return _producto[i];
                }
            }
            return null;
        }

        public string listar()
        {
            string vector = "";
            for (int i = 0; i < _contador; i++)
            {
                vector += _producto[i].ToString();
            }
            return vector;
        }
    }
}
