using System.Windows;
using System.Windows.Controls;

namespace Wpf;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContextChanged += MainWindow_DataContextChanged;
    }

    private void MainWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is MainWindowViewModel vm)
        {
            vm.OnViewportChanged += OnViewportChanged;
        }
    }

    private void OnViewportChanged(object? sender, ViewportChangedEventArgs e)
    {
        switch (e.NewViewport)
        {
            case Viewport.Desktop:
                Grid.SetRow(DataGrid, 1);
                Grid.SetColumn(DataGrid, 1);
                break;
            case Viewport.Smartphone:
                Grid.SetRow(DataGrid, 2);
                Grid.SetColumn(DataGrid, 0);
                break;
        }
    }
}