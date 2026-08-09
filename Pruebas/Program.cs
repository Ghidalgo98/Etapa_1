using System;

class Program
{
    static void Main(string[] args)
    {
        var prueba = SeguridadHelper.GenerarHash("Abc123456");
        Console.WriteLine(BitConverter.ToString(prueba));
    }
}