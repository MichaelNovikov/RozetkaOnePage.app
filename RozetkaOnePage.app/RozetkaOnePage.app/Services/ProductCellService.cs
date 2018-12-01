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
                new ProductModel{ Image = "notebook"},
                new ProductModel{ Image = "smBlack"},
                new ProductModel { Image = "asus"},
                new ProductModel{ Image = "notebook"},
                new ProductModel{ Image = "smBlack"},
                new ProductModel { Image = "asus"},
                new ProductModel{ Image = "notebook"},
                new ProductModel{ Image = "smBlack"},
                new ProductModel { Image = "asus"},
                new ProductModel{ Image = "notebook"},
                new ProductModel{ Image = "smBlack"},
                new ProductModel { Image = "asus"},
                new ProductModel{ Image = "notebook"},
                new ProductModel{ Image = "smBlack"},
                new ProductModel { Image = "asus"},
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
