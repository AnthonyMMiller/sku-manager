using System;
using System.ComponentModel.DataAnnotations;

namespace SkuManagementTool.Models
{
    // Represents a SKU (Stock Keeping Unit) in the system.
    public class Sku
    {
        // Primary key for the SKU.
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "SKU Number is required")]
        public string SkuNumber { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; } = DateTime.Now;

        // Continuing Education Units associated with the SKU.
        public decimal CEUs { get; set; }
        
        // Associated Course ID in Moodle.
        public int CourseId { get; set; }
        
        // Associated Package ID from UA.
        public int PackageId { get; set; }
        
        // Indicates whether the SKU is active.
        public bool IsActive { get; set; } = true;
    }
}
