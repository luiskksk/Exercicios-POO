using Exercicios.Models;

public class Program
{
    public static void Main()
    {
        Livro livro1 = new Livro("A Biblioteca da Meia-Noite", "Matt Haig", 2020);
        livro1.Exibirinfo();
    }
}
