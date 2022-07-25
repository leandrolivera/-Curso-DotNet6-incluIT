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
Console.WriteLine("Estamos generando su nuevo cartón para el juego...");
Console.ReadKey();
int cantidadFilas = 3;
int cantidadColumnas = 9;
int cantNumeros = 15;
int cantEspacios = 12;
Random random = new Random();

int[] lugaresNumeros = new int[5];
int[] comprobarRepetidos = { -1, -1, -1, -1, -1 };


// Definición de la matriz.
int[,] numeros = new int[cantidadFilas, cantidadColumnas];
Console.WriteLine("\n");
for (int i = 0; i < cantidadFilas; i++)
{
    Console.Write("[");
    lugaresNumeros = new int[5];

    for (int j = 0; j < lugaresNumeros.Length; j++)
    {
        do
        {
            lugaresNumeros[j] = random.Next(0, 9);
        } while (comprobarRepetidos.Contains(lugaresNumeros[j]));
        comprobarRepetidos[j] = lugaresNumeros[j];
    }
    for (int j = 0; j < cantidadColumnas; j++)
    {
        for (int k = 0; k < lugaresNumeros.Length; k++)
        {
            if (lugaresNumeros[k] == 0)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(1, 10);
            }
            else if (lugaresNumeros[k] == 1)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(10, 20);
            }
            else if (lugaresNumeros[k] == 2)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(20, 30);
            }
            else if (lugaresNumeros[k] == 3)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(30, 40);
            }
            else if (lugaresNumeros[k] == 4)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(40, 50);
            }
            else if (lugaresNumeros[k] == 5)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(50, 60);
            }
            else if (lugaresNumeros[k] == 6)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(60, 70);
            }
            else if (lugaresNumeros[k] == 7)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(70, 80);
            }
            else if (lugaresNumeros[k] == 8)
            {
                numeros[i, lugaresNumeros[k]] = random.Next(80, 91);
            }
            else
            {
                numeros[i, lugaresNumeros[k]] = 0;
            }
        }
        //Console.Write($"{numeros[i,j]} ");
        if (numeros.GetUpperBound(1) == j)
        {
            Console.Write($" {numeros[i, j]} ");
        }
        else
        {
            Console.Write($" {numeros[i, j]} , ");
        }
    }

    Console.WriteLine("]");
}

