using System;

namespace EjercicioPolimorfismo
{
   
    class Circulo : Figura
    {
        // Atributo específico de la clase Circulo
        private double radio;

        // Constructor de la clase Circulo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Implementación del método CalcularArea para la clase Circulo
        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
