using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinoAnimalLorena
{
    class Ave : Animal
    {
        public void migrar()
        {

        }
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("Ave voa");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("Ave canta");
        }

    }
}

