using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session01
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region Apply Encapsultion User Setter Getter Method 
        ////Setter 
        //public void SetId (int id)
        //{
        //    this.id = id;

        //}

        ////Getter
        //public int GetId ()
        //{
        //    return id;
        //}

        ////Setter Name
        //public void SetName(string name)
        //{
        //    this.name = name;

        //}


        ////Getter Name

        //public string GetName()
        //{
        //    return name;

        //}



        ////Setter Salary

        //public void SetSalary(double salary)
        //{



        //    this.salary = salary;
        //}

        ////Getter Salary

        //public double GetSalary()
        //{
        //    return salary;
        //}

        //public Employee (int id , string name , double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}

        //public override string ToString()
        //{
        //    return $"Name is {name} :: Salary is {salary}  ";
        //} 
        #endregion

        //Apply Encapsultion Use Properties 

        // 1. Full Properties
        public int Id
        {
            set
            {
                id= value;
            }
            get
            {
                return id;
            }



        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if (value > 0)
                salary = value;
            }
            get
            {
                return salary;
            }
        }

        // 2. Special Properties

        public string Address { set; get; }

        // 3. Automitic
    }
}
