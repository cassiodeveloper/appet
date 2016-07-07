using System;
using System.Collections.Generic;

namespace Appet.API.Models
{
    [Serializable]
    public class PaisModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public virtual ICollection<EstadoModel> Estados { get; set; }
    }
}