using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

/*
 Nas outras linguagem, essa integração que em C# eh conhecida como metodo de extensao
eh chamado de MODULO. Como por exemplo, em Ruby.

    ======================================================

O que sao Modulos?
Um modulo pode ser definido de forma grosseira como uma colecao de metodos e constantes
(definicao para linguagem Ruby).

    ======================================================

    Para a classe de metodo de estensao ser visivel, ela tem alguns pontos que
precisam ser observados:

    1) a classe deve ser estatica: 

    2) os metodos das classes tambem devem ser estaticos;

    3) O método deve receber a classe que vai ser modulada.

    No exemplo dos CAFES, a cafeteira, que esta sendo mudulada.
    eh ela que esta recebendo o modulo

 */

{
    public static class ModuladorCafeteira
    {
        public static string PrepararCafeComLeite(this Cafeteira cafeteira)
        {
            return "Preparando Café com Leite ..." + cafeteira.PrepararCafe();

            //acima pode ser feito o tratamento que quiser, nesse exemplo,
            //ele manda a msg e depois dispara o metodo de estensao PrepararCafe();
        }

        public static string PrepararUmCafeComAprovacao(this Cafeteira cafeteria)
        {
            return "Preparando um cafe com a nota final" + cafeteria.PrepararCafe();

        }
    }
}
