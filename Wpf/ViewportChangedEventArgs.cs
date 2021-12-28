using System;

namespace Wpf;

public class ViewportChangedEventArgs : EventArgs
{
    public ViewportChangedEventArgs(Viewport newViewport)
    {
        NewViewport = newViewport;
    }

    public Viewport NewViewport { get; }
}