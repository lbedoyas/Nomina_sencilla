using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Program
    {


        static void Main(string[] args)
        {
            string nombre;
            decimal valorHora, numeroHoras, salarioMinimo, salario;
            PedirDatos(out nombre, out valorHora, out numeroHoras ,out salarioMinimo);
            salario = CalcularSalario(numeroHoras, valorHora);
            MostrarResultado(nombre, salarioMinimo, salario);
        }

        static void PedirDatos(out string nombre, out decimal valorHora,out decimal numeroHoras ,
            out decimal salarioMinimo)
        {
            Console.Write("Ingrese nombre: .................... ");
            nombre = Console.ReadLine();
            do
            {
                Console.Write("Ingrese valor de hora............... ");
                valorHora = pedirDecimal();
            } while (valorHora <= 0);
            Console.Write("Ingrese numero de horas trabajadas...");
            numeroHoras = pedirDecimal();
            Console.Write("Ingrese salario minimo ............. ");
            salarioMinimo = pedirDecimal();

        }

        //asi es la estructura cuando devuelve un valor
        static decimal CalcularSalario(decimal numeroHoras,decimal valorHora)
        {
            return numeroHoras * valorHora;
        }

        static void MostrarResultado(string nombre,decimal salarioMinimo,decimal salario)
        {
           Console.WriteLine("Nombre ...............{0}",nombre);
           if(salario>salarioMinimo)
            {
                Console.WriteLine("Salario .........${0:N2}",salario);

            }
            Console.ReadKey();
        }

        static decimal pedirDecimal()
        {
            
            string aux = Console.ReadLine();
            try
            {
                return Convert.ToDecimal(aux);
                
            }
            catch (Exception)
            {
                return 0;
            }

            
        }

    }
}
