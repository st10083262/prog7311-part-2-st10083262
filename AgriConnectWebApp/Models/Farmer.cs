using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AgriConnectWebApp.Models
{
    public partial class Farmer
    {
        public Farmer()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("farmer_id")]
        public int FarmerId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("location")]
        [StringLength(255)]
        public string Location { get; set; }
        [Column("contact_details")]
        [StringLength(255)]
        public string ContactDetails { get; set; }

        [InverseProperty(nameof(Product.Farmer))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
