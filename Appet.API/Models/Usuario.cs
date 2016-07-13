using Appet.API.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class Usuario : Identificacao, IAuditoria
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
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}