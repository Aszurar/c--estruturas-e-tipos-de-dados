using EstruturaDeDados.Classes;
using EstruturaDeDados.EstruturaDeControle;
using EstruturaDeDados.EstruturaDeRepeticao;
using EstruturaDeDados.EstruturasJumps;
using EstruturaDeDados.funcoes;
using EstruturaDeDados.variaveis;

namespace EstruturaDeDados;

class Program
{
    static void Main()
    {
        /*
           Numeros numeros = new Numeros();
           numeros.ImprimirNumerosInteiro();
           numeros.ImprimirNumerosQuebrados();
        */

        /*
           Booleanos dispositivo = new Booleanos();

           if (dispositivo.ativo)
           {
               Console.WriteLine("Dispositivo ativado");
           }
          if (dispositivo.desativado) 
           {
               Console.WriteLine("Dispositivo desativado");
           }
        */

        /*
        Texto texto = new Texto();
        texto.printChars();
        texto.printFirstLetterOfTextAndText();
        texto.printName();
        texto.printStartAndEndWith();
        texto.printReplaceContainsAndEquals();
        texto.specialsChars();
        texto.concatStrings();
        texto.insertStringData();
        */

        /*
        Datas datas = new Datas();
        datas.printDates(); 
        datas.printDateTime();
        */

        /*
        Enums nivelEnum = new Enums();
        nivelEnum.printNivelDificuldade();
        */

        /*
        var variaveisImplicitas = new VariaveisImplicitas();
        variaveisImplicitas.printVariaveisImplicitas();
     

        var variaveisNulas = new Nulo();
        variaveisNulas.printNulo();
       

        var vetores = new Vetores();
        vetores.printVetores();
        vetores.printMatriz();
       

        var listas = new Listas();
        listas.printList();
        listas.printListWithRemove();
        listas.printFrase();

        var dicionarios = new Dicionarios();
        dicionarios.printDicionario();
        
        var hashSetListaUnica = new HashSetListaUnica();
        hashSetListaUnica.printListaUnica();

        var calculadora = new Calculadora();

        calculadora.Somar(10, 5);
        calculadora.Subtrair(10, 5);

        calculadora.Somar(value1: 20, value2: 25);
        calculadora.Subtrair(value1: 20, value2: 25);

        var resultadoDivisao = calculadora.DividirInteiro(value1: 10, value2: 2);
        Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");

        var resultadoMultiplicacao = calculadora.Multiplicar(value1: 10, value2: 5);
        Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplicacao}");

        calculadora.FuncaoOpcional(10);
        */

        /*
        var car = new Car();

        car.ModelName();
        Console.WriteLine("---------------------------------------------");
        car.Model = "Fusca";
        car.MainColor = MainColor.Black;
        car.LaunhDate = new DateOnly(2021, 10, 10);

        car.ModelName();

        Console.WriteLine("---------------------------------------------");

        var car2 = new Car
        {
            Model = "Mercedes",
            MainColor = MainColor.Blue,
            LaunhDate = new DateOnly(2024, 02, 09)
        };

        car2.ModelName();

        var car = new Car("Fusca", MainColor.Black, new DateOnly(2021, 10, 10));
        car.CarInfo();

                 

        var resultado = ClasseTeste.Adicionar(value1: 10, value2: 5);
        Console.WriteLine($"O resultado da soma é: {resultado}");

        var test = new ClasseTeste();

        int intNumber = 10;
        var car = new Car("Fusca", MainColor.Black, new DateOnly(2021, 10, 10));

        var controle = new Controle();

        controle.EstruturaDeControle();
        controle.IfTernario();
        controle.EstruturaSwitch();
        controle.EstruturaSwitchTernario();
        

        var estruturaFor = new EstruturaFor();

        estruturaFor.ForSimples();
        Console.WriteLine("-------------------------------------------------");

        estruturaFor.ForeachSimples();
        Console.WriteLine("-------------------------------------------------");

        estruturaFor.ForeachDictionary();

        var estruturaWhile = new EstruturaWhile();

        estruturaWhile.WhileSimples();
        estruturaWhile.DoWhileSimples();
      
        var estruturasJumps = new EstruturasJumps.EstruturasJumps();

        //estruturasJumps.EstruturaBreak();
        //estruturasJumps.EstruturaContinue();
        // estruturasJumps.EstruturaReturn();
          */

        var listas = new Listas();
        listas.printListWithRemove();
    }
}