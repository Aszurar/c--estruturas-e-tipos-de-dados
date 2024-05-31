using EstruturaDeDados.Classes;

namespace EstruturaDeDados.EstruturaDeControle;

public class Controle
{
    public void EstruturaDeControle()
    {
        int numero = 10;
        double saldo = 100.12;
        bool ativo = true;
        string author = "Lucas";
        List<int> listas = new List<int> { 1, 7 };
        MainColor cor = MainColor.Black;

        if (saldo > 0)
        {
            Console.WriteLine("Saldo positivo");
        }

        if (ativo)
        {
            Console.WriteLine("Ativo");
        } else
        {
            Console.WriteLine("Inativo");
        }


        if (!ativo)// se não for ativo
        {
            Console.WriteLine("Ativo");
        }



        if (numero > 10)
        {
            Console.WriteLine("O número é maior que 10");
        }
        else if (numero == 10)
        {
            Console.WriteLine("O número é igual a 10");
        }
        else
        {
            Console.WriteLine("O número é menor que 10");
        }


        if (author.Equals("Lucas"))
        {
            Console.WriteLine("Autor é Lucas");
        }
        else
        {
            Console.WriteLine("Autor não é Lucas");
        }


        if (listas.Contains(7))
        {
            Console.WriteLine("O número 7 está na lista");
        }
        else
        {
            Console.WriteLine("O número 7 não está na lista");
        }


        if (cor == MainColor.White || numero <= 123)
        {
            Console.WriteLine("A cor é branca ou o número é menor ou igual a 123");
        }
        else 
        {
            Console.WriteLine("A cor não é branca e o número não é menor ou igual a 123");
        }


        if(saldo > 0 && ativo)
        {
            Console.WriteLine("Saldo positivo e ativo");
        }
    }


    public void IfTernario()
    {
        int numero = 10;
        var resultado = numero > 100 ? "Maior que 100" : "Menor ou igual a 100";
        Console.WriteLine(resultado);
    }

    public void EstruturaSwitch()
    {
        string text = "Lucas";
        int numero = 10;
        MainColor cor = MainColor.Black;

        switch(cor)
        {
            case MainColor.Black:
                { 
                Console.WriteLine("A cor é preta");
                // Caso queira fazer mais do que uma ação
                }
                break;
            case MainColor.White:
                Console.WriteLine("A cor é branca");
                break;
            case MainColor.Blue:
                Console.WriteLine("A cor é azul");
                break;
            default:
                Console.WriteLine("A cor não é preta, branca ou azul");
                break;
        }


        switch(numero)
        {
            case 10:
                Console.WriteLine("O número é 10");
                break;
            case 20:
                Console.WriteLine("O número é 20");
                break;
            default:
                Console.WriteLine("O número não é 10 ou 20");
                break;
        }

        switch(text)
        {
            case "Lucas":
                Console.WriteLine("O texto é Lucas");
                break;
            case "João":
                Console.WriteLine("O texto é João");
                break;
            default:
                Console.WriteLine("O texto não é Lucas ou João");
                break;
        }
    }

    public void EstruturaSwitchTernario()
    {
        int numero = 20;
        var resultado = numero switch
        {
            10 => "O número é 10",
            20 => "O número é 20",
            _ => "O número não é 10 ou 20" // _ é o default
        };

        Console.WriteLine(resultado);
    }
}
