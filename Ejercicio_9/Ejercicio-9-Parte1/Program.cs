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
Random random = new Random();
int contador = 0;
// Definición del vector.
int[] miVector = new int[longVector];

// Lleno el vector con datos aleatorios

for (int i = 0; i < longVector; i++){
    miVector[i] = random.Next(0, 100);
}

// Muestro el vector
Console.WriteLine("Los valores del vector son: ");
Console.Write("[");
foreach (int valor in miVector){
    contador++;
    if (longVector == contador){
        Console.Write($"{valor}");
    } else {
        Console.Write($"{valor}, ");
    }
}
Console.WriteLine("]");

//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el 
//anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, 
//una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  Se debe usar solo lo visto en clase hasta ahora y no los métodos que 
//trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
//6)      Mostrar el vector nuevamente

int auxInicial=miVector[0];
int auxPosicion = longVector-1;
int auxFinal=miVector[longVector];

if (miVector.Length%2 == 0){
    for(int i = 0; i < miVector.Length; i++){
        auxInicial = miVector[i];
        auxFinal = miVector[auxPosicion];

        miVector[i] = auxFinal;
        miVector[auxPosicion]  = auxInicial;

        auxPosicion++;
    }   
}

Console.WriteLine("Los valores del vector son: ");
Console.Write("[");
foreach (int valor in miVector){
    contador++;
    if (longVector == contador){
        Console.Write($"{valor}");
    } else {
        Console.Write($"{valor}, ");
    }
}
Console.WriteLine("]");