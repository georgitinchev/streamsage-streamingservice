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
            reviewUpdateP2 = new TabPage();
            dataGridView1 = new DataGridView();
            backToDashBtn = new Button();
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
            reviewTabCtrl.Location = new Point(3, 31);
            reviewTabCtrl.Name = "reviewTabCtrl";
            reviewTabCtrl.SelectedIndex = 0;
            reviewTabCtrl.Size = new Size(1889, 998);
            reviewTabCtrl.TabIndex = 0;
            // 
            // reviewMgmtP1
            // 
            reviewMgmtP1.BackColor = Color.FromArgb(192, 255, 255);
            reviewMgmtP1.Controls.Add(dataGridView1);
            reviewMgmtP1.Location = new Point(4, 32);
            reviewMgmtP1.Name = "reviewMgmtP1";
            reviewMgmtP1.Padding = new Padding(3);
            reviewMgmtP1.Size = new Size(1881, 962);
            reviewMgmtP1.TabIndex = 0;
            reviewMgmtP1.Text = "Review Management";
            // 
            // reviewUpdateP2
            // 
            reviewUpdateP2.BackColor = Color.FromArgb(192, 255, 255);
            reviewUpdateP2.Location = new Point(4, 32);
            reviewUpdateP2.Name = "reviewUpdateP2";
            reviewUpdateP2.Padding = new Padding(3);
            reviewUpdateP2.Size = new Size(1881, 962);
            reviewUpdateP2.TabIndex = 1;
            reviewUpdateP2.Text = "Update";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 255, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1869, 950);
            dataGridView1.TabIndex = 0;
            // 
            // backToDashBtn
            // 
            backToDashBtn.BackColor = Color.CornflowerBlue;
            backToDashBtn.Font = new Font("Rockwell", 13F, FontStyle.Bold);
            backToDashBtn.Location = new Point(1679, 11);
            backToDashBtn.Margin = new Padding(2);
            backToDashBtn.Name = "backToDashBtn";
            backToDashBtn.Size = new Size(214, 40);
            backToDashBtn.TabIndex = 7;
            backToDashBtn.Text = "Back to Admin Dash";
            backToDashBtn.UseVisualStyleBackColor = false;
            // 
            // ReviewManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(backToDashBtn);
            Controls.Add(reviewTabCtrl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
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
        private Button backToDashBtn;
    }
}