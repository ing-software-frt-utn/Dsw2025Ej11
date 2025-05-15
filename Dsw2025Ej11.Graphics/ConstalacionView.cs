using Dsw2025Ej11.Domain;

namespace Dsw2025Ej11.Graphics;

public partial class ConstalacionView : Form
{
    private Constelacion _constelacion;
    public ConstalacionView()
    {
        InitializeComponent();
        _constelacion = new Constelacion("Osa Mayor");
        _constelacion.Cambios += Constelacion_Novedad;
    }

    private void Constelacion_Novedad(int estrellas)
    {
        if (InvokeRequired)
        {
            BeginInvoke(() =>
            {
                ActualizarCantidad(estrellas); //Se personaliza
            });
        }
        else
        {
            ActualizarCantidad(estrellas); //Se personaliza
        }
    }

    private void ActualizarCantidad(int cantidad)
    {
        lblNovedades.Text = $"Cantidad de estrellas: {cantidad}";
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var estrellaControl = new EstrellaControl(pConstelacion);
        _constelacion.CrearEstrella(estrellaControl.Ubicar, estrellaControl.Iluminar);
    }
}
