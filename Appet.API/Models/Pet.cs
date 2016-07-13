using System;

namespace Appet.API.Models
{
    [Serializable]
    public class Pet : Identificacao
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public string Cor { get; set; }
        public string Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public Usuario Usuario { get; set; }
        public string Observacao { get; set; }
        //public virtual ConsultaModel Consulta { get; set; }
    }
}