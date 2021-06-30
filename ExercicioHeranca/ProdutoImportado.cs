using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class ProdutoImportado : Produto
    {
        public double Imposto { get; set; }

        public ProdutoImportado(string nome, double preco, double imposto) : base(nome, preco)
        {
            Imposto = imposto;
        }

        public override string TagProduto()
        {
            return $"Nome: {Nome}, Preco: {Preco + Imposto}, imposto do produto: {Imposto}";
        }
    }
}
