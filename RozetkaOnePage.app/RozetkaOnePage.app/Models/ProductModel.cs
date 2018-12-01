using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RozetkaOnePage.app.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public ProductCategory ProductCategory { get;set;}
        public ProductLabel ProductLabel { get; set; }
        public float Price { get; set; }
        public float PreviousPrice { get; set; } 
        public ImageSource Image { get; set; }
        public ProductRating ProductRating { get; set; }
        public List<string> Feedback { get; set; }
    }
}
