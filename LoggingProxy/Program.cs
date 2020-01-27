namespace LoggingProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICat cat = new Cat("Tom");
            var proxy = LoggingProxy.CreateInstance(cat);
            proxy.eat();
            proxy.Name = "Jerry";
            proxy.Name = "Cookie";
        }
    }
}
