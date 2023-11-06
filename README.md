# maui-svg-ttf

.NET MAUI application that demonstrates recoloring, resizing, and rotation of vector graphics.
This repro includes a script for converting SVG icons to a TTF font.
The .NET MAUI demonstrates how to access the icons from the TTF font.

## 1. Convert your SVGs into a single TTF

Install Node.JS / NPM package https://www.npmjs.com/package/fantasticon and run the conversion script:

```bash
# Ubuntu / WSL script
sudo apt update
sudo apt install npm
sudo npm install -g fantasticon
cd maui-svg-ttf/scripts
./makefonts.sh
```

## 2. Add the TTF to your .NET MAUI application's resource

Make sure your new font `my-icons.ttf` gets copied to your `Resources/fonts/` folder.

## 3. Add it to the MauiProgram.cs ConfigureFonts

```c#
// MauiProgram.cs ...
var builder = MauiApp.CreateBuilder();
builder
    .UseMauiApp<App>()
    .ConfigureFonts(fonts =>
    {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        fonts.AddFont("my-icons.ttf", "my-icons");
    });
builder.Services.AddTransient<MainViewModel>();
builder.Services.AddTransient<MainPage>();
```

## 4. Use the font directly in XAML Label or FontImageSource

```xaml
<VerticalStackLayout>
    <Label Text="Globe &#xe000;" FontFamily="my-icons" TextColor="{Binding Color}"/>
    <Image HeightRequest="32" WidthRequest="32">
        <Image.Source>
            <FontImageSource Glyph="&#xe000;" FontFamily="my-icons" Color="{Binding Color}" Size="32" />
        </Image.Source>
    </Image>
    <Slider Minimum="0" Maximum="255" Value="{Binding RedValue, Mode=TwoWay}"/>
</VerticalStackLayout>
```

## See Also

https://stackoverflow.com/questions/74334591/specify-the-color-of-a-svg-image-in-net-maui/77429861#77429861
