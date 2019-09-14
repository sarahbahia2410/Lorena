using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reinoAnimalLorena
{
    class Humano : Mamifero
    {
        public String CPF{ get; protected set;}
        
     public void sorri( )
    {

    }
  
    public override void Comunicar( )
    {
    base. Comunicar( );
    Console. WriteLine( "Humano fala");
    }

    }
    public Humano ( float idade, float peso, string som, float velocidade, string cpf)
        {
            Idade = idade;
            Som = som;
            Velocidade = velocidade;
            Peso = peso;
            CPF = cpf;

        }
}

