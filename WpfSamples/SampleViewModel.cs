using System.Collections.ObjectModel;
using Microsoft.Toolkit.Mvvm.Input;
using Shared;

namespace WpfSamples;

public class SampleViewModel
{
    public SampleViewModel()
    {
        RefreshCommand = new RelayCommand(OnRefreshButtonClicked);
    }

    public ObservableCollection<SampleModel> Items { get; set; } = new();

    public RelayCommand RefreshCommand { get; set; }

    private void OnRefreshButtonClicked()
    {
        Items.Add(SampleModelProvider.GetModel());
    }
}