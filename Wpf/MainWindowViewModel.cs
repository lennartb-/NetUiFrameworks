using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace Wpf;

public class MainWindowViewModel : ObservableObject
{
    private readonly IViewportCalculator viewportCalculator;
    private int windowWidth = 800;
    private bool isFullMenuVisible;

    public event EventHandler<ViewportChangedEventArgs> OnViewportChanged = (_, _) => { };

    public MainWindowViewModel(IViewportCalculator viewportCalculator)
    {
        this.viewportCalculator = viewportCalculator;
        RecalculateViewport(WindowWidth);

    }


    public int WindowWidth
    {
        get => windowWidth;
        set
        {
            SetProperty(ref windowWidth, value);
            RecalculateViewport(windowWidth);
        }
    }

    public Viewport CurrentViewport { get; set; }

    private void RecalculateViewport(int width)
    {

        var vp = viewportCalculator.GetViewportForWidth(width);

        if (vp != CurrentViewport)
        {
            OnViewportChanged.Invoke(this, new ViewportChangedEventArgs(vp));
            CurrentViewport = vp;
        }

        switch (CurrentViewport)
        {
            case Viewport.Smartphone:
                IsFullMenuVisible = false;
                break;
            case Viewport.Desktop:
                IsFullMenuVisible = true;
                break;
        }

    }

    public bool IsSmallMenuVisible => !IsFullMenuVisible;

    public bool IsFullMenuVisible
    {
        get => isFullMenuVisible;
        set
        {
            SetProperty(ref isFullMenuVisible, value);
            OnPropertyChanged(nameof(IsSmallMenuVisible));
        }
    }
}