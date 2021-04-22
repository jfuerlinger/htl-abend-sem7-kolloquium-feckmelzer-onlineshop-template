using OnlineShop.Wpf.Common;
using OnlineShop.Wpf.ViewModels;
using System.Windows;

namespace OnlineShop.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private async void Application_Startup(object sender, StartupEventArgs e)
    {
      var controller = new WindowController();
      var viewModel = await MainWindowViewModel.Create(controller);
      controller.ShowWindow(viewModel);
    }
  }
}
