using Dsw2025Ej11.Domain;

namespace Dsw2025Ej11.Presentation;

internal class VistaPrincipal
{
    private static Constelacion _constelacion = new("Osa Mayor");
    public static void Iniciar()
    {
        _constelacion.Cambios += ActualizarCantidad;
        Console.Title = "La Constelación";
        Console.SetWindowSize(140, 50); 
        DibujarBordes(Console.WindowWidth, Console.WindowHeight);
        ActualizarCantidad(0);
        Console.CursorVisible = false; 
        ConsoleKeyInfo key = new();
        do
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.A)
            {
                DibujarEstrella();
            }
        }
        while (key.Key != ConsoleKey.S);
    }

    static void DibujarEstrella()
    {
        var estrella = new EstrellaTexto();
        _constelacion.CrearEstrella(estrella.Ubicar, estrella.Iluminar);
    }

    static void DibujarBordes(int width, int height)
    {
        if (width < 2 || height < 2)
        {
            Console.WriteLine("El ancho y alto deben ser al menos 2.");
            return;
        }

        Console.Write("┌");
        Console.Write(new string('─', width - 2));
        Console.WriteLine("┐");

        for (int i = 0; i < height - 4; i++)
        {
            Console.Write("│");
            Console.Write(new string(' ', width - 2));
            Console.WriteLine("│");
        }

        Console.Write("└");
        Console.Write(new string('─', width - 2));
        Console.WriteLine("┘");
    }

    static void ActualizarCantidad(int cantidad)
    {
        Console.ResetColor();
        Console.SetCursorPosition(2, 48);
        Console.WriteLine($"[A] Agregar una estrella | [S] Salir      -  Total de estrellas: {cantidad}    ");
    }
}
