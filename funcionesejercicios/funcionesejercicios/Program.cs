
using System.Runtime.InteropServices;

namespace funcionesejercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funciones f = new Funciones();
            //Ejercio 1
            //f.MostrarMensaje();

            //Ejericio 2
            //f.Saludar("Jesús");

            //Ejercicio 3
            //Console.WriteLine($"La suma es {f.Sumar(10,5)}");
        
            //Ejercicio 4
            //Console.WriteLine($"La media es {f.CalcularMedia(7.5,8,6.5)}");

            //EJERCICIO 5
           //Console.WriteLine(numero);

           //EJERCICIO 6
           
            /*int valor = 10;
            f.Cambiar(valor);
            Console.WriteLine(valor);*/
            
           
           //EJERCICIO 7
           
           
            int valor = 10;
            f.Cambiar( ref valor);
            Console.WriteLine(valor);
           
           
            
        }


    }
}