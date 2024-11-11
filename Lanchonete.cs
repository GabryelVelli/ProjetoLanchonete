using ProvaLanchonete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLanchonete.Entities
{
    internal class Lanchonete
    {
        private List<Lanches> lanchesDisponiveis = new List<Lanches>();
        private Dictionary<Lanches, int> pedidoAtual = new Dictionary<Lanches, int>();


        public void AdicionarLanche(string nome, string descricao, decimal preco)
        {

            if (lanchesDisponiveis.Count <= 9)
            {
                Lanches lanche = new Lanches(nome, descricao, preco);
                lanchesDisponiveis.Add(lanche); //adiciona o lanche
                Console.WriteLine($"{lanche.Nome} foi Adicionado!");
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("Limite de Lanches adicionado Atingido!");
                Console.WriteLine("--------------------");
            }
        }

        public void Cardapio()
        {
            if (lanchesDisponiveis.Count == 0)
            {
                Console.WriteLine("Sem Lanches Disponiveis");
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("Lanches Disponíveis");
                int index = 1; //index começando no 1.
                foreach (var lanches in lanchesDisponiveis)
                {
                    Console.WriteLine($"{index}. {lanches}");
                    index++;
                    Console.WriteLine("--------------------");
                }
            }
        }

        public void Pedido(int indiceLanche)
        {
            if (indiceLanche >= 1 && indiceLanche <= lanchesDisponiveis.Count)
            {
                Lanches lancheEscolhido = lanchesDisponiveis[indiceLanche - 1];
                if (pedidoAtual.ContainsKey(lancheEscolhido))
                {
                    pedidoAtual[lancheEscolhido]++;
                }
                else
                {
                    pedidoAtual[lancheEscolhido] = 1;
                }
                Console.WriteLine($"{lancheEscolhido.Nome} escolhido para seu pedido");
                Console.WriteLine("--------------------");
            }
            else
            {
                Console.WriteLine("Opção de lanche inválido");
                Console.WriteLine("--------------------");
            }
        }


        public void Conta()
        {
            Console.WriteLine("Pedido: ");
            decimal total = 0;

            foreach (var item in pedidoAtual)
            {
                Lanches lanche = item.Key;
                int quantidade = item.Value;
                decimal subtotal = lanche.Preco * quantidade;
                total += subtotal;

                Console.WriteLine($"{lanche.Nome} - Quantidade: {quantidade} - Subtotal: R${subtotal:F2}");
            }
            decimal taxaServico = total * 0.07m;
            decimal totalComTaxa = total + taxaServico;

            Console.WriteLine($"Total: R${total:F2}");
            Console.WriteLine($"Taxa de Serviço (7%): R${taxaServico:F2}");
            Console.WriteLine($"Total com Serviço: R${totalComTaxa:F2}");
        }
    }
}
