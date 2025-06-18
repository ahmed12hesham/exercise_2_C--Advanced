using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Excercise2
{
    internal class Alarm
    {
        public int AlarmValue { get; set; }  // fresch hold 

        public Alarm(int alarmTemp) 
        {

            AlarmValue = alarmTemp;
        }
        public void SetAlarmValue(int newAlarmValue) 
        {
            AlarmValue = newAlarmValue;
        }
        public void FireAlarm(object? objecct, TempArgs tempArgs)
        {
            if (tempArgs.Temprature > AlarmValue)
            {
                Console.WriteLine($"TAKE CARE, tHE TEMP VALUE {tempArgs.Temprature} is greater than {AlarmValue}");
            }
        }
    }
}
