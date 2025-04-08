namespace Ej02;

abstract class Producto
{
    protected char codigo;
    protected string descripcion;
    protected double precio;

    public Producto(char codigo, string descripcion, double precio)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public void CambiarCodigo(char nuevoCod)
    {
        codigo = nuevoCod;
    }

    public void CambiarDescripcion(string nuevaDesc)
    {
        descripcion = nuevaDesc;
    }

    public char getCodigo()
    {
        return codigo;
    }

    public string getDescripcion()
    {
        return descripcion;
    }
    
    public double getPrecio()
    {
        return precio;
    }
}