using System.Globalization;

namespace EstruturaDeDados.variaveis;

public class Datas
{

    DateOnly defaultDate = new DateOnly();
    static DateOnly currentDefaultDateFormat = new DateOnly(2024, 05, 26);
    string dateShortString = currentDefaultDateFormat.ToShortDateString();
    string dateLongStringWithFormat = currentDefaultDateFormat.ToLongDateString();
    string dateStringPTBR = currentDefaultDateFormat.ToString(new CultureInfo("pt-BR"));
    string dateStringPTBRCustomFormat = currentDefaultDateFormat.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));


    DateTime dateWithTime = new DateTime(2024, 04, 26);
    DateTime dateWithTimeSpecific = new DateTime(2024, 04, 26, 10, 30, 00);
    DateTime currentDateTime = DateTime.Now;
    DateTime currentDateTimeToday = DateTime.Today;
    static DateTime currentDateTimeUTC = DateTime.UtcNow; //Data e hora atual em UTC - universal
    // salve no banco sempre em UTC
    DateTime newDateAdded1Day = currentDateTimeUTC.AddDays(1);
    DateTime newDateAdded1Month = currentDateTimeUTC.AddMonths(1);
    DateTime newDateAdded1Year = currentDateTimeUTC.AddYears(1);
    DateTime newDateAdded1Hour = currentDateTimeUTC.AddHours(1);
    DateTime newDateAdded1Minute = currentDateTimeUTC.AddMinutes(1);

    public void printDates()
    {
        Console.WriteLine("defaultDate: " + defaultDate);
        Console.WriteLine("currentDefaultDateFormat: " + currentDefaultDateFormat);
        Console.WriteLine("dateShortString: " + dateShortString);
        Console.WriteLine("dateLongStringWithFormat: " + dateLongStringWithFormat);
        Console.WriteLine("dateStringPTBR: " + dateStringPTBR);
        Console.WriteLine("dateStringPTBRCustomFormat: " + dateStringPTBRCustomFormat);
    }

    public void printDateTime() { 
        Console.WriteLine("dateWithTime: " + dateWithTime);
        Console.WriteLine("dateWithTimeSpecific: " + dateWithTimeSpecific);
        Console.WriteLine("currentDateTime: " + currentDateTime);
        Console.WriteLine("currentDateTimeToday: " + currentDateTimeToday);
        Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);

        Console.WriteLine("newDateAdded1Day: " + newDateAdded1Day);
        Console.WriteLine("newDateAdded1Month: " + newDateAdded1Month);
        Console.WriteLine("newDateAdded1Year: " + newDateAdded1Year);
        Console.WriteLine("newDateAdded1Hour: " + newDateAdded1Hour);
        Console.WriteLine("newDateAdded1Minute: " + newDateAdded1Minute);
    }

}
