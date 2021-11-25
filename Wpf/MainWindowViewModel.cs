using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Example
{
    public enum Viewport
    {
        Smartphone,
        Desktop
    }

    public class ViewportChangedEventArgs : EventArgs
    {
        public Viewport NewViewport { get; }

        public ViewportChangedEventArgs(Viewport newViewport)
        {
            NewViewport = newViewport;
        }
    }

    public interface IViewportCalculator
    {
        Viewport GetViewportForWidth(int width);
    }

    public class ViewportCalculator : IViewportCalculator
    {
        public Viewport GetViewportForWidth(int width)
        {
            return width <= 500 ? Viewport.Smartphone : Viewport.Desktop;
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly IViewportCalculator viewportCalculator;
        private int windowWidth;

        public event EventHandler<ViewportChangedEventArgs> OnViewportChanged = (sender, viewports) => { };

        public MainWindowViewModel(IViewportCalculator viewportCalculator)
        {
            this.viewportCalculator = viewportCalculator;
        }

        public int WindowWidth
        {
            get => windowWidth;
            set
            {
                windowWidth = value;
                OnPropertyChanged(nameof(WindowWidth));
                RecalculateViewport(windowWidth);
            }
        }

        public Viewport CurrentViewport { get; set; }

        private void RecalculateViewport(int width)
        {

            var vp =viewportCalculator.GetViewportForWidth(width);

            if (vp != CurrentViewport)
            {
                OnViewportChanged.Invoke(this, new ViewportChangedEventArgs(vp));
                CurrentViewport = vp;
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}