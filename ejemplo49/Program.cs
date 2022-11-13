using System;
using System.Text;
namespace cap4ejercicio49;
//ejercicio 4.9
public class capitulo4
{
    static public void Main()
    {
        int Num3;
        int Num4;
        String Sor;
        int Result;

        Console.WriteLine("Escriba el primero numero:");
        Num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(" Escriba el segundo numero:");
        Num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Si usted desea suma digite S, pero si desea restar digite R");
        Sor = Console.ReadLine();

        switch (Sor)
        {
            case "s":
                Result = Num3 + Num4;
                Console.WriteLine($"El resultado es: {Result}");
                break;

            case "r":

                Result = Num3 - Num4;
                Console.WriteLine($"El resultado es: {Result}");
                break;

            default:
                Console.WriteLine("No selecciono ni suma ni resra ");
                break;

        }


    }
}

