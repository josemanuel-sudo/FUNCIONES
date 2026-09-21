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

        
    }
}