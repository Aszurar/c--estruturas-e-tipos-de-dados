namespace EstruturaDeDados.variaveis;

public class Nulo
{
    int? idade = null;
    string? name = "Lucas de Lima";


    public void printNulo()
    {
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("idade.HasValue: " + idade.HasValue);

        Console.WriteLine("Name: " + name);
        // Console.WriteLine("name.HasValue: " + name.HasValue);
    }
}
