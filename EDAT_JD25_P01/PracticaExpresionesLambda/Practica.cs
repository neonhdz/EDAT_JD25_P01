internal class Practica
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Practica Funciones Lambda");

        // Este programa nos permitirá:
        // 1. Calcular el promedio de un arreglo de números enteros.
        // 2. Dado un arreglo de números enteros, crear una función lambda que retorne el número menor.
        // 3. Crear una función lambda que reciba como parámetro 3 números enteros.La función retorna el número mayor.
        // 4. Crear una función lambda que reciba dos parámetros, un string y un número entero. La función retorna un string el cual será el resultado de multiplicar ambos parámetros.

        var numeros = new int[] { 5, 10, 15, 20, 25 };

        // 1. Calcular el promedio de un arreglo de números enteros.
        Func<int[], double> calcularPromedio = nums => nums.Average();
        double promedio = calcularPromedio(numeros);
        Console.WriteLine($"El promedio es: {promedio}");

        // 2. Dado un arreglo de números enteros, crear una función lambda que retorne el número menor.
        Func<int[], int> encontrarNumeroMenor = nums => nums.Min();
        int numeroMenor = encontrarNumeroMenor(numeros);
        Console.WriteLine($"El número menor es: {numeroMenor}");

        // 3. Crear una función lambda que reciba como parámetro 3 números enteros.La función retorna el número mayor.
        Func<int, int, int, int> encontrarNumeroMayor = (a, b, c) => Math.Max(a, Math.Max(b, c));
        int numeroMayor = encontrarNumeroMayor(5, 10, 15);
        Console.WriteLine($"El número mayor es: {numeroMayor}");

        // 4. Crear una función lambda que reciba dos parámetros, un string y un número entero. La función retorna un string el cual será el resultado de multiplicar ambos parámetros.
        Func<string, int, string> multiplicarStringNumero = (str, num) => string.Concat(Enumerable.Repeat(str, num));
        string resultadoMultiplicacion = multiplicarStringNumero("Hola", 3);
        Console.WriteLine($"El resultado de la multiplicación es: {resultadoMultiplicacion}");

        Console.ReadKey();
    }
}