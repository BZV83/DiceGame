using moreC_Fun;
internal class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff("TAG");

        string name = "";

        System.Console.WriteLine("Please enter your name.");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
}