using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appet.API.Models
{
    [Serializable]
    public class Tipo : Identificacao
    {
        public string Nome { get; set; }
    }
}