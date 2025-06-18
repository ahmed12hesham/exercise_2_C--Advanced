namespace Delegates_Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sensor => Adjust temp [input temp]
            // Display
            // Alarm
            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm(20);

            // subscribtion
            sensor.SensorChanged += display.ShowTemprature; 
            sensor.SensorChanged += alarm.FireAlarm;

            while (true)
            {
                Console.WriteLine("Welcome to the temperature system");
                Console.WriteLine("1. Set the Temperature");
                Console.WriteLine("2. Set the Alarm value");
                Console.WriteLine("3. Exit");

                var result = Console.ReadLine();
                switch (result) 
                {
                    case "1":
                        Console.WriteLine("Please enter the temprature value in degrees ! ");
                        var temp = Console.ReadLine();
                        int tempValue = Convert.ToInt32(temp);
                        sensor.ChangeTemprature(tempValue);
                        break;
                    case "2" :
                        Console.WriteLine("Please enter the temprature value for the alarm ! ");
                        var alarmString = Console.ReadLine();
                        int alarmValue = Convert.ToInt32(alarmString);
                        alarm.SetAlarmValue(alarmValue);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Wrong input, Please enter the correct value !");
                        break;
                }
            }
            


        }
    }
}
