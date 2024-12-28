namespace OOP_Session01
{


    //1. Class 
    //2. Enum 
    //3. Interface
    //4. Struct
    internal class Program
    {
        static void Main(string[] args)
        {
            //Struct : Value Data Type  : STACK

            //Point 

            //Point P01;
            //P01 = new Point();
            //Console.WriteLine(P01.X); // 0 : Defult Value 
            //Console.WriteLine(P01.Y); // 0 : Defult Value 

            //Declare For Object From Type 'Point'
            // P01 : Object 
            // Allocate UnInitialize 8 Bytes At Stack 

            //Console.WriteLine(P01.X);

            //Console.WriteLine(P01.Y); // UnAssigient

            //P01.X = 12;
            //P01.Y = 12;

            //Point P01;
            //P01 = new Point();
            //Console.WriteLine(P01.X); // 10
            //Console.WriteLine(P01.Y); // 10


            Point P01 = new Point(10,30);
            Console.WriteLine(P01.X);
            Console.WriteLine(P01.Y);
        }
    }
}
