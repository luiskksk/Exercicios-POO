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

        public new void Exibirinfo()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano: {ano}");
        }
    }


    
}