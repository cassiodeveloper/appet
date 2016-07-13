using System;

namespace Appet.API.Models
{
    [Serializable]
    public class Cidade : Identificacao
    {
        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}