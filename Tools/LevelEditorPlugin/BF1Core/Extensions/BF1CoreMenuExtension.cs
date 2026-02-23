using Frosty.Core;
using LevelEditorPlugin.BF1Core.Native;
using System.Windows;

namespace LevelEditorPlugin.BF1Core.Extensions;

public class BF1CoreMenuExtension : MenuExtension
{
    public override string TopLevelMenuName => "Map";
    public override string MenuItemName => "Battlefield 1 Map Editor";

    private MainWindow mainWindow = null;

    public BF1CoreMenuExtension()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            if (mainWindow == null)
            {
                mainWindow = new MainWindow();
                mainWindow.Hide();
            }

            HotKey.AddKey(Keys.F1);
            HotKey.AddKey(Keys.F5);
            HotKey.Run();
        });
    }

    public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
    {
        // First creation
        if (mainWindow == null)
            goto RE_CREATE;

        // Window hidden
        if (mainWindow.Visibility == Visibility.Hidden)
        {
            mainWindow.Show();
            return;
        }

        // Window minimized
        if (mainWindow.WindowState == WindowState.Minimized)
        {
            mainWindow.WindowState = WindowState.Normal;
            return;
        }

        // Window not topmost (false means window has been closed)
        if (mainWindow.IsVisible)
        {
            mainWindow.Topmost = true;
            mainWindow.Topmost = false;
            return;
        }

        // Window was closed, recreate
        mainWindow.Close();
        mainWindow = null;

    RE_CREATE:
        mainWindow = new MainWindow();
        mainWindow.Show();
    });
}
