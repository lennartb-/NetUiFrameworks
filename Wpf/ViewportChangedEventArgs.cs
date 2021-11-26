using System;

namespace Wpf;

public class ViewportChangedEventArgs : EventArgs
{
    public Viewport NewViewport { get; }

    public ViewportChangedEventArgs(Viewport newViewport)
    {
        NewViewport = newViewport;
    }
}