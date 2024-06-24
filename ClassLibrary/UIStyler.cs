using LogicClassLibrary.Validation;
using System.Net;

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
        public static void PopulateGenresComboBox(ComboBox comboBox, IEnumerable<string> genres, string allGenresText = "All Genres")
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(allGenresText); 
            foreach (var genre in genres)
            {
                comboBox.Items.Add(genre);
            }
            comboBox.SelectedIndex = 0; 
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

        public static void PopulateComboBox(ComboBox comboBox, IEnumerable<string> items)
        {
            comboBox.Items.Clear();
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }

        public static void MakeCheckBoxesMutuallyExclusive(CheckBox checkBox1, CheckBox checkBox2)
        {
            checkBox1.CheckedChanged += (sender, e) =>
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    checkBox2.Checked = false;
                }
            };

            checkBox2.CheckedChanged += (sender, e) =>
            {
                if (checkBox2.Checked && checkBox1.Checked)
                {
                    checkBox1.Checked = false;
                }
            };
        }
        public static void PopulateListOrPlaceholder(ListBox checkedListBox, IEnumerable<string> selectedItems, string placeholder)
        {
            checkedListBox.Items.Clear();
            if (selectedItems.Any())
            {
                foreach (var item in selectedItems)
                {
                    checkedListBox.Items.Add(item);
                }
            }
            else
            {
                checkedListBox.Items.Add(placeholder);
                checkedListBox.Enabled = false; 
            }
        }

        public static void PopulateListViewOrPlaceholder(ListView checkedListBox, IEnumerable<string> selectedItems, string placeholder)
        {
            checkedListBox.Items.Clear();
            if (selectedItems.Any())
            {
                foreach (var item in selectedItems)
                {
                    checkedListBox.Items.Add(item);
                }
            }
            else
            {
                checkedListBox.Items.Add(placeholder);
                checkedListBox.Enabled = false;
            }
        }
    }
}
