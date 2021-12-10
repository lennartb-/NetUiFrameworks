using Windows.Foundation;
using Microsoft.Toolkit.Mvvm.Input;

namespace WinUi3
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            SizeChangedCommand = new RelayCommand<Size>(
                size =>
                {
                    ViewportSize = size.Width /2d;
                });
        }

        public double ViewportSize { get; set; } = 400;


        public RelayCommand<Size> SizeChangedCommand { get; set; }
    }
}