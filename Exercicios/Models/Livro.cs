namespace Exercicios.Models
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private int ano;
        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }

        public void Exibirinfo()
        {
            Console.WriteLine($"Título: {titulo}\n");
            Console.WriteLine($"Autor: {autor}\n");
            Console.WriteLine($"Ano: {ano}\n");
        }
    }
}