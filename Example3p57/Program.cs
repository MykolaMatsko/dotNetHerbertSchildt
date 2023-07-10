namespace Example3p57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ivar;
            double dvar;

            ivar = 100;

            dvar = 100.0;

            Console.WriteLine("ivar before: " + ivar);
            Console.WriteLine("dvar before: " + dvar);

            Console.WriteLine();

            ivar = ivar / 3;
            dvar = dvar / 3;

            Console.WriteLine("ivar after: " + ivar);
            Console.WriteLine("dvar after: " + dvar);

        }
    }
}