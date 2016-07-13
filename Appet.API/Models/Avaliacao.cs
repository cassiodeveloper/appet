using System;

namespace Appet.API.Models
{
    [Serializable]
    public class Avaliacao : Identificacao
    {
        public Estabelecimento Estabelecimento { get; set; }
        public Usuario Usuario { get; set; }
        public int Atendimento { get; set; }
        public int Localizacao { get; set; }
        public int Qualidade { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
    }
}