namespace EstruturaDeDados.funcoes;

public class Calculadora
{
    public void Somar(int value1, int value2)
    {
        var resultado = value1 + value2;

        Console.WriteLine($"O resultado da soma é: {resultado}");
    }

    public void Subtrair(int value1, int value2)
    {
        var resultado = value1 - value2;

        Console.WriteLine($"O resultado da subtração é: {resultado}");
    }

    public float DividirInteiro(int value1, int value2)
    {
        var resultado = value1 / value2;

        return resultado;
    }

    // Forma simplificada quando há apenas uma linha de código
    public int Multiplicar(int value1, int value2) => value1 * value2;

    public void FuncaoOpcional(int value1, string author = "Desconhecido", int age = 10)
    {
        Console.WriteLine($"O autor do código {value1} é: {author}");
    }

}
