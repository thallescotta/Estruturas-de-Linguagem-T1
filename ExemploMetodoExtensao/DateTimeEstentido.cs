using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMetodoExtensao
{
    public static class DateTimeEstentido

/* 
Então aqui estou criando uma classe, que será extendida,   
 O exemplo é para implementar um metodo de estensao, para instancias do tipo DateTime,
e esse metodo de estensao, vai permitir que rapidamente se formate um valor DateTime,
para o padrao brasileiro, como irei demonstrar abaixo.

Entao essa conversao sera feito via metodo de estensao, ao inves de simplemente eu
fazer isso atraves do metodo ToString, toda hora, passando uma String de formatacao.
 */

    {
        public static string ToBrazilianFormat(this DateTime value)
        //eh comum que uma classe criada para metodo de extensao, seja criada numa
        //classe separada, estatica. E o metodo de extensao tbm sera estatico.

        {
            return value.ToString("dd/MM/yyyy HH:mm:ss");
            // acima ficou assim: tipo e nome do parametro: value, mais acima
            // Qdo eu for invocar esse metodo de estensao, ele vai simplemente aparecer
            // como se fosse um metodo comum, do tipo DateTime.


            /*Aqui esta a grande questao que me foi arguida:
             Ao inves de criar um novo tipo derivado de DateTime,
            que levaria trabalho adicional, e em muitos casos, poderia
            gerar uma certa dificuldade com o decorrer do tempo, durante o desenvolvimento,
            Como o metodo de estensao, adicona-se essa capacidade sem criar um modificacao
            um pouco maior daqui que eh de costume para essa linguagem
            */

        }
    }
}