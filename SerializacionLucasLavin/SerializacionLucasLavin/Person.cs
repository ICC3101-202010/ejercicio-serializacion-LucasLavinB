using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacionLucasLavin
{
    [Serializable]
    public class Person
    {
        private string name;
        private string lastName;
        private int age;



        Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
