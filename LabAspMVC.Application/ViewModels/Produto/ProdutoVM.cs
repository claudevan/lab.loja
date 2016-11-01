using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LabAspMVC.Application.ViewModels.Produto
{
    public class ProdutoVM
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        //[Required(ErrorMessage = "*")]
        public SelectList Categoria { get; set; }

    }
}