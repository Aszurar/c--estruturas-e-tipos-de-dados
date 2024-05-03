namespace EstruturaDeDados.variaveis;

public class Dicionarios
{
    Dictionary<int, string> dicionario = new Dictionary<int, string>();
    Dictionary<string, int> dicionario2 = new Dictionary<string, int>();

    public void printDicionario()
    {
        dicionario.Add(1, "um");
        dicionario.Add(2, "dois");
        dicionario.Add(3, "tres");

        dicionario2.Add("nome", 1);
        dicionario2.Add("idade", 2);
        dicionario2.Add("time", 3);

        foreach (var item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }

        foreach (var item in dicionario2)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }
    }

}
