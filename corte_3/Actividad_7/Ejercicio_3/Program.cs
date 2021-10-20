using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola
simple de números enteros y devuelva un apuntador al elemento donde exista el número. 
<x>. Este número es recibido por el método. Se debe retornar NULL si el valor de <x> no
se encuentra en la lista/pila/cola.*/

namespace ListasTipoPila1
{
    class Pila
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public int Extraer()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                raiz = raiz.sig;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Imprimir() 
        {
            Nodo reco=raiz;
            Console.WriteLine("Lista de todos los elementos de la pila.");
            while (reco!=null) 
            {
                Console.Write(reco.info+"-");
                reco=reco.sig;
            }
            Console.WriteLine();
        }

        public bool Vacia()
        {
            if (raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                cant++;
                reco = reco.sig;
            }
            return cant;
        }

        static void Main(string[] args)
        {
            Pila pila1=new Pila();
            pila1.Insertar(10);
            pila1.Insertar(40);
            pila1.Insertar(3);
            pila1.Imprimir();
            Console.WriteLine("La cantidad de nodos en la pila son :"+pila1.Cantidad());
            while (pila1.Vacia()==false) 
            {
                Console.WriteLine(pila1.Extraer());
            }
            Console.ReadKey();
        }
    }
}

