namespace LabAspMVC.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }

        public virtual Categoria categoria { get; set; }
    }
}
