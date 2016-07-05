using Appet.API.Models.Interfaces;
using System;

namespace Appet.API.Models
{
    public class UsuarioModel : IdentificacaoModel, IAuditoria
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}