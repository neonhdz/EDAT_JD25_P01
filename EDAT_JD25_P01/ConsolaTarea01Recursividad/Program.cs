using BibliotecaTarea01Recursividad;

public class Program
{
    public static void Main(string[] args)
    {

        BibliotecaTarea01Recursividad.RecursividadContenido r = new BibliotecaTarea01Recursividad.RecursividadContenido();

        // 1. Cantidad de vocales en una cadena
        Console.WriteLine("_______________________________________________________________________________\n");
        Console.WriteLine("Ingrese una cadena de texto:");
        string chain = Console.ReadLine();
        int cantidadVocales = r.vocals(chain);
        Console.WriteLine("La cantidad de vocales en la cadena -" + chain + "- es: " + cantidadVocales);
        Console.WriteLine("_______________________________________________________________________________\n");
        // 2. Suma de dígitos de un número

        Console.WriteLine("Ingrese un número (1 dígito o más):");
        int num = int.Parse(Console.ReadLine());
        int sum = r.suma1(num);
        Console.WriteLine("La suma de los dígitos del número -" + num + "- es: " + sum);
        Console.WriteLine("_______________________________________________________________________________\n");
        // 3. Suma de los primeros n números
        Console.WriteLine("_______________________________________________________________________________\n");
        Console.WriteLine("Ingrese un número:");
        int n = int.Parse(Console.ReadLine());
        int sum2 = r.suma2(n);
        Console.WriteLine("La suma de los primeros números hasta -" + n + "- es: " + sum2);
        Console.WriteLine("_______________________________________________________________________________\n");
        Console.WriteLine("Esperando una tecla...\n");
        Console.ReadKey();
    }
}