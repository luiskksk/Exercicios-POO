namespace Exercicios.Models
{
    public class Funcionario
    {
        private string nome;
        private double salario;

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;

            if (salario < 0)
            {
                Console.WriteLine("Erro: salário não pode ser negativo.\n");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public void Exibirinfo()
        {
            Console.WriteLine($"Nome: {nome}\n");
            Console.WriteLine($"Salário: {salario}\n");
        }
    }
}

