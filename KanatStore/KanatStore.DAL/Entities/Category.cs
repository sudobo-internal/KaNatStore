using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanatStore.DAL.Entities
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column("Description", TypeName = "nvarchar(500)")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { set; get; }

    }
}
