using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaLanchonete.Entities
{
    internal class Lanches
    {
        //get set
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        //construtor
        public Lanches(string nome, string descricao, decimal preco)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"{Nome} - {Descricao} - R${Preco:F2}";
        }
    }
}