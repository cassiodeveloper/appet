using Appet.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class UsuarioModel : IdentificacaoModel, IAuditoria
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Sobrenome { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Senha { get; set; }
        [DataMember]
        public DateTime DataCadastro { get; set; }
        [DataMember]
        public DateTime UltimaAtualizacao { get; set; }
        public virtual ICollection<PetModel> Pets { get; set; }
        public virtual ICollection<AvaliacaoModel> Avaliacoes { get; set; }
    }
}