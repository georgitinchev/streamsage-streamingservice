namespace DesktopApp.Forms
{
	partial class ReviewManagement
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reviewTabCtrl = new TabControl();
            reviewMgmtP1 = new TabPage();
            dataGridView1 = new DataGridView();
            reviewUpdateP2 = new TabPage();
            reviewTabCtrl.SuspendLayout();
            reviewMgmtP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reviewTabCtrl
            // 
            reviewTabCtrl.Controls.Add(reviewMgmtP1);
            reviewTabCtrl.Controls.Add(reviewUpdateP2);
            reviewTabCtrl.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reviewTabCtrl.Location = new Point(3, 41);
            reviewTabCtrl.Margin = new Padding(3, 4, 3, 4);
            reviewTabCtrl.Name = "reviewTabCtrl";
            reviewTabCtrl.SelectedIndex = 0;
            reviewTabCtrl.Size = new Size(2159, 1331);
            reviewTabCtrl.TabIndex = 0;
            // 
            // reviewMgmtP1
            // 
            reviewMgmtP1.BackColor = Color.FromArgb(192, 255, 255);
            reviewMgmtP1.Controls.Add(dataGridView1);
            reviewMgmtP1.Location = new Point(4, 39);
            reviewMgmtP1.Margin = new Padding(3, 4, 3, 4);
            reviewMgmtP1.Name = "reviewMgmtP1";
            reviewMgmtP1.Padding = new Padding(3, 4, 3, 4);
            reviewMgmtP1.Size = new Size(2151, 1288);
            reviewMgmtP1.TabIndex = 0;
            reviewMgmtP1.Text = "Review Management";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 8);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(2136, 1267);
            dataGridView1.TabIndex = 0;
            // 
            // reviewUpdateP2
            // 
            reviewUpdateP2.BackColor = Color.FromArgb(192, 255, 255);
            reviewUpdateP2.Location = new Point(4, 39);
            reviewUpdateP2.Margin = new Padding(3, 4, 3, 4);
            reviewUpdateP2.Name = "reviewUpdateP2";
            reviewUpdateP2.Padding = new Padding(3, 4, 3, 4);
            reviewUpdateP2.Size = new Size(2151, 1288);
            reviewUpdateP2.TabIndex = 1;
            reviewUpdateP2.Text = "Update";
            // 
            // ReviewManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1377);
            Controls.Add(reviewTabCtrl);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2192, 1424);
            MinimumSize = new Size(2192, 1424);
            Name = "ReviewManagement";
            Text = "ReviewManagement";
            reviewTabCtrl.ResumeLayout(false);
            reviewMgmtP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl reviewTabCtrl;
        private TabPage reviewMgmtP1;
        private TabPage reviewUpdateP2;
        private DataGridView dataGridView1;
    }
}