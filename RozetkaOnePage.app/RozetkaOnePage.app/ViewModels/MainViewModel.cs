using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RozetkaOnePage.app.Models;
using RozetkaOnePage.app.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RozetkaOnePage.app.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        IStatusBarColor _statusBarColor;
        IProductCellService _productCellService;

        public MainViewModel(INavigationService navigationService, IStatusBarColor statusBarColor, IProductCellService productCellService)
            : base(navigationService)
        {
            Title = "ROZETKA";

            _statusBarColor = statusBarColor;
            _productCellService = productCellService;
        }

        #region — Public properties —

        private List<ProductModel> _products;
        public List<ProductModel> Products
        {
            get { return _products; }
            set
            {
                SetProperty(ref _products, value);
            }
        }

        private ICommand _selectedItemCommand;
        public ICommand SelectedItemCommand => _selectedItemCommand ?? (_selectedItemCommand = new Command<Guid>(OnSelectedItemCommand));

        #endregion

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            _statusBarColor.SetColor("#00A046");

            Products = _productCellService.GetProductCells();
        }

        private async void OnSelectedItemCommand(Guid id)
        {
            var navParameters = new NavigationParameters();
            navParameters.Add("Id", id);
            await NavigationService.NavigateAsync("ProductDetailView", navParameters);
        }
    }
}
