using LabAspMVC.Application.ViewModels.Cliente;
using LabAspMVC.Application.ViewModels.Produto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LabAspMVC.Application.ViewModels.Carrinho
{
    public class CarrinhoVM
    {
        [Key]
        public int SessionId { get; set; }
        [Required(ErrorMessage = "*")]
        public ClienteVM Cliente { get; set; }

        public SelectList Produto { get; set; }

        [Required(ErrorMessage = "*")]
        public List<ProdutoVM> produtos { get; set; }
    }
}