using Dsw2025Ej11.Domain;

namespace Dsw2025Ej11.Graphics;

public partial class EstrellaControl : UserControl
{
    public EstrellaControl()
    {
        InitializeComponent();
    }

    public EstrellaControl(Control parent):this()
    {
        Parent = parent;
        Parent.Controls.Add(this);
    }

    public void Ubicar(double x, double y)
    {
        if (Parent == null) return;
        Location = new Point((int)(x * Parent.Width), (int)(y * Parent.Height));
    }

    public void Iluminar(Luminosidad luminosidad)
    {
        if (luminosidad == Luminosidad.Baja)
            lblEstrella.ForeColor = Color.DimGray;
        else if (luminosidad == Luminosidad.Media)
            lblEstrella.ForeColor = Color.Gray;
        else if (luminosidad == Luminosidad.Alta)
            lblEstrella.ForeColor = Color.Wheat;
        else
            lblEstrella.ForeColor = Color.Black;
    }

    public bool Eliminar()
    {
        if (InvokeRequired)
        {
            BeginInvoke(() =>
            {
                Borrar();
            });
            return true;
        }
        else
        {
           return Borrar();
        }
    }

    private bool Borrar()
    {
        Parent?.Controls.Remove(this);
        Dispose();
        return true;
    }
}
