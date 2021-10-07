using System;

namespace Volador
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torredecontrol = new TorreDeControl();

            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();

            torredecontrol.agregarVolador(pato);
            torredecontrol.agregarVolador(boing747);
            torredecontrol.agregarVolador(superman);

            torredecontrol.vuelenTodos();

        }
    }
}
