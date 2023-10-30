namespace maui_svg_ttf;

public partial class MainPage : ContentPage
{
    public Color Color => Color.FromRgb(RedValue, 0, 0);

    private int _redValue = 128;
    public int RedValue
    {
        get => _redValue;
        set
        {
            _redValue = value;
            OnPropertyChanged(nameof(RedValue));
            OnPropertyChanged(nameof(Color));
        }
    }


    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}