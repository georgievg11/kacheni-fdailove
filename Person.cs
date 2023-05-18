using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2022
{
    class Person
    {
        private string name;
        private int age;
        public String Name
        {  //реализираме свойство Name
            get { return name; }
            set { name = value; }
        }
        public int Age
        { //реализираме свойство Age
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }
           
    }
}
