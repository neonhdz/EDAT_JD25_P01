namespace Recursividad.Logica
{
    public class Recursividad
    {
        public int Factorial(int numero)
        {
            //Caso base

            if (numero == 0 || numero <= 1)
            {
                return 1;
            }

            //Caso general

            return numero * Factorial(numero - 1);
        }
        public int Potencia(int num,int exp)
        {
            //Caso base

            if (exp == 0)
            {
                return 1;
            }

            //Caso general

            return num * Potencia(num, exp - 1);
        }
    }
}
