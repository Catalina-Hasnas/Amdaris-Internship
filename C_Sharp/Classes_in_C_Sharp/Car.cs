using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_in_C_Sharp
{
    abstract class Car: iDriveable

    {
        public string name;
        protected int year_of_production;
        public int engine_power;
        public int nr_wheel_drive;

        // year of production can be read by anyone, but can't be set outside of car class and child classes.

        public int Year_of_production { get => year_of_production; }

        // read-only property, calculated at the moment of accesing the property (age of car)
        public int age_of_car {
            get {
                if (Year_of_production == 2021)
                {
                    return 1;
                }
                return 2021 - year_of_production;
            }
        }

        // car is implementing iDriveable interface, so it must have drive, turn and get information methods.
        public virtual string Drive()
        {
            return "drive the car on road";
        }
        // this method is virtual, so that it can be overriden by child classes
        public string Turn()
        {
            return "turn the wheel left or right";
        }
        public string GetInformation()
        {
            return name +
                "\n year of production: " + year_of_production +
                ", engine power: " + engine_power +
                ", number of wheel drive: " + nr_wheel_drive +
                ", age of the car: " + age_of_car;
        }

        // this abstract clss has a constructor with cars' common proprieties.

        public Car(string name, int year_of_production, int engine_power)
        {
            this.name = name;
            this.year_of_production = year_of_production;
            this.engine_power = engine_power;
        }
        
    }
}
