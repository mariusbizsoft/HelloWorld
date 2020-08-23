using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }


        // member method
        public void InroduceMyself()
        {
            if(age != 0)
                Console.WriteLine($"Hi, I'm {firstName} {lastName} and I'm {age} years old and my eye color is {eyeColor}");
            else
                Console.WriteLine($"Hi, I'm {firstName} {lastName} and my eye color is {eyeColor}");
        }

    }
}
