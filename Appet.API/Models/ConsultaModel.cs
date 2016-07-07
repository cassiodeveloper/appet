using System;

namespace Appet.API.Models
{
    [Serializable]
    public class ConsultaModel : IdentificacaoModel
    {
        public PetModel Pet { get; set; }
        public EstabelecimentoModel Estabelecimento { get; set; }
        public DateTime Data { get; set; }
        public bool Realizada { get; set; }
        public bool Confirmada { get; set; }
        public string ObservacaoPaciente { get; set; }
        public string ObservacaoEstabelecimento { get; set; }
    }
}