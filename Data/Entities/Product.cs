using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Data.Entities
{
    public class Product : Entity
    {
        /// <summary>
        /// Name do Produto, string;
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Valor Base/de Custo do produto;
        /// </summary>
        public double Base_Value { get; set; }
        /// <summary>
        /// Valor de Venda para o produto;
        /// </summary>
        public double Resale_Value { get; set; }
        /// <summary>
        /// Informação referente a classificação Etaria caso exista para o produto;
        /// </summary>
        public string Rating { get; set; }
        /// <summary>
        /// Categoria em que o Produto se encaixa, quadrinho, revista e etc;
        /// </summary>
        public string Categorie { get; set; }
    }
}
