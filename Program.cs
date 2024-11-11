using ProvaLanchonete.Entities;

namespace ProvaLanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lanchonete lanchonete = new Lanchonete();


            bool inicioPedido = true;

            while (inicioPedido)
            {
                try
                {
                    Console.WriteLine("Escolha uma Opção: ");
                    Console.WriteLine("1- Cardapio");
                    Console.WriteLine("2- Fazer Pedido");
                    Console.WriteLine("3- Conta");
                    Console.WriteLine("4- Cadastrar novo lanche");
                    Console.WriteLine("5- Sair");
                    Console.WriteLine("--------------------");


                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:

                            lanchonete.Cardapio();
                            break;

                        case 2:
                            Console.Write("Digite o número do lanche para adicinar ao pedido: ");
                            if (int.TryParse(Console.ReadLine(), out int indicelanche))
                            {
                                lanchonete.Pedido(indicelanche);
                            }
                            else
                            {
                                Console.WriteLine("Opçao Invalida");
                            }
                            break;

                        case 3:
                            lanchonete.Conta();
                            break;

                        case 4:
                            Console.Write("Nome Lanche: ");
                            string nome = Console.ReadLine();

                            Console.Write("Descrição: ");
                            string descricao = Console.ReadLine();

                            Console.Write("Preço: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal preco))
                            {
                                lanchonete.AdicionarLanche(nome, descricao, preco);
                            }
                            else
                            {
                                Console.WriteLine("Preço Inválido");
                                Console.WriteLine("--------------------"); ;
                            }
                            break;

                        case 5:
                            inicioPedido = false;
                            break;

                        default:
                            Console.WriteLine("Opção Invalida");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Erro, por favor digite um número");
                    Console.WriteLine("--------------------");
                }
            }
            Console.WriteLine("Obrigado pela preferencia volte sempre");
        }
    }
}
