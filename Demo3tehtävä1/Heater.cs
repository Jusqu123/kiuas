﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// just testing some saving but its not working
namespace Demo3tehtävä1
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }


        //method prints heater data
        public void PrintData()
        {

            Console.WriteLine("Heater : ");
            Console.WriteLine("- Temperature :{0} Humidity {1}: IsOn: {2} ",Temperature,Humidity,IsOn);
         
        }
        // method returns heater data
        public override string ToString()
        {
            return "Temperature :" + Temperature + "humidity : " + Humidity + "IsOn : " + IsOn;
        }
    }
}
