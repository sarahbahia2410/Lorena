using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinoAnimalLorena
{
    class Peixe : Animal
    {
        public String barbatanas{ get; protected set;}
         
        public override void Locomove()
        {
        base.Locomove();
        Console.WriteLine("Peixe nada");
        }

        }
}
