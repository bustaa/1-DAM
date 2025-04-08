namespace Ej02;

class Software : Producto
{
    private string tipo;

    public Software(char codigo, string descripcion, double precio, string tipo) : base(codigo, descripcion, precio)
    {
        this.tipo = tipo;
    }

    public void CambiarTipo(string nuevoTipo)
    {
        tipo = nuevoTipo;
    }

    public string getTipo()
    {
        return tipo;
    }
}