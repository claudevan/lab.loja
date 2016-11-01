using System.Collections.Generic;

namespace LabAspMVC.Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
