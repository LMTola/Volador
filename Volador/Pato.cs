using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class Pato: Animal, Volador
    {
        public void Volar()
        {
            Console.WriteLine("Estoy Volando como un pato...¡Cuak!");
        }

    }

}

