using Appet.API.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Appet.API.Models
{
    [Serializable]
    public class EstabelecimentoModel : IdentificacaoModel, IAuditoria
    {
        public string Nome { get; set; }
        //public EnderecoModel Endereco { get; set; }
        public string PessoaResponsavel { get; set; }
        public string WebSite { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        //public virtual UsuarioModel Usuario { get; set; }
        //public virtual ConsultaModel Consulta { get; set; }
        public virtual ICollection<AvaliacaoModel> Avaliacoes { get; set; }
    }
}