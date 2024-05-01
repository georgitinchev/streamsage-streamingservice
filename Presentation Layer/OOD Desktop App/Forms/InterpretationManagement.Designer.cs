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
            interpretationMgmtDataGrid = new DataGridView();
            interpretationUpdate = new TabPage();
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
            interpretationViewTabCtrl.Location = new Point(14, 40);
            interpretationViewTabCtrl.Margin = new Padding(3, 4, 3, 4);
            interpretationViewTabCtrl.Name = "interpretationViewTabCtrl";
            interpretationViewTabCtrl.SelectedIndex = 0;
            interpretationViewTabCtrl.Size = new Size(2149, 1332);
            interpretationViewTabCtrl.TabIndex = 0;
            // 
            // InterpretationMgmtPage
            // 
            InterpretationMgmtPage.Controls.Add(interpretationMgmtDataGrid);
            InterpretationMgmtPage.Location = new Point(4, 39);
            InterpretationMgmtPage.Margin = new Padding(3, 4, 3, 4);
            InterpretationMgmtPage.Name = "InterpretationMgmtPage";
            InterpretationMgmtPage.Padding = new Padding(3, 4, 3, 4);
            InterpretationMgmtPage.Size = new Size(2141, 1289);
            InterpretationMgmtPage.TabIndex = 0;
            InterpretationMgmtPage.Text = "Interpretation Management";
            InterpretationMgmtPage.UseVisualStyleBackColor = true;
            // 
            // interpretationMgmtDataGrid
            // 
            interpretationMgmtDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            interpretationMgmtDataGrid.Location = new Point(7, 8);
            interpretationMgmtDataGrid.Margin = new Padding(3, 4, 3, 4);
            interpretationMgmtDataGrid.Name = "interpretationMgmtDataGrid";
            interpretationMgmtDataGrid.RowHeadersWidth = 51;
            interpretationMgmtDataGrid.Size = new Size(2126, 1268);
            interpretationMgmtDataGrid.TabIndex = 0;
            // 
            // interpretationUpdate
            // 
            interpretationUpdate.Location = new Point(4, 39);
            interpretationUpdate.Margin = new Padding(3, 4, 3, 4);
            interpretationUpdate.Name = "interpretationUpdate";
            interpretationUpdate.Padding = new Padding(3, 4, 3, 4);
            interpretationUpdate.Size = new Size(2141, 1289);
            interpretationUpdate.TabIndex = 1;
            interpretationUpdate.Text = "Update";
            interpretationUpdate.UseVisualStyleBackColor = true;
            // 
            // InterpretationManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(2174, 1377);
            Controls.Add(interpretationViewTabCtrl);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2192, 1424);
            MinimumSize = new Size(2192, 1424);
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
    }
}