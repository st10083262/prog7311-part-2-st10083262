using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AgriConnectWebApp.Models
{
    public partial class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("category")]
        [StringLength(50)]
        public string Category { get; set; }
        [Column("production_date", TypeName = "date")]
        public DateTime? ProductionDate { get; set; }
        [Column("farmer_id")]
        public int? FarmerId { get; set; }

        [ForeignKey(nameof(FarmerId))]
        [InverseProperty("Products")]
        public virtual Farmer Farmer { get; set; }
    }
}
