using System.ComponentModel;
using System.Security.Cryptography;

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

         public void Cambiar (ref int numero)
        {
            numero = 100;
            
        }


        public void Calcular(int numero , out int doble , out int triple)
        {
            
            doble = numero * 2;
            triple = numero * 3;
        }

        public void cuentatras( int numero )
        {
            if (numero  <= 0)
            {
                return;
            }
             Console.WriteLine(numero); 
 
            cuentatras(numero - 1);
        }

        public void convertirnum(string texto)
        {
            try
            {
                int numero = int.Parse(texto);
                Console.WriteLine("Numero valido: "+ numero);
            }
            catch 
            {
                Console.WriteLine("Numero no valido");
            }
        }   
        
        
        public void pedirEdad()
        {
            try
            {
                Console.WriteLine("introduce tu edad");
                int edad = int.Parse(Console.ReadLine() ??"" );
                Console.WriteLine("tu edad es :" + edad);
            }
            catch 
            {
                Console.WriteLine(" El valor introducido no es válido");
            }

        }


            public void ValidarEdad(int edad)
        {
            if (edad < 0)
            {
                throw new Exception ("la edad no puede ser negativa.");

            }

            
            

        }
            
        




         

    


        
            
            
     
        
    }



    
} 