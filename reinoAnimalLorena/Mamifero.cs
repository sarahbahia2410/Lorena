using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinoAnimalLorena
{
    class Mamifero : Animal
    {
        public void amamenta()
        {

        }
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine(" Mamífero anda ou nada");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine(" Mamífero emite som");
        }

    }
}
