using System.ComponentModel;

namespace funcionesejercicios
{
    public class Funciones
    {
        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al programa");
        }

        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}");
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double CalcularMedia(double a, double b, double c)
        {
            return (a+b+c/3);
        }

       /* public void mostrar()
        {
            int = numero 10;

        }*/
 
     /*public void Cambiar (int numero)
        {
            numero = 100;
            
        }*/



    }

    
} 