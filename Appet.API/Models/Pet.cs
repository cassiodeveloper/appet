using System;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class Pet : Identificacao
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public Tipo Tipo { get; set; }
        [DataMember]
        public string Cor { get; set; }
        [DataMember]
        public string Raca { get; set; }
        [DataMember]
        public DateTime DataNascimento { get; set; }
        [DataMember]
        public int Idade { get; set; }
        [DataMember]
        public Usuario Usuario { get; set; }
        [DataMember]
        public string Observacao { get; set; }

        //public virtual ConsultaModel Consulta { get; set; }
    }
}