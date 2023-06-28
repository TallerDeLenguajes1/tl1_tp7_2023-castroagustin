using EspacioCalculadora;

int aux;
Console.WriteLine("Calculadora:");

bool control = true;
double inicial;
do
{
    Console.WriteLine("Ingrese el valor inicial:");
    control = double.TryParse(Console.ReadLine(), out inicial);

    if (!control)
    {
        Console.WriteLine("Ingrese un valor valido!");
    }

} while (!control);

Calculadora calculadora = new Calculadora(inicial);
do
{
    Console.WriteLine("Ingrese una opcion:\n0-salir\n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Limpiar");
    int.TryParse(Console.ReadLine(), out aux);

    if (aux > 0 && aux <= 5)
    {
        if (aux == 5)
        {
            calculadora.Limpiar();
        }
        else
        {
            double num;
            Console.WriteLine("Ingrese un valor:");
            double.TryParse(Console.ReadLine(), out num);

            switch (aux)
            {
                case 1:
                    calculadora.Sumar(num);
                    break;
                case 2:
                    calculadora.Restar(num);
                    break;
                case 3:
                    calculadora.Multiplicar(num);
                    break;
                case 4:
                    calculadora.Dividir(num);
                    break;
            }
        }
        Console.WriteLine("Resultado: " + calculadora.Resultado);
    }
} while (aux > 0 && aux <= 5);
Console.WriteLine("Fin del programa...");