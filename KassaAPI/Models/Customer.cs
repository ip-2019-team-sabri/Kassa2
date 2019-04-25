using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Models
{
    public class Customer
    {
        public string Uuid { get; set; }
        public string KaartUuid { get; set; }
        public string AddressUuid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Barcode { get; set; }
        public string Vat { get; set; }
        public string Actief { get; set; }
        public string Geblokkeerd { get; set; }
        public int Timestamp { get; set; }
        public int Version { get; set; }

        public Customer(string uuid, string kaartUuid, string addressUuid, string name, string email, string barcode, string vat, string actief, string geblokkeerd, int timestamp, int version)
        {
            Uuid = uuid;
            KaartUuid = kaartUuid;
            AddressUuid = addressUuid;
            Name = name;
            Email = email;
            Barcode = barcode;
            Vat = vat;
            Actief = actief;
            Geblokkeerd = geblokkeerd;
            Timestamp = timestamp;
            Version = version;
        }
    }
}
