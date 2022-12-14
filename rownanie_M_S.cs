using System;
namespace rownanie_szescienne_M_Smolen
{
   class Program
{
 static void Main(string[] args)
{
    Console.WriteLine("Równanie sześcienne o postaci: ax^3+bx^2+cx+d");
    Console.WriteLine("Podaj współrzedne a, b, c, d pokolei odzielone znakiem Enter.");
    double a1;
    double b1;
    double c1;
    double d1;
    while (!double.TryParse(Console.ReadLine(), out a1)){}
        double a = a1;
    while (!double.TryParse(Console.ReadLine(), out b1)){}
        double b = b1;
    while (!double.TryParse(Console.ReadLine(), out c1)){}
        double c = c1;
    while (!double.TryParse(Console.ReadLine(), out d1)){}
        double d = d1;
    double w = (-b / (3 * a));
    double p = ((3 * a * Math.Pow(w, 2)) + (2.0 * b * w) + c) / a;
    double q = ((a * Math.Pow(w, 3)) + (b * Math.Pow(w, 2)) + (c * w) + d) / a;
    double delta = (Math.Pow(q, 2.0) / 4.0) + (Math.Pow(p, 3) / 27.0);
 if (delta > 0)
{
    Console.WriteLine("Delta > 0: Jeden pierwiastek rzeczywisty i Dwa pierwiastki urojone");
    double u = Math.Cbrt((q / -2.0) + Math.Sqrt(delta));   
    double v = Math.Cbrt((-q / 2.0) - Math.Sqrt(delta));
    double x1 = u + v + w;
    double x2r = (u + v) / -2.0 + w;
    double xi = (Math.Sqrt(3.0) / 2.0) * (u - v);
    Console.WriteLine("x1=" + Math.Round(x1, 3));
    Console.WriteLine("x2=" + Math.Round(x2r, 3) + "+" + Math.Round(xi, 3) + "i");
    Console.WriteLine("x3=" + Math.Round(x2r, 3) + "-" + Math.Round(xi, 3) + "i");
}
 if (delta < 0)
{
    Console.WriteLine("Delta < 0: Trzy pierwiastki rzeczywiste;");
    double fi = Math.Acos((3 * q) / (2 * p * Math.Sqrt(-p / 3.0)));
    double x1 = w + 2 * Math.Sqrt(-1 * (p / 3.0)) * Math.Cos(fi / 3.0);
    double x2 = w + 2 * Math.Sqrt(-1 * (p / 3.0)) * (Math.Cos((fi / 3.0) + (Math.PI * 2.0 / 3.0)));
    double x3 = w + 2 * Math.Sqrt(-1 * (p / 3.0)) * (Math.Cos((fi / 3.0) + (Math.PI * 4.0 / 3.0)));
    Console.WriteLine("x1= "+Math.Round(x1,3));
    Console.WriteLine("x2= "+Math.Round(x2,3));
    Console.WriteLine("x3= "+Math.Round(x3,3));
 }
 if (delta == 0)
{
    Console.WriteLine("Delta = 0: Dwa pierwiastki rzeczywiste (Jeden z pierwiastków jest podwójny)");
    double x1 = w - 2 * Math.Pow(q / 2, 1 / 3.0);
    double x2 = w + Math.Pow(q / 2, 1 / 3.0);
    Console.WriteLine("x1= "+ Math.Round(x1, 3));
    Console.WriteLine("x2&x3 "+ Math.Round(x2, 3));
}
}
}
}
