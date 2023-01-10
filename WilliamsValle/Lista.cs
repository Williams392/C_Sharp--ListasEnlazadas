using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilliamsValle
{
    internal class Lista
    {
        // llamar ala clase Nodo.
        public Nodo inicio, fin;

        // valores iniciales que van hacer 0 (null).
        public Lista()
        {
            inicio = null;
            fin = null;
        }

        // 1
        public void insertaValor()
        {
            Nodo nuevo = new Nodo();

            Console.WriteLine("\t\t ****Insertar al Inicio****");
            Console.Write("\t\t Ingrese la Cancion para el Nodo: ");
            nuevo.Dato = Console.ReadLine();

            if(inicio == null)
            {
                inicio = nuevo;
                inicio.Sgte = null;
                inicio.Ant = null;
                fin = inicio;
            } else
            {
                fin.Sgte = nuevo;
                nuevo.Sgte = null;
                nuevo.Ant = fin;
                fin = nuevo;
            }
            Console.WriteLine(); // salto de linea
            Console.WriteLine("\t\t Nodo Ingresado Correctamente");
        }

        // 2
        public void mostrar_lista()
        {
            Nodo aux;
            aux = inicio;

            while (aux != null)
            {
                Console.Write(aux.Dato + "->");
                aux = aux.Sgte;
            }
        }

        // 3
        public void buscar()
        {
            Nodo aux;
            int band = 0, i = 1; // el 0 Representa de No encontrar

            Console.WriteLine(" Busqueda de un Elemento de la Lista: ");
            Console.Write("Ingresar el dato a buscar: ");
            String valor = Console.ReadLine();

            if (inicio != null)
            {
                aux = inicio;
                do
                {
                    if (valor == aux.Dato)
                    {
                        Console.WriteLine("Elemento encontrado en la posicion: " + i);
                        band = 1;
                        return;
                    }
                    else
                    {
                        i++;
                        aux = aux.Sgte;
                    }
                } while (aux != inicio);
                if (band == 0)
                    Console.WriteLine("\t Elemento no Encontrado..!!");
            }
            else
            {
                Console.WriteLine("\t LISTA VACIA...!!");
            }
        }

        // 4
        public void EliminarNodo()
        {
            Nodo actual = new Nodo();
            actual = inicio;

            Nodo anterior = new Nodo();
            anterior = inicio;

            bool encontrado = false;
            Console.WriteLine("Ingrese el Valor del nodo a Buscar: ");
            String nodoBusqueda = Console.ReadLine();


            if (inicio == null)
                Console.WriteLine("\n la lista esta vacia");
            else
            {
                while (actual != null && encontrado != true)
                {
                    if (nodoBusqueda == actual.Dato)
                    {
                        // hay 3 casos para elimienar:  1ro, ultimo o el nodo esta al medio;
                        if (actual == inicio)
                            inicio = inicio.Sgte;
                        else if (actual == fin)
                        {
                            anterior.Sgte = null;
                            fin = anterior;
                        }
                        else
                            anterior.Sgte = actual.Sgte;
                        Console.WriteLine("\t\t El nodo se elimino satisfactoriamente. ");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.Sgte;
                }
                if (encontrado)
                {
                    Console.WriteLine("\t\t Nodo No exite en la lista ");
                }
                else
                {
                    Console.WriteLine("\t\t La lista esta vacia");
                }
            }
        }
    }
}
