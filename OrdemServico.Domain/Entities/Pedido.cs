using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoAustralia.Domain
{
    [Table("Pedidos")]
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public int ItemPedidoId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
