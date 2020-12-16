//Metodos de extensão EX3

//Eles permitem que estenda-se um tipo existente com uma nova funcionalidade,
//sem precisar subclassificar ou recompilar o tipo antigo.
//Por exemplo, pode-se querer saber se uma determinada string era um número ou não.
//A abordagem usual seria definir uma função e, em seguida, chamá-la toda vez,
// e depois de obter um monte desse tipo de funções, você as colocaria juntas em uma classe de utilitário, assim:

public class MyUtils
{
    public static bool IsNumeric(string s)
    {
        float output;
        return float.TryParse(s, out output);
    }
}

// Agora pode-se verificar uma string executando uma linha de código como esta:


string test = "4";
if (MyUtils.IsNumeric(test))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

// No entanto, com Métodos de Extensão, pode-se realmente estender a classe String para suportar isso diretamente.
// Eh feito isso definindo uma classe estática, com um conjunto de métodos estáticos que serão sua biblioteca de métodos de extensão.
// Aqui está outro exemplo:

public static class MyExtensionMethods
{
    public static bool IsNumeric(this string s)
    {
        float output;
        return float.TryParse(s, out output);
    }
}

//A única coisa que separa isso de qualquer outro método estático, é a palavra-chave "this" na seção de parâmetro do método.
//Ele diz ao compilador que este é um método de extensão para a classe string,
//e isso é tudo que se precisa para criar um método de extensão.
// Agora, pode-se chamar o método IsNumeric() diretamente em strings, assim:

string test = "4";
if (test.IsNumeric())
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");