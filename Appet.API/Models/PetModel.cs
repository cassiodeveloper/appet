using System;

namespace Appet.API.Models
{
    public class PetModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public TipoModel Tipo { get; set; }
        public string Cor { get; set; }
        public string Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Observacao { get; set; }
    }
}