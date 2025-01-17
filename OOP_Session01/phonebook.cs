﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session01
{
    internal struct phonebook
    {
        string[] names;
        long[] numbers;

        public phonebook(int size)
        {
            names= new string[size];
            numbers= new long[size];
        }
        public void AddPerson(int Index , string name , long number)
        {
            names[Index] = name;
            numbers[Index] = number;
        }
        public long GetNumber (string name)
        {
            for (int i =0; i<names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i]; 
            }
            return 0;
        }

        public void UpdateNumber(string name , long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name )
                {
                    numbers[i] = number;    

                }
            }
        }
    }
}
