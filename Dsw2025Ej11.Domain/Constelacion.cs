using System.Diagnostics;
using System.Timers;

namespace Dsw2025Ej11.Domain;

public delegate void PasoDelTiempoDelegate();
public class Constelacion
{
    private System.Timers.Timer _timer;
    private PasoDelTiempoDelegate? _pasoDelTiempo;
    public event Action<int>? Cambios;
    public double Ancho { get; }
    public double Alto { get; }
    public string Nombre { get; set; }
    public List<Estrella> Estrellas { get; }

    public Constelacion(string nombre)
    {
        Nombre = nombre;
        Ancho = 100;
        Alto = 80;
        Estrellas = [];
        _timer = new System.Timers.Timer(150); //Años que pasan
        _timer.Elapsed += PasoDelTiempo;
        _timer.Start();
    }

    private void PasoDelTiempo(object? sender, ElapsedEventArgs e)
    {
        _pasoDelTiempo?.Invoke();
    }

    public void CrearEstrella(Action<double, double> ubicar, Action<Luminosidad> iluminar)
    {
        var random = new Random();
        var x = random.Next(1, (int)Ancho) / Ancho;
        var y = random.Next(1, (int)Alto) / Alto;
        var estrella = new Estrella(iluminar);
        _pasoDelTiempo += estrella.PasoDelTiempo;
        estrella.Desaparecer += Desaparecer;
        Estrellas.Add(estrella);
        Debug.WriteLine($"Coordenadas estrella en {x}, {y}");
        ubicar(x, y);
        OnCambios();
    }

    private void Desaparecer(Estrella estrella)
    {
        estrella.Desaparecer -= Desaparecer;
        _pasoDelTiempo -= estrella.PasoDelTiempo;
        Estrellas.Remove(estrella);
        OnCambios();
    }

    private void OnCambios()
    {
        _timer.Stop();
        Cambios?.Invoke(Estrellas.Count);
        _timer.Start();
    }
}
