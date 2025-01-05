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


            #region Encapsulation

            #region Encapsulation DEF
            //Encapsulation :
            // Class Or Struct 
            // Seperate The Data (Attribute) Definition From Its Use 


            //Apply Encapsultion 
            //1. All Data (Attribute ) Private
            //2. Access Data Through 
            //2.1 Setter Getter Method 
            //2.2 Properties  
            #endregion


            #region Apply Encapsultion User Setter Getter Method 

            //Employee Emp = new Employee(15, "khaled", 155000);
            //Console.WriteLine(Emp.ToString());

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


            depart dep = new depart();
            //dep.Address = "aaaaaaaaaaaaa";
            //dep.Id = 5;
            //dep.Name = "khaled";
            #endregion


            #region Encapsulation Properties


            //Employee Emp01 =new Employee();
            //Emp01.Id = 5;
            //Emp01.Name = "khaled";
            //Emp01.Salary = 200000000;




            #endregion



            #endregion



            //phonebook b01= new phonebook(3);
            //b01.AddPerson(0, "khaled", 1111);
            //b01.AddPerson(1, "ali", 2222);
            //b01.AddPerson(2, "ahmed", 3333);

            //Console.WriteLine(b01.GetNumber("k")); 

            car c01;
            //declare for refernce(pointer) from type 'car' 
            //c01 : can refer to object from type car or any class inhertant
            // c01 : refer null

            // 8 byte stack
            // 0 byte heap
            c01 = new car(1 , "khaled" , 150000);
            // allocate a number of required 18 byte 
            // initailized by defult value
            // call user-defined constructor if exists
            // assign object to reference

        }
    }
}
