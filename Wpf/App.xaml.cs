using System.Windows;

namespace Wpf;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        //var window = new SampleView { DataContext = new SampleViewModel(new SampleModelProvider()) };
        var window = new MainWindow { DataContext = new MainWindowViewModel() };
        window.Show();
    }
}