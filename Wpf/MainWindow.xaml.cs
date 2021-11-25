using System.Windows.Controls;

namespace Example;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContextChanged += MainWindow_DataContextChanged;
    }

    private void MainWindow_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is MainWindowViewModel vm)
        {
            vm.OnViewportChanged += Vm_OnViewportChanged;
        }
    }

    private void Vm_OnViewportChanged(object? sender, ViewportChangedEventArgs e)
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
