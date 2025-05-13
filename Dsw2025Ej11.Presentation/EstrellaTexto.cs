using Dsw2025Ej11.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej11.Presentation;

internal class EstrellaTexto
{
    private double _x;
    private double _y;
    public EstrellaTexto()
    {
        
    }

    public void Ubicar(double x, double y)
    {
        _x = x;
        _y = y;
        Dibujar(ConsoleColor.White);
    }

    public void Iluminar(Luminosidad luminosidad)
    {
        if (luminosidad == Luminosidad.Baja)
            Dibujar(ConsoleColor.DarkGray);
        else if (luminosidad == Luminosidad.Media)
            Dibujar(ConsoleColor.Gray);
        else if (luminosidad == Luminosidad.Alta)
            Dibujar(ConsoleColor.Yellow);
        else
            Dibujar(ConsoleColor.Black);
    }

    private void Dibujar(ConsoleColor color)
    {
        var x = (int)(_x * (Console.WindowWidth -2));
        var y = (int)(_y * (Console.WindowHeight-4));
        x = x == 0 ? 2 : x;
        y = y == 0 ? 2 : y;
        Console.ForegroundColor = color;
        Debug.WriteLine($"Ubicando estrella en {x}, {y}");
        Console.SetCursorPosition(x, y);
        Console.Write("*");
    }
}
