namespace EstruturaDeDados.EstruturaDeRepeticao;

public class EstruturaWhile
{
    int numero = 10;
    public void WhileSimples()
    {
        while (numero <= 10)
        {
            Console.WriteLine($"Número: {numero}");
            numero++;
        }
        Console.WriteLine($"Número: {numero}");
    }

    public void DoWhileSimples()
    {
        do
        {
            Console.WriteLine($"Número: {numero}");
            numero++;
        } while (numero <= 10);
        Console.WriteLine($"Número: {numero}");
    }
}
