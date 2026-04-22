using Exercicios.Models;

public class Program
{
    public static void Main()
    {
        Livro livro1 = new Livro("A Biblioteca da Meia-Noite", "Matt Haig", 2020);
        livro1.Exibirinfo();

        Funcionario f1 = new Funcionario("Luis", 3000);
        f1.Exibirinfo();

        Funcionario f2 = new Funcionario("João", -500); // vai mostrar erro
        f2.Exibirinfo();

        Bicicleta b = new Bicicleta();
        b.Mover();
        b.DarGrau();

        Forma c = new Circulo(2);
        Forma t = new Triangulo(3, 4);

        Console.WriteLine(c.CalcularArea());
        Console.WriteLine(t.CalcularArea());
    }

}


