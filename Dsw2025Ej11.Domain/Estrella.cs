using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej11.Domain;

public delegate void DesaparecerDelagate(Estrella estrella);
public class Estrella
{
    private Action<Luminosidad> _iluminar;
    public event DesaparecerDelagate? Desaparecer;
    public int Edad { get; set; }
    public int TiempoDeVida { get; set; }
    public Luminosidad Luminosidad { get; set; }

    public Estrella(Action<Luminosidad> iluminar)
    {
        _iluminar = iluminar;
        var random = new Random();
        var vida = random.Next(50, 300);
        TiempoDeVida = vida;
        Edad = 0;
    }

    public void PasoDelTiempo()
    {
        var actual = Luminosidad;
        if (Edad <= TiempoDeVida * 0.1)
        {
            Luminosidad = Luminosidad.Media;
        }
        else if (Edad > TiempoDeVida * 0.1 && Edad <= TiempoDeVida * 0.8)
        {
            Luminosidad = Luminosidad.Alta;
        }
        else
        {
            Luminosidad = Luminosidad.Baja;
        }

        if (Edad <= TiempoDeVida)
        {
            Edad++;
        }
        else
        {
            Luminosidad = Luminosidad.Nula;
            OnDesaparecer();
        }
        if(actual == Luminosidad)
            return;
        _iluminar(Luminosidad);
    }
    private void OnDesaparecer()
    {
        Desaparecer?.Invoke(this);
    }   
}
