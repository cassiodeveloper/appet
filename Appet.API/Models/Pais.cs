using System;
using System.Collections.Generic;

namespace Appet.API.Models
{
    [Serializable]
    public class Pais : Identificacao
    {
        public string Nome { get; set; }
        public virtual ICollection<Estado> Estados { get; set; }
    }
}