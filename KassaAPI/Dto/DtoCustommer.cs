using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Dto
{
    public class DtoCustommer
    {
        public string X_uuid { get; set; }
        public string X_kaartUuid { get; set; }
        public string X_addressUuid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Barcode { get; set; }
        public string Vat { get; set; }
        public string X_actief { get; set; }
        public string X_geblokkeerd { get; set; }
        public int Timestamp { get; set; }
        public int X_version { get; set; }
    }
}
