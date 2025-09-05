using Recursividad.Logica;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Recursividad");

        Console.WriteLine("\nCasos de recursividad: ");
        Console.WriteLine("\nCaso 1 Factorial:");

        Recursividad.Logica.Recursividad rlr = new Recursividad.Logica.Recursividad();
        int resultado = rlr.Factorial(5);
        Console.WriteLine("El resultado es: "+resultado);
        Console.WriteLine($"Resultado: {resultado}"); //Interpolar
        Console.WriteLine($"Resultado: {rlr.Factorial(5)}"); //Interpolar

        Console.WriteLine("Caso 2 Potencia: ");
        int result = rlr.Potencia(2,5);

        Console.WriteLine($"Resultado: {result}"); //Interpolar
        Console.WriteLine($"Resultado: {rlr.Potencia(2,5)}"); //Interpolar

        Console.ReadKey();
    }
}