internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Console.ReadLine();
    }
    public static void Task1()
    {
        double l, r;
        r = 2;
        l = 2 * Math.PI * r;
        Console.WriteLine(l);
    }
    public static void Task2()
    {
        double s, r;
        r = 2;
        s = Math.PI * r*r;
        Console.WriteLine(s);
    }
    public static void Task3()
    {
        int a, b, c, d;
        a = 5;
        b = 3;
        c = 45;
        d = a + b + c;
        Console.WriteLine(d);
    }
    public static void Task4()
    {
        int a = 3;
        int b = 8;
        int c = a;
        a = b;
        b = c;

        Console.WriteLine("a= " + a);
        Console.WriteLine("b= " + b);
    }
    public static void Task5()
    {
        double a, b, c, d;
        a = 4;
        b = 7;
        c = 10;
        d = a * b % c;
        Console.WriteLine(d);
    }
}