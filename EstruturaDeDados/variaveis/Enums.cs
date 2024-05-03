namespace EstruturaDeDados.variaveis;

public class Enums
{

    // Enums são tipos de dados que consistem em um conjunto de constantes nomeadas chamadas de membros do enum.
    // Um conjunto de opções, geralmente usamos para agrupar opções relacionadas.
    // Cada opção deve ser única, são constantes, ou seja, auziliares para facilitar a leitura do código.

    public enum NivelDedificuldade
    {
        Facil = 123,
        Medio = 987,
        Dificil = 567
    }

    public void printNivelDificuldade()
    {
        NivelDedificuldade facil = NivelDedificuldade.Facil;
        NivelDedificuldade medio = NivelDedificuldade.Medio;
        NivelDedificuldade dificil = NivelDedificuldade.Dificil;

        int nivelFacil = (int)facil;
        int nivelMedio = (int)medio;
        int nivelDificil = (int)dificil;

        Console.WriteLine("Enum fácil: " + facil);
        Console.WriteLine("Enum médio: " + medio);
        Console.WriteLine("Enum difícil: " + dificil);

        Console.WriteLine("Enum valor fácil: " + nivelFacil);
        Console.WriteLine("Enum valor médio: " + nivelMedio);
        Console.WriteLine("Enum difícil: " + nivelDificil);
    }

}
