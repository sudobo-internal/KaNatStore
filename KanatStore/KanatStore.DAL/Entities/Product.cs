using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace KanatStore.DAL.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name", TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column("Length", TypeName = "real")]
        public float Length { get; set; }
        [Column("Width", TypeName = "real")]
        public float Width { get; set; }
        [Column("Thickness", TypeName = "real")]
        public float Thickness { get; set; }
        [Column("Origin", TypeName = "nvarchar(50)")]
        public string Origin { get; set; }
        [Column("Image", TypeName = "nvarchar(100)")]
        public string Image { get; set; }
        [Column("Price", TypeName = "float")]
        public double Price { get; set; }
        [Column("ImportPrice", TypeName = "float")]
        public double ImportPrice { get; set; }
        [Column("Quantity", TypeName = "int")]
        public int Quantity { get; set; }
        [Column("Unit", TypeName = "nvarchar(50)")]
        public string Unit { get; set; }
        [Column("Status", TypeName = "nvarchar(50)")]
        public string Status { get; set; }
        [Column("Description", TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Column("CategoryId", TypeName = "int")]
        public int CategoryId { get; set; }
    }
}
