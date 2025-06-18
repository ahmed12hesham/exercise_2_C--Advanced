using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Excercise2
{
    internal class TempArgs : EventArgs
    {
        public int Temprature { get; set; }
        public TempArgs(int temp) 
        {
            Temprature = temp;
        }
    }
}
