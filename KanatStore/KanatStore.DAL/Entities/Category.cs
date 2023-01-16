using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.DAL.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Tên danh mục")]
        public string Name { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { set; get; }

    }
}
