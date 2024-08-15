using System.ComponentModel.DataAnnotations;

namespace FakeStoreMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        
        public string Image { get; set; }
        public string category { get; set; }
    }
}
