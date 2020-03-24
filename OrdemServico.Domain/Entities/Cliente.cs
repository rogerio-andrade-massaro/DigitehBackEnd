using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoAustralia.Domain
{
    [Table("Clientes")]
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string TelRes { get; set; }
        public string TelCel { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string LatLog { get; set; }
        public virtual List<Pedido> Pedido { get; set; }
    }
}
