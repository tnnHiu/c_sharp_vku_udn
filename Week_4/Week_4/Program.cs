namespace Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connector have not initialize yet: ");
            Connector? connector = Connector.Instance;
            Console.WriteLine(connector);

            //-------------------------------------------
            Console.WriteLine("Initialize connector: ");
            Connector.Initialize("192.168.1.1", 1001);

            //-------------------------------------------
            Console.WriteLine("Connector 1: ");
            Connector? connector1 = Connector.Instance;
            Console.WriteLine(connector1);

            //-------------------------------------------
            Console.WriteLine("Connector 2: ");
            Connector? connector2 = Connector.Instance;          
            Console.WriteLine(connector2);
        }
    }
}
