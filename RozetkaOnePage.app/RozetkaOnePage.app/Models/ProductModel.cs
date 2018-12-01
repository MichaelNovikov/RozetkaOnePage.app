using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RozetkaOnePage.app.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public ImageSource Image { get; set; }
    }
}
