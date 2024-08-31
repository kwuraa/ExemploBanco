using Exemplo_POO.Models;


//* ADQUIRINDO AS INFORMAÇÕES DO USUÁRIO
Console.WriteLine("Digite seu nome: ");
String nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ID da sua conta: ");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Valor(R$) que possui em sua conta: ");
decimal valor = Convert.ToDecimal(Console.ReadLine());

//* INSTANCIANDO OS OBJETOS - PESSOAS E CONTA !
Pessoa pessoa1 = new Pessoa(nome, idade);
ContaCorrente c1 = new ContaCorrente(id, valor);


//? MENU DE OPÇÕES !!!
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  pessoa1.Apresentacao();
  Console.WriteLine("Digite a opção: ");
  Console.WriteLine("1 - Saldo");
  Console.WriteLine("2 - Saque");
  Console.WriteLine("3 - Exibir Informações do usuario");
  Console.WriteLine("exit");
  

  switch (Console.ReadLine())
  {
    case "1":
      c1.ExbirSaldo();
      break;

    case "2":
      Console.WriteLine("Digite o valor do saque:");
      c1.Sacar(Convert.ToDecimal(Console.ReadLine()));
      break;

    case "3":
      Console.WriteLine("Informações do Usuario: ");
      Console.WriteLine($"Nome: {nome}");
      Console.WriteLine($"Idade: {idade}");
      Console.WriteLine($"Numero da Conta: {id}");
      break;

    case "exit":
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção invalida!!");
      break;
  }

    Console.WriteLine("Pressione Enter para continuar");
    Console.ReadLine();


}
    Console.WriteLine("Logout");