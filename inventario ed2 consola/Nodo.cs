using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario_ed2_consola
{
    internal class Nodo
    {
        public string nombre;
        public int cantidad;
        public double costo;
        public Nodo right;
        public Nodo left;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Costo { get => costo; set => costo = value; }
        internal Nodo Right { get => right; set => right = value; }
        internal Nodo Left { get => left; set => left = value; }

        public Nodo(string nombre, int cantidad, double costo)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Costo = costo;
            this.Right = null;
            this.Left = null;
        }
    }
}
