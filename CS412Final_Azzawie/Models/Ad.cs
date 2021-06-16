using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS412Final_Azzawie.Models
{
    [Serializable]
    public class Ad
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public User User { get; set; }
        
        // I'll switch the type to be decimal later when we use the db
        public string Price { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
    }
}