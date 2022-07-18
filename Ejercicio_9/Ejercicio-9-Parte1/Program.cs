/*
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el 
anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, 
una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  Se debe usar solo lo visto en clase hasta ahora y no los métodos que 
trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)      Mostrar el vector nuevamente.
*/

Console.WriteLine("Bienvenido, a continuación ingrese la longitud del vector:");
// Petición de datos
Console.Write("\n   Longitud: ");
int longVector = int.Parse(Console.ReadLine());
Random myObject = new Random();
int ranNum;
// Definición del vector.
int[] miVector = new int[longVector];

// Lleno el vector con datos aleatorios

for (int i = 0; i < longVector; i++){
    ranNum = myObject.Next(0, 99);
    miVector[i] = ranNum;
}

// Muestro el vector
Console.WriteLine("Los valores del vector son: ");
Console.Write("[");
foreach (int valor in miVector){
    Console.Write($"{valor} ");
}
Console.WriteLine("]");

// FALTAN PUNTOS 5 y 6.