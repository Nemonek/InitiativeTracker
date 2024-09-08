using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;
using Avalonia.ReactiveUI;

namespace InitiativeTracker.Android;

[Activity(
    Label = "Initiative tracker",
    Theme = "@style/MyTheme.NoActionBar",
    //Icon = "@drawable/icon",
    Icon = "@drawable/ApplicationLogo",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont().UseReactiveUI();
    }
}
