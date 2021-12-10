using System.Windows;

namespace Wpf;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var window = new SampleView { DataContext = new SampleViewModel(new SampleModelProvider()) };
        window.Show();
    }
}