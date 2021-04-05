using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.Models
{
    public class ServiceVM
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal? Price { get; set; }
        public string Duration { get; set; }
        public bool? Active { get; set; }
    }
}
