using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class ProdutoUsad : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsad(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string TagProduto()
        {
            return base.TagProduto() + $" Data Fabricação: {DataFabricacao}";
        }
    }
}
