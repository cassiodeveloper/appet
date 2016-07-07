using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appet.API.Models
{
    [Serializable]
    public class TipoModel : IdentificacaoModel
    {
        public string Nome { get; set; }
    }
}