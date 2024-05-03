namespace EstruturaDeDados.variaveis;

public class Listas
{
    List<int> inteiros = new List<int>();
    List<string> nomes = new List<string>(["João", "Maria", "José", "Ana"]);
    List<string> frase = new List<string>(["O", "rato", "roeu", "a", "roupa", "do", "rei", "de", "roma"]);


    public void printList()
    {
        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);
        inteiros.Add(4);
        inteiros.Add(5);

        
        var firstInteiroElement = inteiros.First();
        var lastInteiroElement = inteiros.Last();
        var fiveElement = inteiros.ElementAt(4);


        Console.WriteLine("Primeiro elemento da lista de inteiros: " + firstInteiroElement);
        Console.WriteLine("Último elemento da lista de inteiros: " + lastInteiroElement);
        Console.WriteLine("Quinto elemento da lista de inteiros: " + fiveElement);
        Console.WriteLine("Tamanho da lista de inteiros: " + inteiros.Count);
        foreach (var item in inteiros)
        {
            Console.WriteLine($"Item {inteiros.IndexOf(item)}: " + item);
        }

        Console.WriteLine("===================");

        Console.WriteLine("Tamanho da lista de nomes: " + nomes.Count);

        foreach (var item in nomes)
        {
            Console.WriteLine($"Item {nomes.IndexOf(item)}: " + item);
        }



    }

    public void printListWithRemove()
    {

        Console.WriteLine("===================");

        var firstNomeElement = nomes.First();
        var lastNomeElement = nomes.Last();
        var secondNomeElement = nomes.ElementAt(1);

        Console.WriteLine("Primeiro elemento da lista de nomes: " + firstNomeElement);
        Console.WriteLine("Último elemento da lista de nomes: " + lastNomeElement);
        Console.WriteLine("Segundo elemento da lista de nomes: " + secondNomeElement);
        Console.WriteLine("Tamanho da lista de nomes: " + nomes.Count);

        foreach (var item in nomes)
        {
            Console.WriteLine($"Item {nomes.IndexOf(item)}: " + item);
        }

        nomes.Remove("Maria");
        Console.WriteLine("===================");
        Console.WriteLine("Tamanho da lista de nomes após remoção de Maria: " + nomes.Count);
        foreach (var item in nomes)
        {
            Console.WriteLine($"Item {nomes.IndexOf(item)}: " + item);
        }


        nomes.RemoveAt(0);
        Console.WriteLine("===================");
        Console.WriteLine("Tamanho da lista de nomes após remoção do elemento de índice 0: " + nomes.Count);
        foreach (var item in nomes)
        {
            Console.WriteLine($"Item {nomes.IndexOf(item)}: " + item);
        }


        nomes.Clear();
        Console.WriteLine("===================");
        Console.WriteLine("Tamanho da lista de nomes após Remoção de todos elementos: " + nomes.Count);


    }

    public void printFrase()
    {
        var fraseFormatted = string.Join(" ", frase);
        var fraseFormatted2 = string.Join("-", frase);
        var fraseFormatted3 = string.Join(",", frase);

        Console.WriteLine(fraseFormatted);
        Console.WriteLine(fraseFormatted2);
        Console.WriteLine(fraseFormatted3);
    }
}
