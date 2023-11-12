using System;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de las clases
            Figura circulo = new Circulo(5);
            Figura cuadrado = new Cuadrado(4);

            // Mostrar información utilizando polimorfismo
            MostrarInformacion(circulo);
            MostrarInformacion(cuadrado);
        }

        static void MostrarInformacion(Figura figura)
        {
            // Utilizar polimorfismo para llamar al método CalcularArea de cada clase
            Console.WriteLine($"Tipo de Figura: {figura.GetType().Name}");
            Console.WriteLine($"Área: {figura.CalcularArea()}");
            Console.WriteLine(); // Línea en blanco para mejor legibilidad
        }
    }
}
