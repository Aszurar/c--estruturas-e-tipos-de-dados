namespace EstruturaDeDados.variaveis;

public class Vetores
{
    int[] inteiros = new int[5];
    int[] idades = [5, 10, 15, 20, 25];

    int[,] matriz = new int[2, 2];


    public void printVetores()
    {
        inteiros[0] = 5;
        inteiros[1] = 10;
        inteiros[2] = 20;
        inteiros[3] = 30;
        inteiros[4] = 40;

        Console.WriteLine("Vetor inteiros: " + inteiros);
        Console.WriteLine("inteiros[0]: " + inteiros[0]);
        Console.WriteLine("inteiros[1]: " + inteiros[1]);
        Console.WriteLine("Tamanho do vetor inteiros: " + inteiros.Length);
       
        Console.WriteLine("==========================");

        Console.WriteLine("Vetor idades: " + idades);
        Console.WriteLine("idades[0]: " + idades[0]);
        Console.WriteLine("idades[1]: " + idades[1]);
        Console.WriteLine("Tamanho do vetor idades: " + idades.Length);
    }

    public void printMatriz()
    {
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;

        Console.WriteLine("=====================");
        Console.WriteLine("Matriz: " + matriz);
        Console.WriteLine("matriz[0, 0]: " + matriz[0, 0]);
        Console.WriteLine("matriz[0, 1]: " + matriz[0, 1]);
        Console.WriteLine("Tamanho da matriz: " + matriz.Length);
    }

}
