namespace WinUi3
{
    /// <summary>
    ///     An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();
        }

        public MainWindowViewModel ViewModel { get; set; }
    }
}