using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];

Empleado empleado1 = new Empleado("Agustin", "Castro", new DateTime(2003, 6, 6), 'C', 'M', new DateTime(2018, 7, 10), 80000, cargos.Ingeniero);
Empleado empleado2 = new Empleado("Santiago", "Lopez", new DateTime(2001, 4, 13), 'S', 'M', new DateTime(2015, 1, 27), 65000, cargos.Auxiliar);
Empleado empleado3 = new Empleado("Rosario", "X", new DateTime(2002, 10, 14), 'C', 'F', new DateTime(2017, 11, 1), 90000, cargos.Investigador);

empleados[0] = empleado1;
empleados[1] = empleado2;
empleados[2] = empleado3;

double montoTotal = 0;
int proxJubilacion = 0;
for (int i = 0; i < empleados.Length; i++)
{
    montoTotal += empleados[i].Salario();
    if (empleados[i].Jubilacion() < empleados[proxJubilacion].Jubilacion())
    {
        proxJubilacion = i;
    }
}

Console.WriteLine("Monto total: " + montoTotal);
Console.WriteLine("Proxima jubilacion: " + empleados[proxJubilacion].Nombre + ", Sueldo: $" + empleados[proxJubilacion].Salario());