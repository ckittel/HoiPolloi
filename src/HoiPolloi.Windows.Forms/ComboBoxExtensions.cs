using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HoiPolloi.Windows.Forms
{
    public static class ComboBoxExtensions
    {
        public static void AutosizeDropDownWidth(this ComboBox comboBox)
        {
            AutosizeDropDownWidth(comboBox, -1);
        }

        public static void AutosizeDropDownWidth(this ComboBox comboBox, int maxWidth)
        {
            Guard.EnsureIsNotNull(comboBox, "comboBox");

            if (comboBox.Items.Count <= 0) return;

            int longestItem;

            var itemsAsText = GetItemTexts(comboBox);

            using (var g = Graphics.FromHwnd(comboBox.Handle))
            {
                longestItem = (int)itemsAsText.Max(t => g.MeasureString(t, comboBox.Font).Width);
            }

            // Account for scrollbar
            // TODO: It seems that on Vista and Windows7, the MaxDropDownItems is ingored,
            //       meaning we are unnecessaryly adding padding in these cases.  Fix me.
            if (comboBox.Items.Count > comboBox.MaxDropDownItems)
                longestItem += SystemInformation.VerticalScrollBarWidth;

            // Always add two pixels of padding, just to keep things looking clean
            longestItem += 2;

            if (maxWidth > 0)
                longestItem = Math.Min(longestItem, maxWidth);

            comboBox.DropDownWidth = Math.Max(longestItem, comboBox.Width);
        }

        private static IEnumerable<string> GetItemTexts(ComboBox comboBox)
        {
            return (from object item in comboBox.Items
                    select comboBox.GetItemText(item));
        }
    }
}
