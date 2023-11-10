using System.ComponentModel.DataAnnotations;

namespace Eshop.Web.Entities.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
