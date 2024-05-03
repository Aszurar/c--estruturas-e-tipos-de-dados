namespace EstruturaDeDados.variaveis;

public class Numeros
{
    int numeroInteiro = 10;
    long numeroInteiroComMaiorIntervalor = 100;
    byte numeroDeZeroAteDuzentosECinquentaECinco = 234;


    double numeroDouble = 1.23;
    float numeroFloat = 2.45f;
    decimal numeroDecimal = 56.34m;

    
    public void ImprimirNumerosInteiro()
    {
        Console.WriteLine("Números:");
        Console.WriteLine("numeroInteiro:");
        Console.WriteLine(numeroInteiro);
        Console.WriteLine("numeroInteiroComMaiorIntervalor:", numeroInteiroComMaiorIntervalor);
        Console.WriteLine(numeroInteiroComMaiorIntervalor);
        Console.WriteLine("numeroDeZeroAteDuzentosECinquentaECinco:", numeroDeZeroAteDuzentosECinquentaECinco);
        Console.WriteLine(numeroDeZeroAteDuzentosECinquentaECinco);
    }

    public void ImprimirNumerosQuebrados()
    {
        Console.WriteLine("Números:");
        Console.WriteLine("numeroInteiro:");
        Console.WriteLine(numeroDouble);
        Console.WriteLine("numeroFloat:");
        Console.WriteLine(numeroFloat);
        Console.WriteLine("numeroDecimal:");
        Console.WriteLine(numeroDecimal);
    }
}

