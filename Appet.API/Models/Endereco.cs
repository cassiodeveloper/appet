using System;

namespace Appet.API.Models
{
    [Serializable]
    public class Endereco : Identificacao
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public Cidade Cidade { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        //public virtual EstabelecimentoModel Estabelecimento { get; set; }
    }
}