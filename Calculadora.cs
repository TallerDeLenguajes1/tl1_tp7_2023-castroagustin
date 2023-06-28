namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;
    public Calculadora(double inicial = 0)
    {
        dato = inicial;
    }

    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        dato /= termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }

    public double Resultado { get => dato; }
}