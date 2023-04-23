using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad3_Excepciones_métodosdeOrdenamiento.Clases;

namespace Unidad3_Excepciones_métodosdeOrdenamiento
{
    internal class Program
    {
        static void Main() // Metodo Principal
        {   
            Ordenamiento metodo = null;
            string nombreArchivo = "";
            menu:
            Console.Clear();
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("| Ingrese el número de el Método de Ordenamiento    |");
            Console.WriteLine("|      por el cual desea relizar la Operación.      |");
            Console.WriteLine("|---------------------------------------------------|");
            Console.WriteLine("| [1] Método Borbuja.                               |");
            Console.WriteLine("| [2] Método Shell.                                 |");
            Console.WriteLine("| [3] Método Selección.                             |");
            Console.WriteLine("| [4] Método Insercción.                            |");
            Console.WriteLine("| [0] Salir de la Aplicacion.                       |");
            Console.WriteLine("|___________________________________________________|\n");

            Console.Write("| Digite número del Método que desea Realizar: ");
            string opciones = Console.ReadLine();

            try
            { 
                int TipoOpe = int.Parse(opciones);

                if ((TipoOpe >= 0) && (TipoOpe <= 4))
                {
                    if (TipoOpe != 0)
                    {
                        
                        try
                        {
                            switch (TipoOpe)
                            {
                                case 1:
                                    metodo = new Burbuja();
                                    nombreArchivo = "Burbuja";
                                    break;

                                case 2:
                                    metodo = new Shell();
                                    nombreArchivo = "Shell";

                                    break;

                                case 3:
                                    metodo = new Seleccion();
                                    nombreArchivo = "Seleccion";

                                    break;

                                case 4:
                                    metodo = new Insercion();
                                    nombreArchivo = "Insercion";
                                    break;

                                default:
                                    Console.WriteLine("| Opción inválida. Inténtalo de nuevo. ");
                                    break;

                            }
                            if (TipoOpe != 0)
                            {
                                metodo.ObtenerDatos();
                                metodo.Operacion();
                                metodo.Listar(nombreArchivo);
                                metodo.CargarArchivo(nombreArchivo + ".txt");
                                Console.ReadKey();
                                goto menu;
                            }
                            
                        }
                        catch (Exception)
                        {
                            Console.Write("| No le es permitido ingresar, este tipo de datos ");
                            Console.ReadKey();
                            Console.Clear();
                            goto menu;
                        }
                    }
                }
                else
                {
                    Console.Write("| No se ingresó una Opción numérica valida entre 0 y 4. Presione Enter ");
                    Console.ReadKey();
                    Console.Clear();
                    goto menu;
                }
            }
            catch (Exception)
            {
                Console.Write("| No le es permitido ingresar, este tipo de dato, Presione Enter para continuar ");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }                              
        }
    }
}
