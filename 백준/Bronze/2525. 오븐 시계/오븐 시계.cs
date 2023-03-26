using System;


namespace Programers_codetest_example
{
	internal class Program
	{
        public static void Main()
		{
            string currentTimeStr = Console.ReadLine();
            string cookingTime = Console.ReadLine();

            string[] currentTimeSplit = currentTimeStr.Split(' ');
            int hour = int.Parse(currentTimeSplit[0]);
            int minute = int.Parse(currentTimeSplit[1]);

            int cookingMinute = int.Parse(cookingTime);

            int cookingHour = cookingMinute / 60;
            cookingMinute = cookingMinute % 60;

            int resultMinute = minute + cookingMinute;
            int resultHour = hour + cookingHour;

            if (resultMinute / 60 > 0)
			{
                resultHour += (resultMinute / 60);
                resultMinute = resultMinute % 60;
            }

            if ( resultHour > 23 )
			{
                resultHour = resultHour % 24;

            }
            
            Console.WriteLine(resultHour + " " + resultMinute);
        }
    }
}