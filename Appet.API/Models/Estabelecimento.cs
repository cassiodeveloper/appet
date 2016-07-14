using Appet.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class Estabelecimento : Identificacao, IAuditoria
    {
        [DataMember]
        public string Nome { get; set; }
        //public EnderecoModel Endereco { get; set; }
        [DataMember]
        public string PessoaResponsavel { get; set; }
        [DataMember]
        public string WebSite { get; set; }
        [DataMember]
        public DateTime DataCadastro { get; set; }
        [DataMember]
        public DateTime UltimaAtualizacao { get; set; }
        //public virtual UsuarioModel Usuario { get; set; }
        //public virtual ConsultaModel Consulta { get; set; }
        [DataMember]
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}