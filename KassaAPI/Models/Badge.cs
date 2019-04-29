using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Models
{
    public class Badge
    {
        public string Uuid { get; set; }
        public double Bedrag { get; set; }
        public string CustomerUuid { get; set; }
    }

   // public Badge(string uuid, double bedrag, string customeruuid)
}
