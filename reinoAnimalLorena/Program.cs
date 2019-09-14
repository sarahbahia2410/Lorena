using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinoAnimalLorena
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato Donald = new Pato();
            Tubarao Martelo = new Tubarao();
            cachorro Pitoko = new cachorro();
            Humano Lorena = new Humano( 16, 54, "Tô com fome", 5, "000000000-00");
                Lorena.Nasce();
                Lorena.Cresce(5);
                Lorena.Amamenta();
                Lorena.Comunica();
                Lorena.Sorri();
                Human.Reproduz();
                Lorena.Locomove();
                Lorena.Morre();
        }
    }
}
