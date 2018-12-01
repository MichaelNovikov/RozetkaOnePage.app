using RozetkaOnePage.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RozetkaOnePage.app.Services
{
    public class ProductCellService : IProductCellService
    {
        private List<ProductModel> _products;

        public ProductCellService()
        {
            _products = new List<ProductModel>
            {
                new ProductModel
                {
                    Name = "Ноутбук Lenovo IdeaPad 330-151KBR",
                    ProductCategory = ProductCategory.Laptops,
                    ProductLabel = ProductLabel.TopSales,
                    Feedback = new List<string>{"","","","","","","",""},
                    Image = "notebook",
                    Price = 17499,
                    PreviousPrice = 18999
                },
                 new ProductModel
                {
                    Name = "Samsung Galaxy J6 2/32GB Black (SM-J600FZKDSEK)",
                    ProductCategory = ProductCategory.CellРhones,
                    ProductLabel = ProductLabel.SuperPrice,
                    Feedback = new List<string>{"","","","","","","","","","","","","","","",
                        "","","","","","","","","","","","","","","","","","","","","","","",""},
                    Image = "smBlack",
                    Price = 5499,
                    PreviousPrice = 5199
                },
                 new ProductModel
                {
                    Name = "Планшет Asus ZenPad 3S 10 4/64GB",
                    ProductCategory = ProductCategory.Tablets,
                    ProductLabel = ProductLabel.TopSales,
                    Feedback = new List<string>{"","","","","","","","","","","","","","","","","","","","","","","",""},
                    Image = "asus",
                    Price = 9499,
                    PreviousPrice = 8999
                },              
            };
        }

        public List<ProductModel> GetProductCells()
        {
            return _products;
        }

        public ProductModel GetUserById(Guid id)
        {
            return _products.Find(z => z.Id == id);
        }
    }
}
