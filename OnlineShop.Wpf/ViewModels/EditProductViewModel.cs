using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using OnlineShop.Core.DTOs;
using OnlineShop.Core.Entities;
using OnlineShop.Persistence;
using OnlineShop.Wpf.Common;

namespace OnlineShop.Wpf.ViewModels
{
    public class EditProductViewModel : BaseViewModel
    {
        private ProductDto _originalProduct;

        private string _titleString;

        public string TitleString
        {
            get => _titleString;
            set
            {
                _titleString = value;
                OnPropertyChanged();
            }
        }

        private string _editProductNr;


        public string EditProductNr
        {
            get; set; //TODO
        }

        private string _editName;


        public string EditName
        {
            get; set; //TODO
        }

        private double _editPrice;

        public double EditPrice
        {
            get; set; //TODO
        }

        public ICommand CmdSave { get; set; }

        public ICommand CmdUndo { get; set; }

        public EditProductViewModel(IWindowController controller, ProductDto product) : base(controller)
        {
            //TODO

            LoadCommands();
        }

        private void LoadCommands()
        {
            //TODO
        }


        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //TODO
            return Enumerable.Empty<ValidationResult>();
        }
    }
}
