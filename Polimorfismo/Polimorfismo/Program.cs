﻿using Polimorfismo;

internal class Program
{
    private static void Main(string[] args)
    {
        var figuras = new List<Figura>
        {
            new Triangulo(),
            new Circulo()
        };

        foreach (var figura in figuras)
            figura.Desenhar();
    }
}