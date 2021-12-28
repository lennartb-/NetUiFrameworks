using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf;

public class SampleModel : INotifyPropertyChanged
{
    private string image;
    private string name;

    public SampleModel(string name, string image)
    {
        this.name = name;
        this.image = image;
    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public string Image
    {
        get => image;
        set
        {
            image = value;
            OnPropertyChanged(nameof(Image));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}