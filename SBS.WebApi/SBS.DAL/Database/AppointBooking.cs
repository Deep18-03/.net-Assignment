//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBS.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppointBooking
    {
        public int Id { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int VehicleId { get; set; }
        public int DealerId { get; set; }
        public Nullable<int> MechanicId { get; set; }
        public int ServiceId { get; set; }
        public int BookedBy { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Dealer Dealer { get; set; }
        public virtual Mechanic Mechanic { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
