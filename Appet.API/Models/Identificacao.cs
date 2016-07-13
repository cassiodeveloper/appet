using System;
using System.Runtime.Serialization;

namespace Appet.API.Models
{
    [Serializable]
    [DataContract]
    public class Identificacao
    {
        [DataMember]
        public int Id { get; set; }
    }
}