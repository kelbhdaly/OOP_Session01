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
            #region STRUCK

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


            //Point P01 = new Point(10,30);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y); 
            #endregion


            #region OOP
            //OOP : Object Oriented Programming 
            // Programming Paradigm
            // OOP : The Paradigm Use For Build Any Business 


            // Class : Blueprint Of The Object
            // Object : Specific Instance From Class 


            // 4 Pillars
            //=========== 
            // 1. Encapsulation 
            // 2. Inheritance 
            // 3. Ploymorphism 
            // 4. Abstraction 
            #endregion



            //Encapsulation :
            // Class Or Struct 
            // Seperate The Data (Attribute) Definition From Its Use 


            //Apply Encapsultion 
            //1. All Data (Attribute ) Private
            //2. Access Data Through 
            //2.1 Setter Getter Method 
            //2.2 Properties 
            Employee Emp = new Employee(15, "khaled", 155000);
            Console.WriteLine(Emp.ToString());
            //Emp.SetSalary(15555);
            //Emp.SetName("khaled");
            //Emp.SetId(1);
            //Console.WriteLine(Emp.GetId());
            //Console.WriteLine(Emp.GetSalary());
            //Console.WriteLine(Emp.GetName());
            //Emp.id = 1;
            //Emp.name = "Test";
            //Emp.salary = 15000;
            //Console.WriteLine(Emp.id);
            //Console.WriteLine(Emp.salary);
            //Console.WriteLine(Emp.name);
            // End user Access Data Itself
            // No Data Viladation
            // No Read Only Filed






        }
    }
}
