using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario_ed2_consola
{
    internal class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }
        public void Insertar( Nodo raiz, string nombre, int cantidad, double costo)
        {
            InsertarReg( raiz, nombre, cantidad, costo);
        }
        public Nodo InsertarReg( Nodo raiz, string nombre, int cantidad, double costo)
        {
            if (raiz == null)
            {
                raiz = new Nodo(nombre, cantidad, costo);
                return raiz;
            }
            int resultado = string.Compare(nombre, raiz.nombre, StringComparison.OrdinalIgnoreCase);

            if (string.Compare(nombre, raiz.nombre) < 0)
            {
                Raiz.left=InsertarReg( raiz.left, nombre, cantidad, costo);
            }
            else if (string.Compare(nombre, raiz.nombre) > 0)
            {
               Raiz.right= InsertarReg( raiz.right, nombre, cantidad, costo);
            }
            return raiz;

        }
        public void Modificar(Nodo n, string anterior, string nuevo)
        {
            if (n == null)
            {
                return;
            }
            if (string.Compare(anterior, Raiz.nombre) == 0)
            {
                Raiz.nombre = nuevo;
                return;
            }
            Modificar(n.left, anterior, nuevo);
            Modificar(n.right, anterior, nuevo);
        }
        public Nodo Buscar(Nodo inicio, string dato)
        {
            if (inicio == null)
            {
                return inicio;
            }
            if (string.Compare(dato, inicio.nombre) > 0)
            {
                return Buscar(inicio.right, dato);
            }
            if (string.Compare(dato, inicio.nombre) < 0)
            {
                return Buscar(inicio.left, dato);
            }
            return inicio;
        }
        public void PrintInOrder(Nodo raiz)
        {
            if (raiz == null)
            {
                PrintInOrder(raiz.Left);
                Console.WriteLine($" nombre:{raiz.nombre},cantidad:{raiz.cantidad},costo:{raiz.costo}");
                PrintInOrder(raiz.right);
            }
        }
        public void PrintPreOrden(Nodo raiz)
        {
            if (raiz == null)
            {
                
                    Console.WriteLine($" nombre:{raiz.nombre},cantidad:{raiz.cantidad},costo:{raiz.costo}");
                    PrintPreOrden(raiz.Left);
                    PrintPreOrden(raiz.right);
              
            }
        }
        public void PrintPosOrden(Nodo raiz)
        {
            if (raiz == null)
            {
                PrintPreOrden(raiz.left);
                PrintPreOrden(raiz.right);
                Console.WriteLine($"nombre:{raiz.nombre},cantidad:{raiz.cantidad },costo:{raiz.costo}");
               
            }
        }
    }
}
