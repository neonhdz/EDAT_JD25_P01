namespace BibliotecaTarea01Recursividad;

public class RecursividadContenido
{

    // 1. Cantidad de vocales en una cadena
    public int vocals(string chain)
    {
        if (chain.Length == 0)
        {
            return 0;
        }
        char first = char.ToLower(chain[0]);
        int vocal = (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u') ? 1 : 0;

        return vocal + vocals(chain.Substring(1));
    }
    // 2. Suma de dígitos de un número
    public int suma1(int num1)
    {
        if (num1 < 10)
        {
            return num1;
        }

        return (num1 % 10) + suma1(num1 / 10);
    }
    // 3. Suma de los primeros n números
    public int suma2(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return suma2(n - 1) + n;
    }
}
