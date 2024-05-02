using LogicClassLibrary.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public static class UIStyler
    {
        public static void StyleButtonColumns(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column is DataGridViewButtonColumn buttonColumn)
                {
                    buttonColumn.FlatStyle = FlatStyle.Flat;
                    buttonColumn.DefaultCellStyle.BackColor = Color.LightGray;
                    buttonColumn.DefaultCellStyle.ForeColor = Color.Black;
                    buttonColumn.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                    buttonColumn.DefaultCellStyle.SelectionForeColor = Color.White;
                    buttonColumn.DefaultCellStyle.Padding = new Padding(5);
                    buttonColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
        public static void StyleDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowTemplate.Height = 50;
        }
        public static void AddButtonColumn(DataGridView dataGridView, string columnName, string buttonText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = columnName,
                Text = buttonText,
                UseColumnTextForButtonValue = true,
                Width = 50
            };
            dataGridView.Columns.Add(buttonColumn);
        }
        public static void StyleCursorFormButtonHands(PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6)
        {
            pic1.Cursor = Cursors.Hand;
            pic2.Cursor = Cursors.Hand;
            pic3.Cursor = Cursors.Hand;
            pic4.Cursor = Cursors.Hand;
            pic5.Cursor = Cursors.Hand;
            pic6.Cursor = Cursors.Hand;
        }

        public static void PopulateCheckListBox(CheckedListBox checkedListBox, IEnumerable<string> items)
        {
            checkedListBox.Items.Clear();
            foreach (var item in items)
            {
                checkedListBox.Items.Add(item, false);
            }
        }

        public static List<string> GetSelectedItemsFromCheckListBox(CheckedListBox checkedListBox)
        {
            var selectedItems = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                selectedItems.Add(item.ToString());
            }
            return selectedItems;
        }

        public static void SetSelectedItemsInCheckListBox(CheckedListBox checkedListBox, IEnumerable<string> selectedItems)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                string item = checkedListBox.Items[i].ToString();
                checkedListBox.SetItemChecked(i, selectedItems.Contains(item));
            }
        }

        public static void UncheckAllItemsInCheckListBox(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        public static async void LoadImageIntoPictureBox(string imageUrl, PictureBox pictureBox)
        {
            if (string.IsNullOrWhiteSpace(imageUrl) || !MovieValidation.IsValidUrl(imageUrl))
            {
                pictureBox.Image = null;
                return;
            }
            try
            {
                var request = WebRequest.Create(imageUrl);

                using (var response = await request.GetResponseAsync())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

    }
}
