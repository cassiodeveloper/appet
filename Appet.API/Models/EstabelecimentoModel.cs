using Appet.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appet.API.Models
{
    public class EstabelecimentoModel : IdentificacaoModel, IAuditoria
    {
        public string Nome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public string PessoaResponsavel { get; set; }
        public string WebSite { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
    }
}