namespace FileStream
{
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            //MODOS
            //FileMode.Append //Concatena 
            //FileMode.Create //Redundancia al crear archivos
            //FileMode.CreateNew
            //FileMode.OpenOrCreate
            //FileMode.Open
            //FileMode.Truncate

            FileStream fsWrite = new FileStream("miArchivo", FileMode.Create);

            string cadena = "\"El camino asi es\"\nMandalor";

            fsWrite.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fsWrite.Close();

            byte[] buffer = new byte[1024];

            FileStream fs = new FileStream("miArchivo", FileMode.Open);
            fs.Read(buffer, 0, (int)fs.Length);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));
            Console.ReadKey();

            fs.Close();
        }
    }
}