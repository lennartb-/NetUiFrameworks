namespace Wpf;

public interface IViewportCalculator
{
    Viewport GetViewportForWidth(int width);
}