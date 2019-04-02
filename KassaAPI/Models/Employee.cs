﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UUID { get; set; }
        public int Timestamp { get; set; }
        public int Version { get; set; }

        public Employee(string Name, string Email, string UUID, int Timestamp, int Version) {
            this.Name = Name;
            this.Email = Email;
            this.UUID = UUID;
            this.Timestamp = Timestamp;
            this.Version = Version;
        }
    }
}
