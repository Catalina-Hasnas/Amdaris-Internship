namespace Classes_in_C_Sharp
{
    class Sedan : Car
    {
        // a child class of abstract class car that doesn't override any methods.
      
        // the sedan constructor, calling the parent contructor with key word "base"
        // sets additional property of number of wheel drive for sedans. Default is 2.

        public Sedan(string name, int year_of_production, int engine_power, int nr_wheel_drive = 2) : base(name, year_of_production, engine_power)
        {
            this.nr_wheel_drive = nr_wheel_drive;
        }
    }
}
