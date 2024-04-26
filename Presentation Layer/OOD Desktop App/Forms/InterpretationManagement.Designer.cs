namespace DesktopApp.Forms
{
	partial class InterpretationManagement
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
            interpretationViewTabCtrl = new TabControl();
            InterpretationMgmtPage = new TabPage();
            interpretationUpdate = new TabPage();
            interpretationMgmtDataGrid = new DataGridView();
            backToDashBtn = new Button();
            interpretationViewTabCtrl.SuspendLayout();
            InterpretationMgmtPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)interpretationMgmtDataGrid).BeginInit();
            SuspendLayout();
            // 
            // interpretationViewTabCtrl
            // 
            interpretationViewTabCtrl.Controls.Add(InterpretationMgmtPage);
            interpretationViewTabCtrl.Controls.Add(interpretationUpdate);
            interpretationViewTabCtrl.Font = new Font("Rockwell", 15.75F);
            interpretationViewTabCtrl.Location = new Point(12, 30);
            interpretationViewTabCtrl.Name = "interpretationViewTabCtrl";
            interpretationViewTabCtrl.SelectedIndex = 0;
            interpretationViewTabCtrl.Size = new Size(1880, 999);
            interpretationViewTabCtrl.TabIndex = 0;
            // 
            // InterpretationMgmtPage
            // 
            InterpretationMgmtPage.Controls.Add(interpretationMgmtDataGrid);
            InterpretationMgmtPage.Location = new Point(4, 32);
            InterpretationMgmtPage.Name = "InterpretationMgmtPage";
            InterpretationMgmtPage.Padding = new Padding(3);
            InterpretationMgmtPage.Size = new Size(1872, 963);
            InterpretationMgmtPage.TabIndex = 0;
            InterpretationMgmtPage.Text = "Interpretation Management";
            InterpretationMgmtPage.UseVisualStyleBackColor = true;
            // 
            // interpretationUpdate
            // 
            interpretationUpdate.Location = new Point(4, 32);
            interpretationUpdate.Name = "interpretationUpdate";
            interpretationUpdate.Padding = new Padding(3);
            interpretationUpdate.Size = new Size(1872, 881);
            interpretationUpdate.TabIndex = 1;
            interpretationUpdate.Text = "Update";
            interpretationUpdate.UseVisualStyleBackColor = true;
            // 
            // interpretationMgmtDataGrid
            // 
            interpretationMgmtDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            interpretationMgmtDataGrid.Location = new Point(6, 6);
            interpretationMgmtDataGrid.Name = "interpretationMgmtDataGrid";
            interpretationMgmtDataGrid.Size = new Size(1860, 951);
            interpretationMgmtDataGrid.TabIndex = 0;
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
            // InterpretationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1041);
            Controls.Add(backToDashBtn);
            Controls.Add(interpretationViewTabCtrl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1920, 1080);
            Name = "InterpretationManagement";
            Text = "InterpretationManagement";
            interpretationViewTabCtrl.ResumeLayout(false);
            InterpretationMgmtPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)interpretationMgmtDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl interpretationViewTabCtrl;
        private TabPage InterpretationMgmtPage;
        private DataGridView interpretationMgmtDataGrid;
        private TabPage interpretationUpdate;
        private Button backToDashBtn;
    }
}