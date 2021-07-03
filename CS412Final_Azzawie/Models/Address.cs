using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Models
{
    [Serializable]
    public class Address
    {
        public long Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string ZipCode { get; set; }
        public string UnitNumber { get; set; }
    }
}