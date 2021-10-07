using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volador
{
    class TorreDeControl
    {
        
        List<Volador> Voladores = new List<Volador>();
        public void agregarVolador(Volador unVolable)
        {
            Voladores.Add(unVolable);
        }

        public void vuelenTodos()
        {
            foreach (Volador c in Voladores)
            {
                c.Volar();
            }
        }


    }
}
