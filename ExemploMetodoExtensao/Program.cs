using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMetodoExtensao

/*
Acima eu criei um ex de metodo de extensao e primeiramente quero mostrar que nas minhas pesquisas
eu encontrei que o metodo de extensao tbm eh muito usado na plataforma .NET:
para maniular colecoes, por exemplo, tem-se metodos, que o LINQ, que a Carol ira apresentar
disponibiliza ao usuario no namespace System.Linq (linha 3 aqui por exmeplo),
la existem varios outros metodos de estensao, como Enumerable.Where, OrderBy, ao qual
todos esse metodos sao metodos de extensao.

Nao eh preciso definir um novo tipo, para declarar um "metodo de estensao"
Ele é um complemento que podemos adicionar em algo que já existe.

eh interessante, pois evita que passemos a criar uma serie de classes, estentendo as
capacidades de algo que ja foi previamente definido
 */


{
    class MainClass
    {
        static void Main(string[] args)
        {
            var dataAtual = DateTime.Now;

            //acima crio uma variavel com a data/hora atual
            //e abaixo ja testo esse metodo de estensao criado

            Console.WriteLine(dataAtual.ToBrazilianFormat());

            //entao aqui acima, eu nao preciso passar a instancia data atual,
            //como um parametro. A linguagem estendidad, entende que essa operacao,
            // ToBrazilianFormat, eh um metodo que faz parte de DateTime

            Console.ReadKey();
        }
    }
}
