using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComposicao
{
    class Item
    {

        public int IdItem { get; }
        public Produto produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        Random randomico = new Random();
        public Item(Produto produto, int quantidade, double preco)
        {
            IdItem = randomico.Next();
            this.produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double SubTotal()
        {
            return Quantidade * produto.Preco;
        }

        public override string ToString()
        {
            return $"ID: {IdItem}, Produto: {produto.Nome}, Preço: {produto.Preco}, Quantidade: {Quantidade}, Subtotal: {SubTotal()}";

        }
    }
}
