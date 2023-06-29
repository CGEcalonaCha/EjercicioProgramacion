using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Además, en el método Main de la clase Program, sigue los siguientes pasos:
            //Crea un objeto de la clase Rectangulo llamado rectangulo.
            Rectangulo rectangulo = new Rectangulo();
            //Establece los valores de longitud y ancho del rectángulo utilizando las propiedades.
            rectangulo.Longitud = 45;
            rectangulo.Ancho = 74;
            //Calcula el área del rectángulo llamando al método CalcularArea."
            Console.WriteLine("El area de rectangulo es: "+rectangulo.CalcularArea(45,74));
            Console.ReadKey();
            //Muestra el resultado del cálculo del área en la consola.
            //Recuerda utilizar correctamente la sobrecarga de constructores, la manipulación de objetos y propiedades, y asegúrate de seguir las convenciones de nomenclatura adecuadas.
        }
    }
}
