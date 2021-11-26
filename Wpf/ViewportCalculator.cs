namespace Wpf;

public class ViewportCalculator : IViewportCalculator
{
    public Viewport GetViewportForWidth(int width)
    {
        return width <= 500 ? Viewport.Smartphone : Viewport.Desktop;
    }
}