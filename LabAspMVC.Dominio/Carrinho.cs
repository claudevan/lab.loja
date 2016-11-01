using System.Collections.Generic;

namespace LabAspMVC.Dominio
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int ClienteId { get; set; }
        public List<Produto> produtos { get; set; }
    }
}
