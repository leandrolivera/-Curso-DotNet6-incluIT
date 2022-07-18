/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/

Console.WriteLine("Bienvenido, a continuación se le solicitaran 10 números:");

int[] numeros = new int[10];
double suma = 0;
int mayor = 0;
int menor = 0;
double promedio = 0.0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Por favor, ingrese el número para la posición [{i + 1}]:");
    numeros[i] = int.Parse(Console.ReadLine());

    suma += numeros[i];

    if (i == 0)
    {
        mayor = numeros[i];
        menor = numeros[i];
    }
    else if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
    else if (numeros[i] < menor)
    {
        menor = numeros[i];
    }

}

promedio = suma / numeros.Length;

Console.Write("Los números ingresados fueron: [");
for (int i = 0; i < numeros.Length; i++)
{
    if (i == 0)
    {
        Console.Write(numeros[i]);
    }
    else
    {
        Console.Write(", " + numeros[i]);
    }


}
Console.WriteLine("]");

Console.WriteLine($"La suma total de los valores ingresados es de: {suma}");
Console.WriteLine($"El mayor número de ellos es {mayor}, mientras que el menor es {menor}");
Console.WriteLine($"El promedio calculado en base a estos números es de: {promedio}");