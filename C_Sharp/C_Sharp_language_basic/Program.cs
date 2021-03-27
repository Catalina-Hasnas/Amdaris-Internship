using System;

namespace C_Sharp_language_basic
{
    public struct Point
    {
        public int X;
        public int Y;
    }

    // this is a struct. it is a value type.

    public class PointClass
    {
        public int X;
        public int Y;
    }

    // this is a class. it is a reference type.

    class Program
    {

        static void Main(string[] args)
        {

            int i = 123;
            object o = i;

            //Console.WriteLine(o is object);

            o = 2;

            //Console.WriteLine(o);

            // Will log true and 2, because we've boxed i and is now a reference type, so it was changed to 2.

            o = 123;
            i = (int)o;

            //Console.WriteLine(i is int);

            i = 3;
            int a = i;
            a = 20;

            //Console.WriteLine(i);

            // Will log true and 3. We've unboxed i and is now a value type.

            // int a has another location in the memory, so int i stays the same.

            double decimalNum = 5.55;
            bool isTrue = true;
            string str = "string";

            Sum(i, decimalNum, str);

            CreateClassPoint();
            CreatePoint();


            Console.WriteLine(ConstructorExample.unInitVar);
            ConstructorExample constructorExample = new ConstructorExample();
            Console.WriteLine(ConstructorExample.unInitVar);

            // first, it will initialize the variable in the static constructor. 
            // after we've called the ConstructorExample the second time, the variable will initialize in the public constructor.
        }

        static void Sum(int num, double decimalNum, string str)
        {
            double result = num + decimalNum;
            Console.WriteLine(result + "is not a " + str);

            // we can add an int and a double, if we specify that the result will be of type double. 
            // will log 8.55 is not a string
        }

        static void CreateClassPoint()
        {
            PointClass pointClass = new PointClass()
            {
                X = 3,
                Y = 10
            };
            ChangeValuesOfPointClass(pointClass);
            Console.WriteLine("new values:" + pointClass.X + ", " + pointClass.Y);
            // will log 2 and 9, since PointClass is a reference type.
        }

        static void CreatePoint()
        {
            Point point = new Point()
            {
                X = 3,
                Y = 10
            };

            ReadOnlyValues(in point);
            // will log 3 and 10 are read only values.
            ChangeValuesWithoutRef(point);
            Console.WriteLine("values without ref:" + point.X + ", " + point.Y);
            // will log 3 and 10, because we've passed parameters by values.
            ChangeValuesWithRef(ref point);
            Console.WriteLine("values with ref:" + point.X + ", " + point.Y);
            // will log 2 and 9, because we've passed parameters by reference.

            Point nonInitializedPoint;
            ChangeUnitializedValueswithOut(out nonInitializedPoint);
            Console.WriteLine("values with out:" + nonInitializedPoint.X + ", " + nonInitializedPoint.Y);
            // will log 2 and 9. out works the same as ref, but we must initialize the values in the method.

        }

        static void ReadOnlyValues(in Point point)
        {
            Console.WriteLine(point.X + " and " + point.Y + " are read only values");
        }

        static void ChangeValuesWithoutRef(Point point)
        {
            int x = point.X - 1;
            int y = point.Y - 1;
            point.X = x;
            point.Y = y;
        }

        static void ChangeValuesWithRef(ref Point point)
        {
            int x = point.X - 1;
            int y = point.Y - 1;
            point.X = x;
            point.Y = y;
        }

        static void ChangeUnitializedValueswithOut(out Point nonInitializedPoint)
        {
            nonInitializedPoint = new Point()
            {
                X = 150,
                Y = 160
            };

            nonInitializedPoint.X = nonInitializedPoint.X - 1;
            nonInitializedPoint.Y = nonInitializedPoint.Y - 1;

        }

        static void ChangeValuesOfPointClass(PointClass pointClass)
        {
            int x = pointClass.X - 1;
            int y = pointClass.Y - 1;
            pointClass.X = x;
            pointClass.Y = y;
        }

        class ConstructorExample
        {
            static public string unInitVar;
            static ConstructorExample()
            {
                Console.WriteLine("Static constructor working");
                unInitVar = "initialized in static constructor";
            }

            public ConstructorExample()
            {
                Console.WriteLine("Class creating object constructor working");
                unInitVar = "initialized in static Class creating object";
            }
        }

    }
}
