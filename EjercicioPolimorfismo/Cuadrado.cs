namespace EjercicioPolimorfismo
{
    // Clase derivada Cuadrado que hereda de Figura
    class Cuadrado : Figura
    {
        // Atributo específico de la clase Cuadrado
        private double lado;

        // Constructor de la clase Cuadrado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Implementación del método CalcularArea para la clase Cuadrado
        public override double CalcularArea()
        {
            return lado * lado;
        }
    }
}
