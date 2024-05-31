namespace EstruturaDeDados.Classes;

public class Car
{
    public  string Model { get; set; }

    public MainColor MainColor { get; set; }
    public DateOnly LaunhDate { get; set; }


    public Car(string model, MainColor mainColor, DateOnly launhDate)
    {
        Model = model;
        MainColor = mainColor;
        LaunhDate = launhDate;
    }


    public void CarInfo()
    {
        Console.WriteLine($"Modelo: {Model}");
        Console.WriteLine($"Cor: {MainColor}");
        Console.WriteLine($"Data de Lançamento: {LaunhDate}");
    }   
}
