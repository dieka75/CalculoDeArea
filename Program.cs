using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radioAr, baseAr, ladoAr, alturaAr, area;
            byte opcion;

            Console.WriteLine("Calculo de Area");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");
            Console.Write("Elija su opcion: ");

            opcion = Convert.ToByte(Console.ReadLine()); 

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el radio del circulo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());

                    //area = Math.PI * radioAr * radioAr;
                    //reemplazamos el calculo por la llamada al metodo
                    area = Circulo(radioAr);

                    Console.WriteLine("El area del circulo es: {0}", area);
                    break;

                case 2:
                    Console.Write("Ingrese la base el triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la altura el triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());

                    //area = baseAr * alturaAr / 2;
                    //reemplazamos el calculo por la llamada al metodo
                    area = Triangulo(baseAr, alturaAr);

                    Console.WriteLine("El area del triangulo es: {0}", area);
                    break;

                case 3:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());

                    //area = ladoAr * ladoAr;
                    //reemplazamos el calculo por la llamada al metodo
                    area = Cuadrado(ladoAr);

                    Console.WriteLine("El area del cuadrado es: {0}", area);
                    break;
            }
        }
        static double Circulo(double radioAr)
        {
            double area;
            area = Math.PI * radioAr * radioAr;
            return area;
        }

        static double Triangulo(double baseAr, double alturaAr)
        {
            double area;
            area = baseAr * alturaAr / 2;
            return area;
        }
        static double Cuadrado(double ladoAr)
        {
            double area;
            area = ladoAr * ladoAr;
            return area;
        }
    }
}
