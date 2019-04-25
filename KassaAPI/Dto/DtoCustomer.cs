using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Dto
{
    public class DtoCustomer
    {
        public string X_uuid { get; set; }
        public string X_kaartUuid { get; set; }
        public string X_addressUuid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Barcode { get; set; }
        public string Vat { get; set; }
        public bool X_actief { get; set; }
        public bool X_geblokkeerd { get; set; }
        public DateTime Timestamp { get; set; }
        public string X_version { get; set; }

        public DtoCustomer(string x_uuid, string x_kaartUuid, string x_addressUuid, string name, string email, string barcode, string vat, bool x_actief, bool x_geblokkeerd, DateTime timestamp, string x_version)
        {
            X_uuid = x_uuid;
            X_kaartUuid = x_kaartUuid;
            X_addressUuid = x_addressUuid;
            Name = name;
            Email = email;
            Barcode = barcode;
            Vat = vat;
            X_actief = x_actief;
            X_geblokkeerd = x_geblokkeerd;
            Timestamp = timestamp;
            X_version = x_version;
        }
    }
}
