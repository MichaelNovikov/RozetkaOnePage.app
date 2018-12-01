using Prism.Navigation;
using RozetkaOnePage.app.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RozetkaOnePage.app.ViewModels
{
    class ProductDetailViewModel : ViewModelBase
    {
        IProductCellService _productCellService;

        public ProductDetailViewModel(INavigationService navigationService, IProductCellService productCellService)
            : base(navigationService)
        {
            _productCellService = productCellService;
        }

        #region — Public properties —

        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image; }
            set
            {
                SetProperty(ref _image, value);
            }
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            var userId = parameters.GetValue<Guid>("Id");
            var user = _productCellService.GetUserById(userId);
            Image = user.Image;
        }

        #endregion
    }
}
