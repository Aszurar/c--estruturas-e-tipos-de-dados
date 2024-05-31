namespace EstruturaDeDados.EstruturaDeRepeticao;

public class EstruturaFor
{
    List<string> lista = new List<string> { "Lucas", "João", "Maria", "José" };
    Dictionary<string, int> colecao = new Dictionary<string, int> { { "Lucas", 24 }, { "João", 19 }, { "Maria", 17 }, { "Jhenni", 16 } };


    public void ForSimples()
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"Índice do Elemento:{i}  - Valor: {lista[i]}");
        }
    }

    public void ForeachSimples()
    {
        foreach (var name in lista)
        {
            Console.WriteLine($"Valor: {name}");
        }
    }


    public void ForeachDictionary()
    {
        foreach (var item in colecao)
        {
            Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
        }
    }
}
