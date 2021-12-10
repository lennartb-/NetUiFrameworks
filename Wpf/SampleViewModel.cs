using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Wpf;

public class SampleViewModel
{
    private readonly SampleModelProvider modelProvider;

    public ObservableCollection<SampleModel> Items { get; set; } = new();

    public RelayCommand RefreshCommand { get; set; }

    public SampleViewModel(SampleModelProvider modelProvider)
    {
        this.modelProvider = modelProvider;
        RefreshCommand = new RelayCommand(OnRefreshButtonClicked);
    }

    private void OnRefreshButtonClicked()
    {
        Items.Add(modelProvider.GetModel());
    }
}