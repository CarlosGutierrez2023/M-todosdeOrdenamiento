using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad3_Excepciones_métodosdeOrdenamiento.Clases;

namespace Unidad3_Excepciones_métodosdeOrdenamiento
{
    public class Burbuja : Ordenamiento
    {
        public override void Operacion()
        {
            
            for (int i = 0; i < vectorOrd.Length; i++)
            {
                for (int j = i + 1; j < vectorOrd.Length; j++)
                {
                    int aux1;
                    if (vectorOrd[i] > vectorOrd[j])
                    {
                        aux1 = vectorOrd[i];
                        vectorOrd[i] = vectorOrd[j];
                        vectorOrd[j] = aux1;
                    }
                }
            }

        }
    }
}
