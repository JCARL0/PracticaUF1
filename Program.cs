using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, introduce tu nombre: ");
        
        // Leer el nombre del usuario desde la entrada estándar (teclado)
        string nombre = Console.ReadLine();
        
        // Mostrar un mensaje de bienvenida en la pantalla
        Console.WriteLine($"¡Bienvenido, {nombre}!");

        // Esperar a que el usuario presione una tecla antes de cerrar la aplicación (opcional)
        Console.ReadKey();
    }
}
