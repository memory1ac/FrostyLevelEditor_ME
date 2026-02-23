using Frosty.Controls;
using FrostySdk;
using System.Windows;
using System.Windows.Controls;

namespace Frosty.Core.Windows
{
    /// <summary>
    /// FNVHashWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FNVHashWindow : FrostyDockableWindow
    {
        public int HashId { get; set; }

        public FNVHashWindow(int hashId)
        {
            InitializeComponent();

            this.HashId = hashId;

            TextBox_FnvString.Text = Utils.GetString(this.HashId);

            TextBox_FnvHashId_10.Text = this.HashId.ToString();
            TextBox_FnvHashId_16.Text = this.HashId.ToString("x8");

            TextBox_FnvString.TextChanged += TextBox_FnvString_TextChanged;
        }

        private void Button_GetFnvHash_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void TextBox_FnvString_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateFNVOutputHash(CheckBox_LowercaseMode.IsChecked == true);
        }

        private void CheckBox_LowercaseMode_Checked(object sender, RoutedEventArgs e)
        {
            UpdateFNVOutputHash(true);
        }

        private void CheckBox_LowercaseMode_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateFNVOutputHash(false);
        }

        private void UpdateFNVOutputHash(bool lowercase = false)
        {
            var hashString = TextBox_FnvString.Text;
            this.HashId = Utils.HashString(hashString, lowercase);

            TextBox_FnvHashId_10.Text = this.HashId.ToString();
            TextBox_FnvHashId_16.Text = this.HashId.ToString("x8");
        }
    }
}
