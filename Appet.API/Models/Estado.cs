using System;
using System.Collections.Generic;

namespace Appet.API.Models
{
    [Serializable]
    public class Estado : Identificacao
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}