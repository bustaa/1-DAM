namespace Ej02;

class Hardware : Producto
{
    private bool periferico;

    public Hardware(char codigo, string descripcion, double precio, bool periferico) : base(codigo, descripcion, precio)
    {
        this.periferico = periferico;
    }

    public void CambiarPeriferico(bool nuevoPerif)
    {
        periferico = nuevoPerif;
    }

    public bool getPeriferico()
    {
        return periferico;
    }
}