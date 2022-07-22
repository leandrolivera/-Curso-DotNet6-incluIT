/*
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29,
así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/

Console.WriteLine("Bienvenido al BINGO!");
// Petición de datos (cantidad de filas y cantidad de columnas)
Console.WriteLine("Estamos generando su nuevo cartón para el juego...");
Console.ReadKey();
int cantidadFilas = 3;
int cantidadColumnas = 9;
int cantNumeros = 15;
int cantEspacios = 12;
Random random = new Random();
Boolean booleano;

int[] lugaresNumeros = new int[5];
for (int i = 0; i < lugaresNumeros.Length; i++)
{
    do
    {
        lugaresNumeros[i] = random.Next(0, 8);
    } while (!lugaresNumeros.Contains(lugaresNumeros[i]));
    Console.WriteLine(lugaresNumeros[i]);
}
// Definición de la matriz.
int[,] numeros = new int[cantidadFilas, cantidadColumnas];
Console.WriteLine("Los valores del vector son: ");
for (int i = 0; i < cantidadFilas; i++)
{
    Console.Write("[");
    if (i == 0)
    {
        Console.Write(random.Next(1, 2));
    }
    for (int j = 0; j < cantidadColumnas; j++)
    {
        numeros[i, j] = 0;
        //Console.Write($"{numeros[i,j]} ");
        if (numeros.GetUpperBound(1) == j)
        {
            Console.Write($"{numeros[i, j]}");
        }
        else
        {
            Console.Write($"{numeros[i,j]}, ");
        }
    }
    Console.WriteLine("]");
}

