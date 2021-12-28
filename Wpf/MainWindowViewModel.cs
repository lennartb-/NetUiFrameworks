using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Wpf;

public class MainWindowViewModel : ObservableObject
{
    private Viewport currentViewport;
    private bool isFullMenuVisible;
    private int windowWidth = 800;

    public MainWindowViewModel()
    {
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

    public event EventHandler<ViewportChangedEventArgs> OnViewportChanged = (_, _) => { };

    private void RecalculateViewport(int width)
    {
        var computedViewPort = width <= 500 ? Viewport.Smartphone : Viewport.Desktop;

        if (computedViewPort != currentViewport)
        {
            OnViewportChanged.Invoke(this, new ViewportChangedEventArgs(computedViewPort));
            currentViewport = computedViewPort;
        }

        switch (currentViewport)
        {
            case Viewport.Smartphone:
                IsFullMenuVisible = false;
                break;
            case Viewport.Desktop:
                IsFullMenuVisible = true;
                break;
        }
    }
}