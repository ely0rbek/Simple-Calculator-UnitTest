

double a = 465, b = 45;

Console.WriteLine(Matem.Qoshish(a,b));
Console.WriteLine(Matem.Ayirish(a,b));
Console.WriteLine(Matem.Kopaytirish(a,b));
Console.WriteLine(Matem.Bolish(a,b));

public static class Matem
{
    public static double Qoshish(double a, double b) => a + b;
    public static double Ayirish(double a, double b) => a - b;
    public static double Kopaytirish(double a, double b) => a * b;
    public static double Bolish(double a, double b) => a / b;
}