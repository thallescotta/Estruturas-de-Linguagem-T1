using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class MaquinaDeCafe
    { 
        private Cafeteira cafeteira = new Cafeteira();

        public string ServirCafePuro()
        {
            return cafeteira.PrepararCafe();
        }
        public string ServirCafeComLeite()
        {
            cafeteira.PrepararUmCafeComAprovacao();

            return cafeteira.PrepararUmCafeComAprovacao();

            //note que esse metodo acima, nao precisa de paramentro.
            //mesmo o que Modulador, peça um parametro "cafeteira",
            //ele la no outro codigo tem o "this" que eh a propria cafeteira
            //que esta chamando o metodo.
        }
    }
}
