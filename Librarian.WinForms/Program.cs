using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarian.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public static void MoveListViewItems(ListView sender, MoveDirection direction)
        {
            int dir = (int)direction;
            int opp = dir * -1;

            bool valid = sender.SelectedItems.Count > 0 &&
                            ((direction == MoveDirection.Down && (sender.SelectedItems[sender.SelectedItems.Count - 1].Index < sender.Items.Count - 1))
                        || (direction == MoveDirection.Up && (sender.SelectedItems[0].Index > 0)));

            if (valid)
            {
                foreach (ListViewItem item in sender.SelectedItems)
                {
                    int index = item.Index + dir;
                    sender.Items.RemoveAt(item.Index);
                    sender.Items.Insert(index, item);
                }
            }
        }
        public static void MoveListBoxItems(ListBox sender, MoveDirection direction)
        {
            // Checking selected item
            if (sender.SelectedItem == null || sender.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = sender.SelectedIndex + ((int)direction);

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= sender.Items.Count)
                return; // Index out of range - nothing to do

            object selected = sender.SelectedItem;

            // Save checked state if it is applicable
            var checkedListBox = sender as CheckedListBox;
            var checkState = CheckState.Unchecked;
            if (checkedListBox != null)
                checkState = checkedListBox.GetItemCheckState(checkedListBox.SelectedIndex);

            // Removing removable element
            sender.Items.Remove(selected);
            // Insert it in new position
            sender.Items.Insert(newIndex, selected);
            // Restore selection
            sender.SetSelected(newIndex, true);

            // Restore checked state if it is applicable
            if (checkedListBox != null)
                checkedListBox.SetItemCheckState(newIndex, checkState);
        }
    }
    enum MoveDirection { Up = -1, Down = 1 };
}
