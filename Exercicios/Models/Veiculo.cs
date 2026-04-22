namespace Exercicios.Models
{
    public class Veiculo
    {
        public void Mover()
        {
            Console.WriteLine("Movendo...\n");
        }
    }

    public class Bicicleta : Veiculo
    {
        public void DarGrau()
        {
            Console.WriteLine("Dando grau!\n");
        }
    }
}