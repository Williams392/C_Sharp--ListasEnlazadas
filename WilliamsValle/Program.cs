using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tarea
namespace WilliamsValle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lst = new Lista();
            int opc;

            do
            {
                Console.WriteLine(); // salto de linea
                Console.WriteLine("\t\t ***********MENU************");
                Console.WriteLine("\t\t ***************************");
                Console.WriteLine("\t\t [1] inserta las canciones");
                Console.WriteLine("\t\t [2] Mostrar Lista");
                Console.WriteLine("\t\t [3] Buscar nodo");
                Console.WriteLine("\t\t [4] Eliminar Nodo ");
                Console.WriteLine("\t\t [5] Salir");
                Console.WriteLine("\t\t Ingresar la Opcion: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        lst.insertaValor();
                        break;
                    case 2:
                        lst.mostrar_lista();
                        break;
                    case 3:
                        lst.buscar();
                            break;
                    case 4:
                        lst.EliminarNodo();
                        break;
                    case 5:
                        opc = 5;
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            } while (opc != 5);
        }
    }
}
