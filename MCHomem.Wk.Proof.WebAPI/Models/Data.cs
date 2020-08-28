using System;

namespace MCHomem.Wk.Proof.WebAPI.Models
{
    [Serializable()]
    public class Data
    {
        public String BinaryValue { get; set; }
    }

    public enum Source
    {
        Left
        , Right
    }
}
