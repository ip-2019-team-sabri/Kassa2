using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Uuid { get; set; }
        public int  Timestamp { get; set; }
        public int Version { get; set; }

        public Customer(string Name, string Email, string Uuid, int Timestamp, int Version) {
            this.Name = Name;
            this.Email = Name;
            this.Uuid = Uuid;
            this.Timestamp = Timestamp;
            this.Version = Version;
        }
    }
}
