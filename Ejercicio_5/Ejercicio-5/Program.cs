/*
1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

string respuesta = "S";

while (respuesta.ToUpper() == "S") {
    
    Console.Clear();

    Console.WriteLine("Ingrese su nombre por favor:");

    string nombreIngresado = Console.ReadLine();

    Console.WriteLine("¡Hola " + nombreIngresado + "!");

    Console.WriteLine("¿Desea continuar? (S/N)");

    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");
} else { 
    Console.WriteLine("Opcion no valida"); 
}