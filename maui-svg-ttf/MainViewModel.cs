using CommunityToolkit.Mvvm.ComponentModel;

namespace maui_svg_ttf;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Color))]
    int _redValue = 128;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Color))]
    int _greenValue = 0;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Color))]
    int _blueValue = 0;

    [ObservableProperty]
    int _iconSize = 32;

    [ObservableProperty]
    int _angle = 0;

    public Color Color => Color.FromRgb(RedValue, GreenValue, BlueValue);
}
