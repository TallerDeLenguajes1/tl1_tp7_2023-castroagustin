namespace EspacioEmpleado;

public enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string? nombre;
    private string? apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private char genero;
    private DateTime ingreso;
    private double sueldoBasico;
    private cargos cargo;


    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FecNac { get => fecNac; set => fecNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime Ingreso { get => ingreso; set => ingreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

    public Empleado(string nombre, string apellido, DateTime fecNac, char estadoCivil, char genero, DateTime ingreso, double sueldoBasico, cargos cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FecNac = fecNac;
        this.EstadoCivil = estadoCivil;
        this.Genero = genero;
        this.Ingreso = ingreso;
        this.SueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public int Antiguedad()
    {
        return DateTime.Now.Year - Ingreso.Year;
    }
    public int Edad()
    {
        return DateTime.Now.Year - FecNac.Year;
    }
    public int Jubilacion()
    {
        if (Genero == 'F')
        {
            return 60 - Edad();
        }
        else
        {
            return 65 - Edad();
        }
    }
    public double Salario()
    {
        double adicional;
        if (Edad() <= 20)
        {
            adicional = Antiguedad() * SueldoBasico * 0.01;
        }
        else
        {
            adicional = SueldoBasico * 0.25;
        }
        if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
        {
            adicional *= 1.5;
        }
        if (EstadoCivil == 'C')
        {
            adicional += 15000;
        }
        return SueldoBasico + adicional;
    }
}