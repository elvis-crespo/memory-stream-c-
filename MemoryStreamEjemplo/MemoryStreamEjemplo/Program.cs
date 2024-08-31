using System.IO;
using System.Text;

namespace MemoryStreamEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);

            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;

            byte[] miBuffer = new byte[50];
            ms.Write(miBuffer, 0, 15);
            ms.Close();               //No olvidar cerrar

            //Ejemplo
            MemoryStream memStream = new MemoryStream(50);    
            string input = string.Empty;

            var capacidad1 = memStream.Capacity; //Obtiene la ultma posicion  
            var longitud1 = memStream.Length;//Devuelve la longitud actual
            var posicion1 = memStream.Position; 
            
            byte[] buffer = new byte[50];

            //Input
            Console.WriteLine("Introduzca la info: ");
            input = Console.ReadLine();

            memStream.Write(ASCIIEncoding.ASCII.GetBytes(input), 0, input.Length);
            memStream.Seek(0, SeekOrigin.Begin);//Nos situaremos con seek en la posicion 0 desde el inicio
            memStream.Read(buffer, 0, capacidad1); //Desde nos encontramos, 5 caracteres

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer)); //Pintar lo que obtuve de read
            memStream.Close();  

            Console.ReadKey();



        }
    }
}