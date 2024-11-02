using System;

abstract class FiguraGeometrica
{
    public abstract double CalcularArea();
}

class Rectangulo : FiguraGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

class Cuadrado : FiguraGeometrica
{
    public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        FiguraGeometrica rectangulo = new Rectangulo { Base = 5, Altura = 4 };
        FiguraGeometrica cuadrado = new Cuadrado { Lado = 4 };

        Console.WriteLine("Área del Rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Área del Cuadrado: " + cuadrado.CalcularArea()); 
    }
}
