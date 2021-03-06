﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.Models
{
    public class VehicleVM
    {
        public int Id { get; set; }
        public string LicencePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string ChassisNo { get; set; }
        public int OwnerId { get; set; }
        public int? CustomerId { get; set; }
    }
}
