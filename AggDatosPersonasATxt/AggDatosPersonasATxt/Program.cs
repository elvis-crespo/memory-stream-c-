using Microsoft.Win32;
using System.ComponentModel;
using System.Data;

namespace AggDatosPersonasATxt
{
//1- Crear un programa que realice la siguiente funcionalidad:

//Se pedirá por consola el nombre de una persona, su edad y su localidad, se guardara en un archivo con el 
//siguiente formato, nombre|edad|localidad;  uno detrás del otro "|" separa datos ";" separa registros.
//Cuando se inserte, se pedirá si quiere introducir más personas, "S o N", se podrán introducir personas 
//hasta que se pulse en "N". cuando se pulse en "N", se listaran todas las personas que están introducidas 
//en el archivo.una vez se salga del programa, si lo volvemos a ejecutar e introducimos mas personas, una 
//vez pulsado de nuevo "N", tendrán que salir todas las personas, las introducidas en veces anteriores y las nuevas.

//Requisitos: se tendrán que usar todos los componentes vistos hasta la fecha, clases (Clase persona), propiedades,
//Interfaces, métodos, funciones, bucles, condicionales control de excepciones y archivos.

//Cuidado: tienes que realizar todas las comprobaciones necesarias de validaciones.
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var pe = Persona.GuardarDatosPersonas();

            Persona.FileStream(pe);


            //List<Persona> mi = Persona.GuardarDatosPersonas();
                
            
            //foreach (Persona persona in mi)
            //{
            //    Console.WriteLine($"{persona.Name}|{persona.Age.ToString()}|{persona.Location};");
            //}

            //Console.ReadKey();  

        }
    }
}