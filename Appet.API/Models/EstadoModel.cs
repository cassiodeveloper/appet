using System.Collections.Generic;

namespace Appet.API.Models
{
    public class EstadoModel : IdentificacaoModel
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public PaisModel Pais { get; set; }
        public virtual ICollection<CidadeModel> Cidades { get; set; }
    }
}