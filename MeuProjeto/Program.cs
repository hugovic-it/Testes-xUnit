using System;

namespace MeuProjeto;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olár");

        Usuario user1 = new Usuario() { Nome = "Joao", Idade=16,Peso=60};
        Usuario user2 = new Usuario() { Nome = "Jose", Idade= 21, Peso = 75 };

        bool resultado1 = OperacoesServices.UsuarioMaiorDeIdade(user1);
        Console.WriteLine($"O usuário {user1.Nome} é maior de idade? {resultado1}" );
        bool resultado2 = OperacoesServices.UsuarioMaiorDeIdade(user2);
        Console.WriteLine($"O usuário {user2.Nome} é maior de idade? {resultado2}");
    }
}