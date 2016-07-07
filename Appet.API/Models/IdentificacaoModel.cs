using System;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class IdentificacaoModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}