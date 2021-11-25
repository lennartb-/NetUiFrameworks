using System.Collections.Generic;

namespace Example;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    public IEnumerable<Model> Items { get; set; } = new List<Model>
    {
        new("Erdbeere", @"Resources\strawberry.jpg"),
        new("Ananas", @"Resources\pineapple.jpg")
    };
}

public record Model(string Name, string Image);