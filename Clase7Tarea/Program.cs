string[] posiciones = { "primer", "segundo", "tercer", "cuarto", "quinto", "sexto", "séptimo", "octavo", "noveno", "décimo" };
int[] numeros = new int[10];
int acumulador = 0;
int num;
bool verificador;

Console.WriteLine("Este programa calcula la suma, el promedio, el mayor y el menor de 10 números ingresados por el usuario");

for (int i = 0; i < posiciones.Length; i++)
{
        Console.WriteLine($"Ingrese el {posiciones[i]} número");
     
    do
    {
        string input = Console.ReadLine();
        verificador = int.TryParse(input, out num);

        if (verificador)
        {
            numeros[i] = int.Parse(input);
            acumulador += numeros[i];
        }
        else
        {
            Console.WriteLine("Carácter inválido, ingrese un número");
        }
    }
    while (!verificador);
}

double promedio = (double)acumulador / numeros.Length;
int menorDeTodos = numeros.Min();
int mayorDeTodos = numeros.Max();

Console.Clear();
Console.Write($"Los números ingresados son: [");

for (int i = 0; i < numeros.Length; i++)
{
    if (i == numeros.Length - 1)
    {
        Console.WriteLine(numeros[i]+"]");
    }
    else
    {
        Console.Write(numeros[i] + ", ");
    }
}

Console.WriteLine($"La suma de los 10 números es: {acumulador}"); 
Console.WriteLine($"El promedio de los 10 números es: {promedio}");
Console.WriteLine($"El menor de todos los números es: {menorDeTodos}");
Console.WriteLine($"El mayor de todos los números es: {mayorDeTodos}");