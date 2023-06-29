using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProgramacion
{
    public class Rectangulo
    {
        //Dos variables de instancia privadas de tipo double llamadas longitud y ancho.
        private double longitud;
        private double ancho;

      
        //Un constructor sin parámetros que inicialice las variables de instancia a cero.
        public Rectangulo()
        {

        }
       // Un constructor con parámetros que permita establecer los valores de longitud y ancho al momento de crear un objeto de la clase.
       public Rectangulo(double longitud, double ancho )
        {

        }
        //Propiedades públicas Longitud y Ancho que permitan acceder y modificar las variables de instancia.
        public double Longitud { get; set; }
        public double Ancho { get; set; }
        ///Un método público llamado CalcularArea que calcule el área del rectángulo (multiplicando longitud por ancho) y lo devuelva como resultado.
        public double CalcularArea(double Longitud, double Ancho)
        {
            double resultado = Longitud * Ancho;

            return resultado;
        }
        
    }
}
