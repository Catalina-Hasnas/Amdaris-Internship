using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_C_Sharp
{
    class Motorcycle : iDriveable
    {
        public string name;
        public int year_of_production;
        public double engine_power;

        // motorcycle is implementing iDriveable interface, so it must have drive, turn and get information methods.
        public string Drive()
        {
            return "drive the motorcycle on road";
        }

        public string Turn()
        {
            return "turn the handlebars left or right";
        }

        public string GetInformation()
        {
            return name +
                "\n year of production: " + year_of_production +
                ", engine power: " + engine_power;
        }
        // the constructor of the motorcycle class
        public Motorcycle(string name, int year_of_production, int engine_power)
        {
            this.name = name;
            this.year_of_production = year_of_production;
            this.engine_power = engine_power;
        }
        
    }
}
