using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repasoxdxdxdxd.clases
{
    public class Recursividad
    {
        public int RestaRecursiva(int n)
        {
            if (n == 0)
            {
                return 0; // Caso base: Cuando n llega a 0, regresamos 0.
            }
            else
            {
                // Llamada recursiva restando n-1
                return n - 1 - RestaRecursiva(n - 1);
            }


        }
    }
}
