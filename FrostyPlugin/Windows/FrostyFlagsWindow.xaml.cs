using Frosty.Controls;
using System.Windows;

namespace Frosty.Core.Windows
{
    /// <summary>
    /// FrostyFlagsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FrostyFlagsWindow : FrostyDockableWindow
    {
        private const uint GUID_MASK = 0xFFFFFFu;                   // 低24位掩码
        private const uint UNKNOWN_FLAG_MASK = 0x1000000u;          // 位24
        private const uint CLIENT_EVENT_MASK = 0x2000000u;          // 位25
        private const uint SERVER_EVENT_MASK = 0x4000000u;          // 位26
        private const uint CLIENT_PROPERTY_MASK = 0x8000000u;       // 位27
        private const uint SERVER_PROPERTY_MASK = 0x10000000u;      // 位28
        private const uint CLIENT_LINK_SOURCE_MASK = 0x20000000u;   // 位29
        private const uint SERVER_LINK_SOURCE_MASK = 0x40000000u;   // 位30
        private const uint UNUSED_FLAG_MASK = 0x80000000u;          // 位31

        public bool IsPropFlag { get; set; }
        public uint Flags { get; set; }

        public FrostyFlagsWindow(uint flags, bool isPropFlag)
        {
            InitializeComponent();

            this.Flags = flags;
            this.IsPropFlag = isPropFlag;

            TextBox_FrostyFlags.Text = this.Flags.ToString();

            if (isPropFlag)
            {
                StackPanel_FrostyFlags.Visibility = Visibility.Hidden;
                UniformGrid_RealmPropertyFlags.Visibility = Visibility.Visible;

                TextBlock_GuidMask.Text = string.Empty;

                GetRealmPropertyFlags();
            }
            else
            {
                StackPanel_FrostyFlags.Visibility = Visibility.Visible;
                UniformGrid_RealmPropertyFlags.Visibility = Visibility.Hidden;

                TextBlock_GuidMask.Text = $"{this.Flags & 0xFFFFFFu}";

                GetForstyFlags();
            }
        }

        private void Button_SetFrostyFlags_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void CheckBox_SetFrostyFlags_Click(object sender, RoutedEventArgs e)
        {
            SetForstyFlags();
        }

        private void GetForstyFlags()
        {
            CheckBox_SetFrostyFlags_0.IsChecked = (this.Flags & UNKNOWN_FLAG_MASK) != 0;
            CheckBox_SetFrostyFlags_1.IsChecked = (this.Flags & CLIENT_EVENT_MASK) != 0;
            CheckBox_SetFrostyFlags_2.IsChecked = (this.Flags & SERVER_EVENT_MASK) != 0;
            CheckBox_SetFrostyFlags_3.IsChecked = (this.Flags & CLIENT_PROPERTY_MASK) != 0;
            CheckBox_SetFrostyFlags_4.IsChecked = (this.Flags & SERVER_PROPERTY_MASK) != 0;
            CheckBox_SetFrostyFlags_5.IsChecked = (this.Flags & CLIENT_LINK_SOURCE_MASK) != 0;
            CheckBox_SetFrostyFlags_6.IsChecked = (this.Flags & SERVER_LINK_SOURCE_MASK) != 0;
            CheckBox_SetFrostyFlags_7.IsChecked = (this.Flags & UNUSED_FLAG_MASK) != 0;
        }

        private void SetForstyFlags()
        {
            this.Flags &= GUID_MASK;

            if (CheckBox_SetFrostyFlags_0.IsChecked == true)
                this.Flags |= UNKNOWN_FLAG_MASK;
            if (CheckBox_SetFrostyFlags_1.IsChecked == true)
                this.Flags |= CLIENT_EVENT_MASK;
            if (CheckBox_SetFrostyFlags_2.IsChecked == true)
                this.Flags |= SERVER_EVENT_MASK;
            if (CheckBox_SetFrostyFlags_3.IsChecked == true)
                this.Flags |= CLIENT_PROPERTY_MASK;
            if (CheckBox_SetFrostyFlags_4.IsChecked == true)
                this.Flags |= SERVER_PROPERTY_MASK;
            if (CheckBox_SetFrostyFlags_5.IsChecked == true)
                this.Flags |= CLIENT_LINK_SOURCE_MASK;
            if (CheckBox_SetFrostyFlags_6.IsChecked == true)
                this.Flags |= SERVER_LINK_SOURCE_MASK;
            if (CheckBox_SetFrostyFlags_7.IsChecked == true)
                this.Flags |= UNUSED_FLAG_MASK;

            TextBox_FrostyFlags.Text = this.Flags.ToString();
        }

        private void RadioButton_SetRealmPropertyFlags_Click(object sender, RoutedEventArgs e)
        {
            SetRealmPropertyFlags();
        }

        private void GetRealmPropertyFlags()
        {
            var realm = this.Flags & 7;
            var propType = (this.Flags & 48) >> 4;
            var sourceCantBeStatic = (this.Flags & 8) != 0;

            switch (realm)
            {
                case 0:
                    RadioButton_SetRealmFlags_0.IsChecked = true;
                    break;
                case 1:
                    RadioButton_SetRealmFlags_1.IsChecked = true;
                    break;
                case 2:
                    RadioButton_SetRealmFlags_2.IsChecked = true;
                    break;
                case 3:
                    RadioButton_SetRealmFlags_3.IsChecked = true;
                    break;
                case 4:
                    RadioButton_SetRealmFlags_4.IsChecked = true;
                    break;
                case 5:
                    RadioButton_SetRealmFlags_5.IsChecked = true;
                    break;
            }

            switch (propType)
            {
                case 0:
                    RadioButton_SetPropertyFlags_0.IsChecked = true;
                    break;
                case 1:
                    RadioButton_SetPropertyFlags_1.IsChecked = true;
                    break;
                case 2:
                    RadioButton_SetPropertyFlags_2.IsChecked = true;
                    break;
                case 3:
                    RadioButton_SetPropertyFlags_3.IsChecked = true;
                    break;
            }

            CheckBox_SetSourceCantBeStatic.IsChecked = sourceCantBeStatic;
        }

        private void SetRealmPropertyFlags()
        {
            uint realm = 0;
            uint propType = 0;

            if (RadioButton_SetRealmFlags_0.IsChecked == true) realm = 0;
            if (RadioButton_SetRealmFlags_1.IsChecked == true) realm = 1;
            if (RadioButton_SetRealmFlags_2.IsChecked == true) realm = 2;
            if (RadioButton_SetRealmFlags_3.IsChecked == true) realm = 3;
            if (RadioButton_SetRealmFlags_4.IsChecked == true) realm = 4;
            if (RadioButton_SetRealmFlags_5.IsChecked == true) realm = 5;

            if (RadioButton_SetPropertyFlags_0.IsChecked == true) propType = 0;
            if (RadioButton_SetPropertyFlags_1.IsChecked == true) propType = 1;
            if (RadioButton_SetPropertyFlags_2.IsChecked == true) propType = 2;
            if (RadioButton_SetPropertyFlags_3.IsChecked == true) propType = 3;

            this.Flags = 0;

            this.Flags |= realm;
            this.Flags |= (propType) << 4;

            if (CheckBox_SetSourceCantBeStatic.IsChecked == true)
                this.Flags |= 8;

            TextBox_FrostyFlags.Text = this.Flags.ToString();
        }
    }
}
