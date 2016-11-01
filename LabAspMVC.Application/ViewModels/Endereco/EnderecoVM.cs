using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabAspMVC.Application.ViewModels.Endereco
{
    public class EnderecoVM
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "*")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "*")]
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Número")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "*")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "*")]
        public string Estado { get; set; }
    }
}