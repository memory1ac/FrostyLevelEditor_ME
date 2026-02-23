using System;
using System.Runtime.InteropServices;

namespace Frosty.Core
{
    public static class FixClipboard
    {
        [DllImport("user32.dll")]
        private static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("user32.dll")]
        private static extern bool CloseClipboard();

        [DllImport("user32.dll")]
        private static extern bool EmptyClipboard();

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

        /// <summary>
        /// Unicode 文本格式。 每行以回车符/换行符 (CR-LF) 组合结束。 null 字符表示数据结束
        /// </summary>
        private const uint CF_UNICODETEXT = 13;

        /// <summary>
        /// 向剪贴板中添加文本
        /// </summary>
        public static void SetText(string text)
        {
            if (!OpenClipboard(IntPtr.Zero))
            {
                App.Logger.LogError("打开剪切板失败");
                return;
            }

            EmptyClipboard();
            SetClipboardData(CF_UNICODETEXT, Marshal.StringToHGlobalUni(text));
            CloseClipboard();

            App.Logger.Log($"复制到剪切板成功 {text}");
        }
    }
}
