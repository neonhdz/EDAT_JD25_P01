using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.NumerosAleatorios
{
    internal class Empleadoo
    {

        
        
        public class Empleado
        {

            private int numero;
            private string nombre;
            private bool sexo,seguro;
            private DateTime fechaNacimiento;
            private char grupo;
            private double salario;
            public Empleado() { }
            public Empleado(int numero, string nombre, bool sexo, DateTime fechaNacimiento, char grupo, double salario, bool seguro)
            {
                this.numero = numero;
                this.nombre = nombre;
                this.sexo = sexo;
                this.fechaNacimiento = fechaNacimiento;
                this.grupo = grupo;
                this.salario = salario;
                this.seguro = seguro;
            }
            public int Numero{
                get => numero;
                set => numero = value;
            }
            public string Nombre{
                get => nombre;
                set => nombre = value;
            }
            public bool Sexo{
                get => sexo;
                set => sexo = value;
            }
            public DateTime FechaNacimiento{
                get => fechaNacimiento;
                set => fechaNacimiento = value;
            }
            public double Salario{
                get => salario;
                set => salario = value;
            }
            public bool Seguro{
                get => seguro;
                set => seguro = value;
            }
            public char Grupo{
                get=>grupo;
                set=>grupo=value;
            }
        }

    }
}
