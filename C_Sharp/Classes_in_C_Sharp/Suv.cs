namespace Classes_in_C_Sharp
{
    class Suv : Car
    {
        // a child class of abstract class car that overrides the method drive
        public override string Drive()
        {
            return "drive the car on road and off road.";
        }
        // the suv constructor, calling the parent contructor with key word "base"
        // sets additional property of number of wheel drive for suvs. All suvs have 4 wheel drive.
        public Suv(string name, int year_of_production, int engine_power) : base(name, year_of_production, engine_power)
        {
            this.nr_wheel_drive = 4;
        }

    }
}
