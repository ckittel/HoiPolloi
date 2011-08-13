using System.Windows.Forms;

namespace HoiPolloi.Windows.Forms
{
    public static class TextBoxExtensions
    {
        public static void SelectAllText(this TextBox textBox)
        {
            Guard.EnsureIsNotNull(textBox, "textBox");

            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }
    }
}
