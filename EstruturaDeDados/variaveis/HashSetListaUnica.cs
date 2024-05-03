namespace EstruturaDeDados.variaveis;

public class HashSetListaUnica
{
    HashSet<int> listaUnica = new HashSet<int>();

    public void printListaUnica()
    {
        listaUnica.Add(1);
        listaUnica.Add(2);
        listaUnica.Add(3);
        listaUnica.Add(1);//
        listaUnica.Add(2);//


        Console.WriteLine($"Quantidade de itens: {listaUnica.Count}");
        foreach (var item in listaUnica)
        {
            Console.WriteLine($"Valor: {item}");
        }
    }
}
