using System.Reflection.Metadata;

namespace EstruturaDeDados.EstruturasJumps;

public class EstruturasJumps
{
    int numero = 0;
    public void EstruturaBreak()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine($"Número: {i}");
        }

        // Continua a execução do método após o break
        // É diferente do return, que encerra a execução do método, ou seja,
        // o código abaixo do return não é executado.
        Console.WriteLine("Continuando a execução do método após o break");

        while (numero < 10)
        {
            if (numero == 5)
            {
                break;
            }
            Console.WriteLine($"Número: {numero}");

            numero++;
        }
    }

    public void EstruturaContinue()
    {
        while (numero < 10)
        {
            numero++;

            if (numero == 5)
            {
                continue;
            }
            Console.WriteLine($"Número: {numero}");

        }

        Console.WriteLine("Continuando a execução do método após o continue");
    }

    public void EstruturaReturn()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                return; // Encerra a execução do método
            }
            Console.WriteLine($"Número: {i}");
        }


    }   

    
}
