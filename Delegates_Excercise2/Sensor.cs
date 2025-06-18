using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Excercise2
{
    internal class Sensor
    {
        // Declare event
        public event EventHandler<TempArgs> SensorChanged;
        public int CurrentTemprature {  get; set; }
        public void ChangeTemprature(int newTemprature)
        {
            CurrentTemprature = newTemprature;
            SensorChanged.Invoke(this, new TempArgs(newTemprature));
        }
    }
}
