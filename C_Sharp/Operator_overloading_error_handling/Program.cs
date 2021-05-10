using System;
using System.Threading;

namespace Operator_overloading_error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
//#if DEBUG
//            Console.WriteLine("Debug version");
//#endif
//#if RELEASE
//            Console.WriteLine("Release version");
//#endif
            Angle a = new Angle(10, 36, 46);
            Angle b = "4d 27' 45\"";
            var c = a + b;
            Angle result = new Angle(a.degrees + b.degrees, a.minutes + b.minutes, a.seconds + b.seconds);
            Console.WriteLine("Result 1 = {0}", (string)result);
            Console.WriteLine("Result 2 = {0}", (string)c);
        }

        //            Angle canFail = new Angle();
        //            string input = "";

        //            bool succces = false;
        //            while (!succces)
        //            {
        //                try
        //                {
        //                    Console.WriteLine("Give an angle:");
        //                    input = Console.ReadLine();
        //                    canFail = input;
        //                    succces = true;
        //                }
        //                catch (ArgumentOutOfRangeException ex)
        //                {
        //                    Console.WriteLine("Try again, error message:");
        //                    Console.WriteLine(ex.Message);
        //                }
        //                catch (ArgumentException ex)
        //                {
        //                    Console.WriteLine("Invalid input, prefered input: 0d 0' 0\"");
        //#if DEBUG
        //                    Console.WriteLine(ex.Message);
        //#endif

        //                    throw new InvalidInputException(message: "User input from main failed casting to Angle",
        //                                                    inner: ex,
        //                                                    userInput: input);
        //                }
        //                finally
        //                {
        //                    Console.WriteLine("\n\n\nClean-up finished. Closed.\n\n\n");
        //                }
        //            }
        //            Console.WriteLine("You introduced: {0}", (string)canFail);
        //        }
        //    }

        //class InvalidInputException : Exception
        //{
        //    public string UserInput { get; }

        //    public InvalidInputException()
        //    {
        //    }

        //    public InvalidInputException(string message)
        //        : base(message)
        //    {
        //    }

        //    public InvalidInputException(string message, Exception inner)
        //        : base(message, inner)
        //    {
        //    }
        //    public InvalidInputException(string message, Exception inner, string userInput)
        //        : base(message, inner)
        //    {
        //        this.UserInput = userInput;
        //    }
        //}
        struct Angle
        {
            public int degrees;
            public int minutes;
            public int seconds;


            public Angle(int degrees = 0, int minutes = 0, int seconds = 0)
            {
                ValidateArgs(degrees, minutes, seconds);

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

                foreach (string number in numbers)
                {
                    switch (number[^1]) // equals to number[number.Length - 1]
                    {
                        case 'd':
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
                ValidateArgs(degrees, minutes, seconds);
            }

            public static explicit operator string(Angle a)
            {
                return $"{a.degrees}d {a.minutes}' {a.seconds}\"";
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

            public static void ValidateArgs(int degrees, int minutes, int seconds)
            {
                if (seconds >= 60 || minutes >= 60)
                {
                    throw new ArgumentOutOfRangeException("seconds and minutes can't have a value larger than 59");
                }

                else if (seconds < 0 || minutes < 0 || degrees < 0)
                {
                    throw new ArgumentOutOfRangeException("can't have negative values");
                }
            }
        }
    }
}
