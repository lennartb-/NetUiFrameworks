#nullable disable

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Shared;

public class SampleModel : INotifyPropertyChanged
{
    private string firstName;
    private string name;
    private bool isRegistered;

    public SampleModel(string name, string firstName, bool isRegistered)
    {
        this.name = name;
        this.firstName = firstName;
        this.isRegistered = isRegistered;
    }

    public SampleModel()
    {
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

    public string FirstName
    {
        get => firstName;
        set
        {
            firstName = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }

    public bool IsRegistered
    {
        get => isRegistered;
        set
        {
            isRegistered = value;
            OnPropertyChanged(nameof(IsRegistered));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(
        [CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}