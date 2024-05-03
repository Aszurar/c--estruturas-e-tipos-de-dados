namespace EstruturaDeDados.variaveis;

public class VariaveisImplicitas
{
    // var é uma palavra-chave que pode ser usada para declarar variáveis locais.
    // O tipo de variável é determinado pelo compilador.

    public void printVariaveisImplicitas()
    {
        //string name = "Lucas de Lima" - declaração de variável comum
        var name = "Lucas de Lima"; // declaração de variável implícita
        var numero = 10;

        var niveis = new Enums();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Numero: " + numero);
        niveis.printNivelDificuldade();
    }
}
