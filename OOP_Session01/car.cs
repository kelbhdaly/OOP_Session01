using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session01
{
    internal class car
    {

		#region Attributes
		private int id;
		private string name;
		private int speed;
		#endregion

		#region Propeties
		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        #endregion

        //CLR Will Generate Paramterless Constructor
        //public car()
        //{

        //} 
        public car(int id , string name , int speed)
        {
            Id = id;
			Name = name;
			Speed = speed;
        }

    }
}
