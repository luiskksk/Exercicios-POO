namespace Exercicios.Models
{
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }

    public class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }
    }

    public class Triangulo : Forma
    {
        private double b, h;

        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public override double CalcularArea()
        {
            return (b * h) / 2;
        }
    }
}