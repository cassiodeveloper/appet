using System;

namespace Appet.API.Models
{
    [Serializable]
    public class CidadeModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public EstadoModel Estado { get; set; }
    }
}