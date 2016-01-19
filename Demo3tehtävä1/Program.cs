using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new heater object
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 95;
            heater.PrintData();
            Console.ReadLine();
        }
    }
}
