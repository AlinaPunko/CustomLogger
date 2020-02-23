namespace LoggingProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICat cat = new Cat("Tom");
            ICat proxy = LoggingProxy.CreateInstance(cat);
            proxy.Eat();
            proxy.Name = "Jerry";
            proxy.Name = "Cookie";
        }
    }
}
