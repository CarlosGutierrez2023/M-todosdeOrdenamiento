using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_Excepciones_métodosdeOrdenamiento.Clases
{
    internal class Seleccion:Ordenamiento
    {
        public override void Operacion()
        {
            
            for (int i = 0; i < vectorOrd.Length - 1; i++)
            {
                int aux0 = i, aux1;
                for (int j = i + 1; j < vectorOrd.Length; j++)
                {
                    if (vectorOrd[j] < vectorOrd[aux0])
                    {
                       aux0 = j;
                    }
                }
                if (i != aux0)
                {
                    aux1 = vectorOrd[i];
                    vectorOrd[i] = vectorOrd[aux0];
                    vectorOrd[aux0] = aux1;
                }
            }
            
        }
    }
}
