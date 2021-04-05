using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.Models
{
    public class BookingVM
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int MechanicId { get; set; }
        public int ServiceId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int? BookedBy { get; set; }
        public bool? Status { get; set; }
    }
}
