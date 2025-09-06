internal class Principal
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Practica Funciones Lambda\n\n");
        Console.WriteLine("___________________________________________________\n");
        // Este programa nos permitirá:
        // 1. Calcular el promedio de un arreglo de números enteros.
        // 2. Dado un arreglo de números enteros, crear una función lambda que retorne el número menor.
        // 3. Crear una función lambda que reciba como parámetro 3 números enteros.La función retorna el número mayor.
        // 4. Crear una función lambda que reciba dos parámetros, un string y un número entero. La función retorna un string el cual será el resultado de multiplicar ambos parámetros.

        var nums = new int[] { 5, 10, 15, 20, 25 };

        // 1. Calcular el promedio de un arreglo de números enteros.
        Console.WriteLine("1. Calcular el promedio de un arreglo de números enteros.\n");
        Func<int[], int> cprom = nums => {
            int suma = 0;
            foreach (int i in nums)
            {
                suma += i;
            }
            int resultado= suma / nums.Length;
            return resultado;

        };
        int promedio=cprom(nums);
        for (int x = 0; x < nums.Length; x++)
        {
            Console.WriteLine($"Número {x + 1}: {nums[x]}");
        }
        Console.WriteLine($"El promedio es: {promedio}");
        Console.WriteLine("___________________________________________________\n");

        // 2. Dado un arreglo de números enteros, crear una función lambda que retorne el número menor.
        Console.WriteLine("2. Dado un arreglo de números enteros, crear una función lambda que retorne el número menor.\n");
        Func<int[], int> menor = nums =>{
            int min = nums[0];
            foreach (int i in nums)
            {
                if (i < min) min = i;
            }
            return min;
        };
        int numeroMenor = menor(nums);
        for (int x = 0; x < nums.Length; x++)
        {
            Console.WriteLine($"Número {x + 1}: {nums[x]}");
        }
        Console.WriteLine($"El número menor es: {numeroMenor}");
        Console.WriteLine("___________________________________________________\n");

        // 3. Crear una función lambda que reciba como parámetro 3 números enteros.La función retorna el número mayor.
        Console.WriteLine("3. Crear una función lambda que reciba como parámetro 3 números enteros.La función retorna el número mayor.\n");
        var numsmay = new int[] { 5, 15,10 };
        Func<int[], int> mayor = numsmay => {
            int may = numsmay[0];
            foreach (int i in numsmay)
            {
                if (i > may) may = i;
            }
            return may;
        };
        int numMayor = mayor(numsmay);
        for (int x = 0; x < numsmay.Length; x++)
        {
            Console.WriteLine($"Número {x + 1}: {numsmay[x]}");
        }
        Console.WriteLine($"El número mayor es: {numMayor}");
        Console.WriteLine("___________________________________________________\n");

        // 4. Crear una función lambda que reciba dos parámetros, un string y un número entero.
        // La función retorna un string el cual será el resultado de multiplicar ambos parámetros.
        Console.WriteLine("4. Crear una función lambda que reciba dos parámetros, un string y un número entero." +
            "\nLa función retorna un string el cual será el resultado de multiplicar ambos parámetros.\n");
        Func<string, int, string> multstr = (text, multiplicador) =>
        {
            string resultado = "";
            for (int i = 0; i < multiplicador; i++)
            {
                resultado += text;
            }
            return resultado;
        };
        string resultado = multstr("Hola", 3);
        Console.WriteLine(resultado);  // Salida: HolaHolaHola
        Console.WriteLine("___________________________________________________ \n");

        Console.ReadKey();
    }
}