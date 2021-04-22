using OnlineShop.Core.DTOs;
using OnlineShop.Persistence;
using OnlineShop.Wpf.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OnlineShop.Wpf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private IEnumerable<ProductDto> _products;

        public ObservableCollection<ProductDto> Products { get; }


        private ProductDto _selectedProduct;

        public ProductDto SelectedProduct
        {
            get; set; //TODO
        }

        /// <summary>
        /// Durchschnittspreis aller angezeigten Produkte
        /// </summary>
        private string _avgPrice;

        public string AvgPrice
        {
            get; set; //TODO
        }

        /// <summary>
        /// Preisfilter "von"
        /// </summary>
        private string _filterPriceFrom;

        public string FilterPriceFrom
        {
            get; set; //TODO
        }

        /// <summary>
        /// Preisfilter "bis"
        /// </summary>
        private string _filterPriceTo;

        public string FilterPriceTo
        {
            get; set; //TODO
        }

        public ICommand CmdFilterProducts { get; set; }
        public ICommand CmdNewProduct { get; set; }
        public ICommand CmdEditProduct { get; set; }

        public MainWindowViewModel(IWindowController controller) : base(controller)
        {
            Products = new ObservableCollection<ProductDto>();
            LoadCommands();
        }

        private void LoadCommands()
        {
            //TODO
        }


        public static async Task<MainWindowViewModel> Create(IWindowController controller)
        {
            var model = new MainWindowViewModel(controller);
            await model.LoadProducts();
            return model;
        }

        /// <summary>
        /// Produkte laden. Produkte können nach Preis gefiltert werden. 
        /// Preis liegt zwischen from und to
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private async Task LoadProducts()
        {
            //TODO
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
