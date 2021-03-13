using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    /// <summary>
    /// Клас
    /// </summary>
    public class Person
    {
        private int age;
        private string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void IndroduceYourself()
        {
            Console.WriteLine($"I am {this.Name}, {this.Age} years old.");
        }


    }
}
