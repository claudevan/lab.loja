using System;

namespace LabAspMVC.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int EnderecoId { get; set; }

        public virtual Endereco endereco{ get; set; }
    }
}
