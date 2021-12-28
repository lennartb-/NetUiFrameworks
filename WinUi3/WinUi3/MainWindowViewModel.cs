using System.Collections.Generic;
using Windows.Foundation;
using Microsoft.Toolkit.Mvvm.Input;
using Shared;

namespace WinUi3
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DataGridItems = new[]
            {
                new SampleModel("Mustermann", "Michael", true),
                new SampleModel("Musterfrau", "Michaela", true),
                new SampleModel("Musterperson", "Maxi", true),
            };
        }

        public IEnumerable<SampleModel> DataGridItems { get; set; }
    }
}