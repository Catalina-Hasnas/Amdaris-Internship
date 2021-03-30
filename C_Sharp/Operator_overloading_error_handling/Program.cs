using System;

namespace Operator_overloading_error_handling
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle a = new Angle(3, 36, 53);
            Angle b = "4g 27' 45\"";

            Angle c = a + b;

            //Angle result = new Angle(a.degrees + b.degrees, a.minutes + b.minutes, a.seconds + b.seconds);

            //Console.WriteLine("Result 1 = {0}", (string)result);
            Console.WriteLine("Result 2 = {0}", (string)c);

            Angle willFail;

            try
            {
                willFail = "4d";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new TypeInitializationException(fullTypeName: "Angle", innerException: ex);
            }

        }
    }
    struct Angle
    {
        public int degrees;
        public int minutes;
        public int seconds;

        public Angle(int degrees = 0, int minutes = 0, int seconds = 0)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Angle(string str = "0g 0' 0\"")
        {
            degrees = 0;
            minutes = 0;
            seconds = 0;
            string[] numbers = str.Split(" ");

            foreach(string number in numbers)
            {
                switch (number[^1]) // equals to number[number.Length - 1]
                {
                    case 'g':
                        degrees = int.Parse(number.Remove(number.Length - 1));
                        break;
                    case '\'':
                        minutes = int.Parse(number.Remove(number.Length - 1));
                        break;
                    case '\"':
                        seconds = int.Parse(number.Remove(number.Length - 1));
                        break;

                    default:
                        throw new ArgumentException("Your data does not match the required pattern");
                }
            }
        }

        public static explicit operator string(Angle a)
        {
            return $"{a.degrees}g {a.minutes}' {a.seconds}\"";
        }

        public static implicit operator Angle(string str)
        {
            return new Angle(str);
        }

        public static Angle operator +(Angle a, Angle b)
        {
            int deg = a.degrees + b.degrees;
            int min = a.minutes + b.minutes;
            int sec = a.seconds + b.seconds; 

            while (sec >= 60)
            {
                min++;
                sec = sec - 60;
            }

            while (min >= 60)
            {
                deg++;
                min = min - 60;
            }

            return new Angle(deg, min, sec);
        }
    }
}
