/*
Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.WriteLine("Bienvenido, a continuación ingrese cantidad de filas y columnas de la matriz:");
// Petición de datos (cantidad de filas y cantidad de columnas)
Console.Write("\n   Cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());
Console.Write("\n   Cantidad de Columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());

// Definición de la matriz.
int[,] numeros = new int[cantidadFilas, cantidadColumnas];

// Obtengo la cantidad de filas y columnas con el metodo GetUpperBound(indice)
// donde indice es la dimensión de la matriz, y le sumo 1 para obtener
// la longitud total.

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

// Definición del vector solicitado en el enunciado.
double[] promedios = new double[lengthColumnas];

// Declaro la variable suma para poder hacer el calculo del promedio.
double suma = 0;

// Recorro la matriz para su carga de datos
for (int columna = 0; columna < lengthColumnas; columna++)
{

    Console.WriteLine($"\nIngrese los valores de las filas para la columna nro {columna + 1}:");

    // Reinicializo la variable suma a 0 para volver a utilizarla
    suma = 0;

    for (int fila = 0; fila < lengthFilas; fila++)
    {

        Console.Write($"    - Ingrese el valor de la fila {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
        suma += numeros[fila, columna];
    }

    // Calculo el promedio total de la columna actual
    promedios[columna] = suma / lengthFilas;
}

Console.WriteLine("\nLa matriz quedó conformada de la siguiente manera:");

// Recorro nuevamente la matriz para mostrar los datos
for (int fila = 0; fila < lengthFilas; fila++)
{

    Console.Write("[");

    for (int columna = 0; columna < lengthColumnas; columna++)
    {

        if (columna == 0)
        {
            Console.Write(numeros[fila, columna]);
        }
        else
        {
            Console.Write(", " + numeros[fila, columna]);
        }

    }

    Console.WriteLine("]");

}

// Muestro el valor de los promedios de cada columna.
Console.WriteLine("\nLos promedios en cada columna ingresada fueron:");
Console.Write("[");
for (int i = 0; i < promedios.Length; i++)
{

    if (i == 0)
    {
        Console.Write(promedios[i]);
    }
    else
    {
        Console.Write("; " + promedios[i]);
    }

}
Console.WriteLine("]");