using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [Key]
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Pruduct { get; set; }

        public int Quantity { get; set; }
    }
}