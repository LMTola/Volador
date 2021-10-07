using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Boing747: Aviones, Volador
    {
        public void Volar()
        {
            Console.WriteLine("Estoy Volando como un avión...");
        }
    }
}
