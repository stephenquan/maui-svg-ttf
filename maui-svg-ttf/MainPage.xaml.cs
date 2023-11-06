namespace maui_svg_ttf;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel VM)
    {
        InitializeComponent();
        BindingContext = VM;
    }
}