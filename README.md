# XamFluentUI
Fluent UI API para Xamarin Forms

Con este conjunto de m�todos de extensi�n, puede crear vistas para sus aplicaciones con Xamarin Forms utilizando C#.

Para ver la diferencia en la creaci�n con XAML, puede ver c�mo se ve el MainView desde el ejemplo:

```C#
public class MainView : ContentPage
    {
        public MainView()
        {
            Content = new Grid()
                .AddContent(
                    new StackLayout()
                        .Alignment(LayoutOptions.Center, LayoutOptions.Center)
                        .AddContent(
                            new Label().TextAlignment(TextAlignment.Center, TextAlignment.Center)
                                .Text("Hello Xamarin Fluent", Color.Gray)));
        }
    }
```

Puedes utilizar diferente modos para a�adir vistas a tus "Layouts". De este modo el c�digo se identar� automaticamente en Visual Studio y favorecer� la legibilidad.

Puedes utilizar una funci�n o a�adir vistas directamente:

```C#
var demo = new Grid().AddContent(() => new List<View>
{
    //Aqu� las vistas
});

var demo = new Grid().AddContent(new View[]
{
    //Aqu� las vistas
});

var demo = new Grid().AddContent(
    //Aqu� las vistas
    );
```