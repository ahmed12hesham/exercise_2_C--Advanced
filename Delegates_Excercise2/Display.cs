using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Excercise2
{
    internal class Display
    {
        public void ShowTemprature (object? obj, TempArgs args) 
        {
            Console.WriteLine($"The temprature now set to {args.Temprature} from display");
        }
        public Display() { }    

    }
}
