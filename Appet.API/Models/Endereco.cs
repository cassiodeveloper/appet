using System;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class Endereco : Identificacao
    {
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Complemento { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public int CEP { get; set; }
        [DataMember]
        public Cidade Cidade { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        //public virtual EstabelecimentoModel Estabelecimento { get; set; }
    }
}