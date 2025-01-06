using System.ComponentModel;
using System.Drawing;

namespace OOP_Ass_1
{


    #region Q01
    //class Point
    //{
    //    double x;
    //    double y;

    //    public double X { get => x; set => x = value; }
    //    public double Y { get => y; set => y = value; }



    //    public override string ToString()
    //    {
    //        return $"({x} , {y})";
    //    }


    //    static public Point CreatePoint()
    //    {
    //        double x1, y1;
    //        bool flag01, flag02;
    //        do
    //        {
    //            Console.WriteLine("Enter X1 Of Point ");
    //            flag01 = double.TryParse(Console.ReadLine(), out x1);

    //            Console.WriteLine("Enter Y1 Of Point ");
    //            flag02 = double.TryParse(Console.ReadLine(), out y1);
    //        } while (!(flag01 && flag02));

    //        Point p01 = new Point();
    //        p01.X = x1;
    //        p01.Y = y1;


    //        return p01;
    //    }
    //    public static double CalcDistance(Point p01, Point p02)
    //    {
    //        double distance = 0;
    //        distance = (Math.Sqrt(Math.Pow(p01.X - p02.X, 2)) + Math.Sqrt(Math.Pow(p01.Y - p02.Y, 2)));
    //        return distance;
    //    }
    //}
    #endregion

    #region MyRegion
    //internal struct Person
    //{
    //    string name;
    //    int age;

    //    public string Name { get => name; set => name = value; }
    //    public int Age { get => age; set => age = value >= 18 && value <= 60 ? value : 18; }

    //    public override string ToString()
    //    {
    //        return $" Name = {name} , Age = {age}";
    //    }

    //    static public Person[] AddPerson(int size)
    //    {
    //        Person[] persons = new Person[size];
    //        for (int i = 0; i < size; i++)
    //        {
    //            persons[i] = new Person();
    //        }

    //        return persons;
    //    }

    //    public static void InsertData(Person[] person)

    //    {
    //        bool flag;
    //        for (int i = 0; i < person.Length; i++)
    //        {
    //            do
    //            {
    //                Console.WriteLine($"Enter the Age Of Person {i + 1}");
    //                flag = int.TryParse(Console.ReadLine(), out person[i].age);
    //            } while (!flag);

    //            do
    //            {
    //                Console.WriteLine($"Enter the Person Name : {i + 1}");
    //                person[i].name = Console.ReadLine();
    //            } while (string.IsNullOrWhiteSpace(person[i].Name));

    //        }
    //    }


    //    public static Person PrintOldest(Person[] person)
    //    {
    //        Person oldest = person[0];
    //        for (int i = 0; i < person.Length; i++)
    //        {
    //            if (person[i].age > oldest.age)
    //            {
    //                oldest.Age = person[i].age;
    //                oldest.Name = person[i].name;
    //            }
    //        }
    //        return oldest;
    //    }
    //}
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q01
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point p01 = Point.CreatePoint();
            //Point p02 = Point.CreatePoint();
            //Console.WriteLine("The Distance Between = "+Point.CalcDistance(p01 , p02));

            #endregion


            #region Q02
            //.Create a struct called "Person" with properties "Name" and "Age". 
            //Write a C# program that takes details of 3 persons as input 
            //from the user and displays the name and age of the oldest person.


            //----****----


            //Person[] person = Person.AddPerson(3);
            //Person.InsertData(person);
            //Console.WriteLine(Person.PrintOldest(person));
            #endregion
        }
    }
}
