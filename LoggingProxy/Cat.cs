using System;

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
