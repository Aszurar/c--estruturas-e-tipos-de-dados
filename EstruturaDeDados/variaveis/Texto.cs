using System.Text;

namespace EstruturaDeDados.variaveis;

public class Texto
{
    // Char é guar uma variável com 1 caracter
    char letter = 'a';
    char number = '1';
    char caracter = '@';
    char space = ' ';


    // String nada mais é do que um conjunto de Chars
    static string text = "Este curso é muito bom!";
    char firstLetterOfText = text[0];
    int textLenght = text.Length;


    public void printChars()
    {
        Console.WriteLine(letter);
        Console.WriteLine(number);
        Console.WriteLine(caracter);
        Console.WriteLine(space);
    }

    public void printFirstLetterOfTextAndText()
    {
        Console.WriteLine(text);
        Console.WriteLine(textLenght);
        Console.WriteLine(firstLetterOfText);
    }

    string myName = "     Lucas de Lima      ";
    public void printName()
    {
        string myNameFormatted = myName.Trim();
        Console.WriteLine("-------------------------");

        Console.WriteLine("myName");
        Console.WriteLine(myName);

        Console.WriteLine("myNameFormatted");
        Console.WriteLine(myNameFormatted);
    }

    public void printStartAndEndWith()
    {

        Boolean myNameStartWithLucas = myName.StartsWith("Lucas");
        Boolean myNameEndWithSpace = myName.EndsWith(" ");
        Boolean myNameWithouSpaceStartWithLu = myName.Trim().StartsWith("Lu");
        Console.WriteLine("-------------------------");
        Console.WriteLine("myNameStartWithLucas");
        Console.WriteLine(myNameStartWithLucas);
        Console.WriteLine("myNameEndWithLucas");
        Console.WriteLine(myNameEndWithSpace);
        Console.WriteLine("myNameStartWithLu");
        Console.WriteLine(myNameWithouSpaceStartWithLu);
    }


    public void printReplaceContainsAndEquals()
    {
        String myNewNameWith10 = myName.Replace("a", "10");
        String myNewNameWithSorvete = myName.Replace("ma", " Sorvete ");

        Boolean isMyNameContainsSouza = myName.Contains("Souza");
        Boolean isMyNameContainsLuisa = myName.Contains("Luiza");

        String otherName = "Lucas de Lima Costa";
        Boolean isMyNameEqualsThisName = myName.Equals(otherName);
        string myNameFormatted = myName.Trim();
        Boolean isMyNameEqualsMyNameFormatted = myName.Equals(myNameFormatted);
        Console.WriteLine("-------------------------");
        Console.WriteLine("myName" + myName);
        Console.WriteLine("myNameFormatted " + myNameFormatted);
        Console.WriteLine("myNewNameWith10" + myNewNameWith10);
        Console.WriteLine("myNewNameWithSorvete" + myNewNameWithSorvete);
        Console.WriteLine("isMyNameContainsSouza " + isMyNameContainsSouza);
        Console.WriteLine("isMyNameContainsLuisa " + isMyNameContainsLuisa);
        Console.WriteLine("isMyNameEqualsThisName  " + isMyNameEqualsThisName);
        Console.WriteLine("isMyNameEqualsMyNameFormatted " + isMyNameEqualsMyNameFormatted);
    }


    public void concatStrings()
    {
        string string1 = "A primeira frase.";
        string string2 = "A segunda frase.";

        string concatString = string1 + string2;
        string concatStringWithSpace = string1 + " " + string2;
        string concatStringWithOthersData = string1 + " "  + true + " " + 10 + " " +  string2;

        string concatStringWithInterpolation = $"{string1} {string2}";
        string concatStringWithInterpolationWithOthersData = $"{string1} {true} {10} {string2}";

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(string1);
        stringBuilder.Append(" ");
        stringBuilder.Append(string2);
        string concatStringWithBuilder = stringBuilder.ToString();

        Console.WriteLine("concatString: " + concatString);
        Console.WriteLine("concatStringWithSpace" + concatStringWithSpace);
        Console.WriteLine("concatStringWithOthersData " + concatStringWithOthersData);
        Console.WriteLine("-------------------------");
        Console.WriteLine("concatStringWithInterpolation " + concatStringWithInterpolation);
        Console.WriteLine("concatStringWithInterpolationWithOthersData " + concatStringWithInterpolationWithOthersData);
        Console.WriteLine("-------------------------");
        Console.WriteLine("concatStringWithBuilder " + concatStringWithBuilder);
           


    }
    public void specialsChars()
    {
        string specialCharsEnter = "\notion";
        string specialCharsTab = "\table";
        //string specialCharsSlash = "\teste\lucas\lib\function";

        string sspecialCharsEnterWithSlashFormatted = "\\notion";
        string sspecialCharsTabWithSlashFormatted = "\\table";
        string specialCharsSlashWithSlashFormatted = "\\teste\\lucas\\lib\\function";

        string specialCharsEnterWithFormat = @"\notion";
        string specialCharsTabWithFormat = @"\table";
        string specialCharsSlashWithFormat = @"\teste\lucas\lib\function";


        Console.WriteLine("specialCharsEnter: " + specialCharsEnter);
        Console.WriteLine("specialCharsTab: " + specialCharsTab);
       // Console.WriteLine("specialCharsSlash: " + specialCharsSlash);
        Console.WriteLine("sspecialCharsEnterWithSlashFormatted: " + sspecialCharsEnterWithSlashFormatted);
        Console.WriteLine("sspecialCharsTabWithSlashFormatted: " + sspecialCharsTabWithSlashFormatted);
        Console.WriteLine("specialCharsSlashWithSlashFormatted: " + specialCharsSlashWithSlashFormatted);

        Console.WriteLine("specialCharsEnterWithFormat: " + specialCharsEnterWithFormat);
        Console.WriteLine("specialCharsTabWithFormat: " + specialCharsTabWithFormat);
        Console.WriteLine("specialCharsSlashWithFormat: " + specialCharsSlashWithFormat);

    }

    public void insertStringData() {
        string goodMorning = "Bom dia, Lucas de Lima, hoje é um ótimo dia para ir à praia";

        string goodMorningMutable = "Bom dia, {0}, hoje é um ótimo dia para {1}";

        string goodMorningMutableResult1 = string.Format(goodMorningMutable, "Lucas de Lima", "ir à praia");
        string goodMorningMutableResult2 = string.Format(goodMorningMutable, "Luiza", "estudar");
        string goodMorningMutableResult3 = string.Format(goodMorningMutable, "Eduardo", "trabalhar");

        Console.WriteLine($"goodMorning: {goodMorning}");
        Console.WriteLine($"goodMorningMutable: {goodMorningMutable}");
        Console.WriteLine($"goodMorningMutableResult1: {goodMorningMutableResult1}");
        Console.WriteLine($"goodMorningMutableResult2: {goodMorningMutableResult2}");
        Console.WriteLine($"goodMorningMutableResult3: {goodMorningMutableResult3}");
    }
}
