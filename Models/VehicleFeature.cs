using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("VehicleFeatures")]
    public class VehicleFeature
    {
        public int VehicleId { get; set; } // foreign key property
        public int FeatureId { get; set; } // foreign key property
        public Vehicle Vehicle { get; set; } // navigation property
        public Feature Feature { get; set; } // navigation property
    }
}