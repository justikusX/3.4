Console.WriteLine("┌-----------------------------------------------------------┐");
Console.WriteLine($"|        x          |         u         |         f         |");
Console.WriteLine("|-----------------------------------------------------------|");
for (double x = 0; x <= 4; x += 0.4)
{    
    double f = 0;
    double u = 0;
    if (x <= 1.5)
    {
        u += Math.Pow(x, 2) - x + 1;
        f = 1.5 + Math.Log(Math.Abs(Math.Sin(u)));
    }
    if (x > 1.5 && x <= 2.5)
    {
        u += Math.Atan(x);
        f = 1.5 + Math.Log(Math.Abs(Math.Sin(u)));
    }
    else 
    {
        u += Math.Pow(Math.Sin(x - 1), 3) + Math.Cos(x + 1);
        f = 1.5 + Math.Log(Math.Abs(Math.Sin(u)));
    }
    Console.WriteLine($"|       {x,-5:F2}       |       {u,5:F2}       |       {f,5:F2}       |");
}
Console.WriteLine("└-----------------------------------------------------------┘");
Console.WriteLine();