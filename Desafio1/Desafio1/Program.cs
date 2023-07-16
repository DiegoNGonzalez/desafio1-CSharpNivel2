using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("Moto g40", "Motorola");

            Console.WriteLine("El telefono es marca "+tel1.Marca+" y el modelo es " + tel1.Modelo);
            Telefono tel2 = new Telefono("J7", "Samsung");
            tel2.CodigoOperador = 3;
            Console.WriteLine("El telefono 2 es marca "+tel2.Marca+" el modelo es "+ tel2.Modelo+ " el codigo de operador es "+ tel2.CodigoOperador+" y el nro es "+tel2.NumeroTelefonico);
            Console.WriteLine(tel1.Llamar());
            Console.WriteLine(tel2.Llamar("maxi"));
            int documento;
            Console.WriteLine("Ingrese su nro de documento");
            documento=int.Parse(Console.ReadLine());
            DocumentoIdentidad documento1= new DocumentoIdentidad(documento);
            Console.WriteLine("Ingrese su nombre: ");
            documento1.Nombre=Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            documento1.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su genero: ");
            documento1.Genero = Console.ReadLine();
            Console.WriteLine("Ingrese su nacionalidad: ");
            documento1.Nacionalidad = Console.ReadLine();

            Console.WriteLine("La persona con documento nro " + documento1.NroDocumento + " se llama " + documento1.Nombre + " " + documento1.Apellido + " su genero es " + documento1.Genero + " y su documento es de origen " + documento1.Nacionalidad);

            Console.ReadKey();
        }
    }
}
