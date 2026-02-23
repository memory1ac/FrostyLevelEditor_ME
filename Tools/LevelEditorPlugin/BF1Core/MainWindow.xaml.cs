using LevelEditorPlugin.Entities;
using LevelEditorPlugin.Screens;
using System;
using System.ComponentModel;
using System.Windows;

namespace LevelEditorPlugin.BF1Core;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Current window instance for operating this window
    /// </summary>
    public static MainWindow WinInstance { get; private set; } = null;

    /// <summary>
    /// Constructor
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        WinInstance = this;
    }

    /// <summary>
    /// Window load event
    /// </summary>
    private void Window_Main_Loaded(object sender, RoutedEventArgs e)
    {
    }

    /// <summary>
    /// Window content rendered event
    /// </summary>
    private void Window_Main_ContentRendered(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Window closing event
    /// </summary>
    private void Window_Main_Closing(object sender, CancelEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
        e.Cancel = true;
    }

    /// <summary>
    /// Update selected entity
    /// </summary>
    public static void UpdateSelectedEntity(Entity entity, LevelEditorScreen screen)
    {
        if (WinInstance == null)
            return;

        WinInstance.TabItem_MeshView.UpdateSelectedEntity(entity, screen);
    }

    /// <summary>
    /// Update entity Transform info
    /// </summary>
    public static void UpdateEntityTransform()
    {
        if (WinInstance == null)
            return;

        WinInstance.TabItem_MeshView.UpdateUI();
    }
}
