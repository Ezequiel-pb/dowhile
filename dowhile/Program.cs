using System;

class Program
{
    static void Main()
    {
        string nombre, apellido;
        bool continuar;

        do
        {

            Console.WriteLine("ingrese su nombre: \n");
            nombre = Console.ReadLine().Trim();

            Console.WriteLine("ingrese su apellido: \n");
            apellido = Console.ReadLine() .Trim();

            Console.WriteLine( $"Hola, {nombre} {apellido}! ");

            Console.WriteLine(" desea ingresar otro nombre y apellido? (s/n)");
            string respuesta = Console.ReadLine().ToLower();

            continuar = (respuesta == "s");


        } while (continuar);

        Console.WriteLine(" gracias por utilizar este programa. presione cualquier tecla para salir");
        Console.ReadKey();
    }
    
}

    



 

