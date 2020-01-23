using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingProxy
{
    public class Cat : ICat
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public void eat()
        {
            Console.WriteLine("EAT!");
        }
    }
}
