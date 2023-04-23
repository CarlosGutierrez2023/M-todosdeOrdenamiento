using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_Excepciones_métodosdeOrdenamiento.Clases
{
    public abstract class Ordenamiento
    {        
        public int aux0;
        public int[] vectorOrd;

        public abstract void Operacion();

        public void ObtenerDatos()
        {
            Console.Write("| Ingrese la Cantidad de Números:  ");
            string numeroElemento = Console.ReadLine();

            aux0 = int.Parse(numeroElemento);
            vectorOrd = new int[aux0];


            for (int i = 0; i < aux0; i++)
            {
                Console.Write("| Número {0}: ", (i + 1));
                vectorOrd[i] = int.Parse(Console.ReadLine());
            }
        }

        public void CargarArchivo(string nombreArchivo)
        {
            Console.WriteLine("");
            Console.WriteLine("| ¿Desea Guardar los Datos? ");
            Console.Write("| 1. Si     0. No  : ");
            string opcion = Console.ReadLine();
            int opt = int.Parse(opcion);

            if (opt == 1)
            {
                FileStream file = new FileStream(nombreArchivo, FileMode.CreateNew);
                StreamWriter escritor = new StreamWriter(file);
                for (int i = 0; i < vectorOrd.LongLength; i++)
                {
                    escritor.WriteLine(vectorOrd[i]);
                }
                escritor.Close();
                file.Close();

            }
            Console.WriteLine("Precione Enter");
        }
        public void Listar(string metodo)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"| Bienvenido al Ordenamiento {metodo} ");
            Console.WriteLine("| Datos Ordenados ");
            for (int i = 0; i < vectorOrd.Length; i++)
            {
                Console.WriteLine("| " + vectorOrd[i]);
            }
        }
    }
}
