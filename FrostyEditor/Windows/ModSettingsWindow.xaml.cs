using Frosty.Controls;
using Frosty.Core;
using Frosty.Core.Mod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace FrostyEditor.Windows
{
    /// <summary>
    /// Interaction logic for ModSettingsWindow.xaml
    /// </summary>
    public partial class ModSettingsWindow : FrostyDockableWindow
    {
        private ModSettings ModSettings => project.GetModSettings();
        private FrostyProject project;

        private List<string> categories = new List<string>()
        {
            "Custom",
            "Audio",
            "Cosmetic",
            "Gameplay",
            "Graphic",
            "Map",
            "User Interface"
        };

        public ModSettingsWindow(FrostyProject inProject = null)
        {
            InitializeComponent();

            project = inProject;
            Loaded += ModSettingsWindow_Loaded;

            // 2026/01/20
            // 改动标记
            ContentRendered += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(ModSettings.Title))
                    modTitleTextBox.Text = DateTime.Now.ToString("yyyyMMdd-HHmmss");
                if (string.IsNullOrWhiteSpace(ModSettings.Author))
                    modAuthorTextBox.Text = "CrazyZhang And memory_ac";
                if (string.IsNullOrWhiteSpace(ModSettings.Version))
                    modVersionTextBox.Text = "2.0.0.0";
                if (ModSettings.SelectedCategory == 0)
                    modCategoryComboBox.SelectedIndex = 3;
                if (string.IsNullOrWhiteSpace(ModSettings.Link))
                    modPageLinkTextBox.Text = "https://battlefield.vip";
                if (string.IsNullOrWhiteSpace(ModSettings.Description))
                    modDescriptionTextBox.Text = "BF1 Marne Mod Developed By CrazyZhang And memory_ac\nWebsite: https://battlefield.vip";

                if (ModSettings.Icon == null)
                {
                    var icon = GetResourceImageBytes("/Images/FbMod/128x128.png");
                    iconImageButton.SetImage(icon);
                }
            };
        }

        private void ModSettingsWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            modCategoryComboBox.ItemsSource = categories;

            modTitleTextBox.Text = ModSettings.Title;
            modAuthorTextBox.Text = ModSettings.Author;
            modCategoryComboBox.SelectedIndex = ModSettings.SelectedCategory;
            modVersionTextBox.Text = ModSettings.Version;
            modDescriptionTextBox.Text = ModSettings.Description;

            // 2026/01/20
            // 改动标记
            modPageLinkTextBox.Text = ModSettings.Link;

            if (modCategoryComboBox.SelectedItem.ToString() == "Custom")
            {
                modCategoryTextBox.Text = ModSettings.Category;
                modCategoryTextBox.IsEnabled = true;
            }
            else
            {
                modCategoryTextBox.Text = categories[ModSettings.SelectedCategory];
                modCategoryTextBox.IsEnabled = false;
            }

            iconImageButton.SetImage(ModSettings.Icon);
            ssImageButton1.SetImage(ModSettings.GetScreenshot(0));
            ssImageButton2.SetImage(ModSettings.GetScreenshot(1));
            ssImageButton3.SetImage(ModSettings.GetScreenshot(2));
            ssImageButton4.SetImage(ModSettings.GetScreenshot(3));
        }

        private void cancelButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void saveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (modTitleTextBox.Text == "" || modAuthorTextBox.Text == "" || modCategoryTextBox.Text == "" || modVersionTextBox.Text == "")
            {
                FrostyMessageBox.Show("Title, Author, Category and Version are mandatory fields", "Frosty Editor");
                return;
            }

            ModSettings.Title = modTitleTextBox.Text;
            ModSettings.Author = modAuthorTextBox.Text;
            ModSettings.Category = modCategoryTextBox.Text;
            ModSettings.SelectedCategory = modCategoryComboBox.SelectedIndex;
            ModSettings.Version = modVersionTextBox.Text;
            ModSettings.Description = modDescriptionTextBox.Text;
            ModSettings.Icon = iconImageButton.GetImage();
            ModSettings.SetScreenshot(0, ssImageButton1.GetImage());
            ModSettings.SetScreenshot(1, ssImageButton2.GetImage());
            ModSettings.SetScreenshot(2, ssImageButton3.GetImage());
            ModSettings.SetScreenshot(3, ssImageButton4.GetImage());

            DialogResult = true;
            Close();
        }

        private bool FrostyImageButton_OnValidate(object sender, FileInfo fi, BitmapImage bimage)
        {
            FrostyImageButton btn = sender as FrostyImageButton;
            if (btn == iconImageButton)
            {
                if (bimage.PixelWidth > 128 || bimage.PixelHeight > 128)
                {
                    FrostyMessageBox.Show("Icon cannot be larger than 128x128");
                    return false;
                }
            }
            else
            {
                if (fi.Length > (5 * 1024 * 1024))
                {
                    FrostyMessageBox.Show("Screenshots cannot be larger than 5mb each");
                    return false;
                }
            }

            return true;
        }

        private void modCategoryComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (modCategoryComboBox.SelectedItem.ToString() == "Custom")
            {
                modCategoryTextBox.Text = "";
                modCategoryTextBox.IsEnabled = true;
            }
            else
            {
                modCategoryTextBox.Text = modCategoryComboBox.SelectedItem.ToString();
                modCategoryTextBox.IsEnabled = false;
            }
        }

        // 2026/01/20
        // 改动标记
        private byte[] GetResourceImageBytes(string resourcePath)
        {
            var resourceUri = new Uri(resourcePath, UriKind.Relative);
            var streamInfo = Application.GetResourceStream(resourceUri);

            if (streamInfo == null)
                return null;

            using (var stream = streamInfo.Stream)
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
