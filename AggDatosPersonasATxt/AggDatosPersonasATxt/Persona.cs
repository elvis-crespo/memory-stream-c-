using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
namespace AggDatosPersonasATxt
{
    public class Persona : IPersona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public Persona(string nombre, int edad, string localidad)
        {
            if(edad <= 0)
            {
                throw new ArgumentException("La edad debe ser mayor a 0");
            }
            
            Name = nombre;
            Age = edad;
            Location = localidad;
        } 

        public static List<Persona> GuardarDatosPersonas()
        {
            int cantPers;
            char valueSN;
            string cadena;
            bool value = true;

            
            List<Persona> person = new List<Persona>(); 

            while (value) 
            {
                //Pide los datos para guardarlos
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine().ToLower();
                try 
                {
                    Console.Write("Edad: ");
                    if (int.TryParse(Console.ReadLine(), out int edad))
                    {
                        Console.Write("Localidad: ");
                        string localidad = Console.ReadLine().ToLower();

                        //Crear una nueva instancia de persona para agg  - no se puede sobrecargar el add

                        Persona newPersona = new Persona(nombre, edad, localidad);
                        person.Add(newPersona);

                        Console.WriteLine("\nDesea agregar más personas S o N");
                        valueSN = Convert.ToChar(Console.ReadLine().ToLower()[0]);
                        if (valueSN != 's')
                        {
                           value = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No es una edad validad");
                    }
                }catch (ArgumentException e) 
                {
                    Console.WriteLine("La edad no debe ser negativa");
                }
                
                Console.WriteLine();

            }

            return person;
        }

        public static void FileStream(List<Persona> person)
        {
            int bytesLiedos = 0;

            foreach (Persona pers in person)
            {
                
                //Console.WriteLine($"{pers.Name}|{pers.Age.ToString()}|{pers.Location};");
                FileStream fsWrite = new FileStream("miArchvio.txt", FileMode.Append);   //1kilobyte
                string miCadena = $"{pers.Name}|{pers.Age.ToString()}|{pers.Location};";
                
                fsWrite.Write(ASCIIEncoding.ASCII.GetBytes(miCadena), 0, miCadena.Length);
                fsWrite.Close();

                byte[] buffer = new byte[10024];
                if (bytesLiedos < buffer.Length )
                {
                    FileStream fs = new FileStream("miArchvio.txt", FileMode.Open);
                    fs.Read(buffer, 0, (int)fs.Length);

                    Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));
                    fs.Close();
                }
                else 
                {
                    Console.WriteLine("Error! sin espacio 1MB"); 
                }
                

                bytesLiedos++;  
            }
            
            Console.ReadKey();
            
            
            
        }

        //FileStream fsWrite = new FileStream("miArchivo", FileMode.Create);

        //string cadena = "\"El camino asi es\"\nMandalor";

        //fsWrite.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
        //    fsWrite.Close();

        //    byte[] buffer = new byte[1024];

        //FileStream fs = new FileStream("miArchivo", FileMode.Open);
        //fs.Read(buffer, 0, (int) fs.Length);

        //Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));
        //    Console.ReadKey();

        //    fs.Close();
    }
}
