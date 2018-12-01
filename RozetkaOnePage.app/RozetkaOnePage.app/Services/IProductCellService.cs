using RozetkaOnePage.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RozetkaOnePage.app.Services
{
    public interface IProductCellService
    {
        List<ProductModel> GetProductCells();
        ProductModel GetUserById(Guid id);
    }
}
