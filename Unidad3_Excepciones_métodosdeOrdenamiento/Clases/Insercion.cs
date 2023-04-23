using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_Excepciones_métodosdeOrdenamiento.Clases
{
    internal class Insercion:Ordenamiento
    {
        public override void Operacion()
        {
            
            int aux0, aux1;

            for (int i = 0; i < vectorOrd.Length; i++)
            {
                aux0 = vectorOrd[i];
                aux1 = i - 1;
                while (aux1 >= 0 && vectorOrd[aux1] > aux0)
                {
                    vectorOrd[aux1+1] = vectorOrd[aux1];
                    aux1--;
                }
                vectorOrd[aux1+1] = aux0;

            }
            
        }
    }
}
