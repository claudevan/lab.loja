using LabAspMVC.Application.ViewModels.Endereco;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LabAspMVC.Application.ViewModels.Cliente
{
    public class ClienteVM
    {
        public ClienteVM()
        {
            Endereco = new EnderecoVM();
        }

        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "*")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        
        public EnderecoVM Endereco { get; set; }

        
    }
}