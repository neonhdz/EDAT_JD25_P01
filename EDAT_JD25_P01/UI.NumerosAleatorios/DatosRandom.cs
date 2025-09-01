using System;
using System.Collections.Generic;
using static UI.NumerosAleatorios.Empleadoo;

namespace UI.NumerosAleatorios
{
    internal class DatosRandom
    {
        List<Empleado> l = new List<Empleado>();
        Random r = new Random();
        public String nombre;
        string[] nombresmasculinos = { "Antonio", "Manuel", "José", "Francisco", "David", "Juan", "Javier", "José", "Daniel", "Miguel", "Esteban" };
        string[] nombresfemeninos = { "María", "Carmen", "Josefa", "Isabel", "Ana", "Laura", "Dolores", "Marta", "Cristina", "Pilar" };
        char[] g = { 'A', 'B', 'C', 'D' };
        string[] a = { "García", "Martínez", "López", "Sánchez", "Pérez", "González", "Rodríguez", "Fernández", "Gómez", "Díaz" };
        public void generar()
        {
            l.Clear();
            int numero = r.Next(10, 30);
            bool sexo = r.Next(2) == 0;
            if (sexo == false)
            {
                nombre = nombresfemeninos[r.Next(nombresfemeninos.Length)] + " " + a[r.Next(a.Length)] + " " + a[r.Next(a.Length)];

            }
            else
            {
                nombre = nombresmasculinos[r.Next(nombresmasculinos.Length)] + " " + a[r.Next(a.Length)] + " " + a[r.Next(a.Length)];
            }
            DateTime fecha = new DateTime(r.Next(1940, 2010), r.Next(1, 12), r.Next(1, 29));
            char grupo = g[r.Next(g.Length)];
            double salario = Math.Round(r.NextDouble() * 3000 + 1000, 4);
            bool seguro = r.Next(2) == 0;
            Empleado emp = new Empleado(numero, nombre, sexo, fecha, grupo, salario, seguro);
            l.Add(emp);
        }
        public List<Empleado> listaempleados()
        {
            return l;
        }
    }
}
