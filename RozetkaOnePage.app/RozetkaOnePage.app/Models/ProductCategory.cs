using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RozetkaOnePage.app.Models
{
    public enum ProductCategory
    {
        [Description("Ноутбуки")]
        Laptops,
        [Description("Мобильные телефоны")]
        CellРhones,
        [Description("Планшеты")]
        Tablets
    }
}
