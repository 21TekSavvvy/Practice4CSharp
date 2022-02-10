class SecondsToMinutes
{
    static void Main()
    {
        // input Data
        int inputSeconds = 369121517;
        //Start Calculation til we find days
        int minutes = inputSeconds / 60;
        int hour = minutes / 60;
        int day = hour / 24;

        // Once we have the days, We find the remaining hours, minutes, seconds using modulo
        int finalHour = hour % 24;
        int finalMinute = minutes % 60;
        int finalSecond = inputSeconds % 60;

        // Print Output 
        System.Console.WriteLine(" Conversion from " + inputSeconds + " seconds to " + day + " days, " + finalHour + " hours, " + finalMinute + " minutes, " + finalSecond + " seconds");
        System.Console.ReadKey();
    }
}