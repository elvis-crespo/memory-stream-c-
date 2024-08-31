using System.IO;
using System;
MemoryStream ms = new MemoryStream(150);

var capacidad = ms.Capacity;
var longitud = ms.Length;
var posicion = ms.Position;

byte[] buffer = new byte[50];

ms.Read(buffer, 0, 5);

//ms.Seek(0, SeekOrigin.Begin);
//ms.Seek(10, SeekOrigin.Begin);
////ms.Seek(-10, SeekOrigin.Begin);

//ms.Seek(5, SeekOrigin.Current);
//ms.Seek(-10, SeekOrigin.Current);
Console.WriteLine();