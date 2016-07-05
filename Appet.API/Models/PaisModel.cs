using System.Collections.Generic;

namespace Appet.API.Models
{
    public class PaisModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public virtual ICollection<EstadoModel> Estados { get; set; }
    }
}