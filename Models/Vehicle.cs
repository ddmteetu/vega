using System;
using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; } // foreign key property
        public Model Model { get; set; } // navigation property
        public bool IsRegistered { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }
        
        [StringLength(255)]
        public string ContactEmail { get; set; }
        
        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}