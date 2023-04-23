using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad3_Excepciones_métodosdeOrdenamiento.Clases
{
    internal class Shell: Ordenamiento
    {
        public override void Operacion()
        {
            
            int aux0 = 0, aux1 = 0, aux2 = 0, aux3 = 0;
            aux0 = vectorOrd.Length / 2;

            while (aux0 > 0)
            {
                aux1 = 1;
                while (aux1 != 0)
                {
                    aux1 = 0;
                    aux3 = 1;
                    while (aux3 <= (vectorOrd.Length - aux0))
                    {
                        if (vectorOrd[aux3-1] > vectorOrd[(aux3 - 1) + aux0])
                        {
                            aux2 = vectorOrd[(aux3 - 1) + aux0];
                            vectorOrd[(aux3-1) + aux0] = vectorOrd[aux3 - 1];
                            vectorOrd[(aux3 - 1)] = aux2;
                            aux1 = 1;
                        }
                        aux3++;
                    }
                }
                aux0 /= 2;
            }
            
        }   
    }
}
