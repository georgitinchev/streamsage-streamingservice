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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterpretationManagement));
            interpretationViewTabCtrl = new TabControl();
            InterpretationMgmtPage = new TabPage();
            interpretationsDataGrid = new DataGridView();
            interpretationUpdate = new TabPage();
            updateInterpretationBtn = new Button();
            updateInterpretationGroup = new GroupBox();
            interpretationTextLabel = new Label();
            movieIdLabel = new Label();
            userIdInterpretationLabel = new Label();
            userIdNumeric = new NumericUpDown();
            interpretationTextBox = new TextBox();
            movieIdNumeric = new NumericUpDown();
            createInterpretationTab = new TabPage();
            createInterpretationBtn = new Button();
            updateGroupBox = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            createUserIdNumeric = new NumericUpDown();
            createInterpretationText = new TextBox();
            createMovieIdNumeric = new NumericUpDown();
            previousPageBtnInterpretations = new Button();
            nextPageBtnInterpretations = new Button();
            searchBarInterpretations = new TextBox();
            searchBtnInterpretations = new Button();
            filterBarInterpretations = new ComboBox();
            addInterpretationBtn = new Button();
            interpretationDashHomeBtn = new PictureBox();
            totalInterpretationsLabel = new Label();
            interpretationMgmtErrorLabel = new Label();
            interpretationViewTabCtrl.SuspendLayout();
            InterpretationMgmtPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)interpretationsDataGrid).BeginInit();
            interpretationUpdate.SuspendLayout();
            updateInterpretationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieIdNumeric).BeginInit();
            createInterpretationTab.SuspendLayout();
            updateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)createUserIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createMovieIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)interpretationDashHomeBtn).BeginInit();
            SuspendLayout();
            // 
            // interpretationViewTabCtrl
            // 
            interpretationViewTabCtrl.Controls.Add(InterpretationMgmtPage);
            interpretationViewTabCtrl.Controls.Add(interpretationUpdate);
            interpretationViewTabCtrl.Controls.Add(createInterpretationTab);
            interpretationViewTabCtrl.Font = new Font("Rockwell", 15.75F);
            interpretationViewTabCtrl.ItemSize = new Size(0, 1);
            interpretationViewTabCtrl.Location = new Point(3, 88);
            interpretationViewTabCtrl.Name = "interpretationViewTabCtrl";
            interpretationViewTabCtrl.SelectedIndex = 0;
            interpretationViewTabCtrl.Size = new Size(1889, 898);
            interpretationViewTabCtrl.SizeMode = TabSizeMode.Fixed;
            interpretationViewTabCtrl.TabIndex = 0;
            // 
            // InterpretationMgmtPage
            // 
            InterpretationMgmtPage.Controls.Add(interpretationsDataGrid);
            InterpretationMgmtPage.Location = new Point(4, 5);
            InterpretationMgmtPage.Name = "InterpretationMgmtPage";
            InterpretationMgmtPage.Padding = new Padding(3);
            InterpretationMgmtPage.Size = new Size(1881, 889);
            InterpretationMgmtPage.TabIndex = 0;
            InterpretationMgmtPage.Text = "Interpretation Management";
            InterpretationMgmtPage.UseVisualStyleBackColor = true;
            // 
            // interpretationsDataGrid
            // 
            interpretationsDataGrid.BackgroundColor = Color.FromArgb(192, 255, 255);
            interpretationsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            interpretationsDataGrid.Location = new Point(6, 6);
            interpretationsDataGrid.Name = "interpretationsDataGrid";
            interpretationsDataGrid.RowHeadersWidth = 51;
            interpretationsDataGrid.Size = new Size(1869, 877);
            interpretationsDataGrid.TabIndex = 0;
            interpretationsDataGrid.CellContentClick += interpretationMgmtDataGrid_CellContentClick;
            // 
            // interpretationUpdate
            // 
            interpretationUpdate.Controls.Add(updateInterpretationBtn);
            interpretationUpdate.Controls.Add(updateInterpretationGroup);
            interpretationUpdate.Location = new Point(4, 5);
            interpretationUpdate.Name = "interpretationUpdate";
            interpretationUpdate.Padding = new Padding(3);
            interpretationUpdate.Size = new Size(1881, 889);
            interpretationUpdate.TabIndex = 1;
            interpretationUpdate.Text = "Update";
            interpretationUpdate.UseVisualStyleBackColor = true;
            // 
            // updateInterpretationBtn
            // 
            updateInterpretationBtn.BackColor = Color.MediumTurquoise;
            updateInterpretationBtn.Font = new Font("Rockwell", 25F, FontStyle.Bold);
            updateInterpretationBtn.Location = new Point(1611, 329);
            updateInterpretationBtn.Name = "updateInterpretationBtn";
            updateInterpretationBtn.Size = new Size(236, 160);
            updateInterpretationBtn.TabIndex = 20;
            updateInterpretationBtn.Text = "Update";
            updateInterpretationBtn.UseVisualStyleBackColor = false;
            updateInterpretationBtn.Click += updateInterpretationBtn_Click;
            // 
            // updateInterpretationGroup
            // 
            updateInterpretationGroup.BackColor = Color.FromArgb(0, 192, 192);
            updateInterpretationGroup.Controls.Add(interpretationTextLabel);
            updateInterpretationGroup.Controls.Add(movieIdLabel);
            updateInterpretationGroup.Controls.Add(userIdInterpretationLabel);
            updateInterpretationGroup.Controls.Add(userIdNumeric);
            updateInterpretationGroup.Controls.Add(interpretationTextBox);
            updateInterpretationGroup.Controls.Add(movieIdNumeric);
            updateInterpretationGroup.Location = new Point(301, 16);
            updateInterpretationGroup.Margin = new Padding(3, 2, 3, 2);
            updateInterpretationGroup.Name = "updateInterpretationGroup";
            updateInterpretationGroup.Padding = new Padding(3, 2, 3, 2);
            updateInterpretationGroup.Size = new Size(1249, 833);
            updateInterpretationGroup.TabIndex = 0;
            updateInterpretationGroup.TabStop = false;
            updateInterpretationGroup.Text = "Update Group";
            // 
            // interpretationTextLabel
            // 
            interpretationTextLabel.AutoSize = true;
            interpretationTextLabel.Font = new Font("Rockwell", 20F);
            interpretationTextLabel.Location = new Point(470, 453);
            interpretationTextLabel.Name = "interpretationTextLabel";
            interpretationTextLabel.Size = new Size(250, 31);
            interpretationTextLabel.TabIndex = 5;
            interpretationTextLabel.Text = "Interpretation Text:";
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Font = new Font("Rockwell", 20F);
            movieIdLabel.Location = new Point(540, 274);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new Size(134, 31);
            movieIdLabel.TabIndex = 4;
            movieIdLabel.Text = "Movie ID:";
            // 
            // userIdInterpretationLabel
            // 
            userIdInterpretationLabel.AutoSize = true;
            userIdInterpretationLabel.Font = new Font("Rockwell", 20F);
            userIdInterpretationLabel.Location = new Point(540, 105);
            userIdInterpretationLabel.Name = "userIdInterpretationLabel";
            userIdInterpretationLabel.Size = new Size(113, 31);
            userIdInterpretationLabel.TabIndex = 3;
            userIdInterpretationLabel.Text = "User ID:";
            // 
            // userIdNumeric
            // 
            userIdNumeric.Font = new Font("Rockwell", 20F);
            userIdNumeric.Location = new Point(474, 155);
            userIdNumeric.Margin = new Padding(3, 2, 3, 2);
            userIdNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            userIdNumeric.Name = "userIdNumeric";
            userIdNumeric.Size = new Size(276, 39);
            userIdNumeric.TabIndex = 2;
            userIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // interpretationTextBox
            // 
            interpretationTextBox.Font = new Font("Rockwell", 17F);
            interpretationTextBox.Location = new Point(47, 512);
            interpretationTextBox.Margin = new Padding(3, 2, 3, 2);
            interpretationTextBox.Multiline = true;
            interpretationTextBox.Name = "interpretationTextBox";
            interpretationTextBox.Size = new Size(1159, 289);
            interpretationTextBox.TabIndex = 1;
            // 
            // movieIdNumeric
            // 
            movieIdNumeric.Font = new Font("Rockwell", 20F);
            movieIdNumeric.Location = new Point(474, 316);
            movieIdNumeric.Margin = new Padding(3, 2, 3, 2);
            movieIdNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            movieIdNumeric.Name = "movieIdNumeric";
            movieIdNumeric.Size = new Size(276, 39);
            movieIdNumeric.TabIndex = 0;
            movieIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // createInterpretationTab
            // 
            createInterpretationTab.BackColor = Color.FromArgb(192, 255, 255);
            createInterpretationTab.Controls.Add(createInterpretationBtn);
            createInterpretationTab.Controls.Add(updateGroupBox);
            createInterpretationTab.Location = new Point(4, 5);
            createInterpretationTab.Margin = new Padding(3, 2, 3, 2);
            createInterpretationTab.Name = "createInterpretationTab";
            createInterpretationTab.Padding = new Padding(3, 2, 3, 2);
            createInterpretationTab.Size = new Size(1881, 889);
            createInterpretationTab.TabIndex = 2;
            createInterpretationTab.Text = "Create";
            // 
            // createInterpretationBtn
            // 
            createInterpretationBtn.BackColor = Color.MediumTurquoise;
            createInterpretationBtn.Font = new Font("Rockwell", 25F, FontStyle.Bold);
            createInterpretationBtn.Location = new Point(1605, 338);
            createInterpretationBtn.Name = "createInterpretationBtn";
            createInterpretationBtn.Size = new Size(236, 160);
            createInterpretationBtn.TabIndex = 21;
            createInterpretationBtn.Text = "Create";
            createInterpretationBtn.UseVisualStyleBackColor = false;
            createInterpretationBtn.Click += createInterpretationBtn_Click;
            // 
            // updateGroupBox
            // 
            updateGroupBox.BackColor = Color.FromArgb(0, 192, 192);
            updateGroupBox.Controls.Add(label1);
            updateGroupBox.Controls.Add(label2);
            updateGroupBox.Controls.Add(label3);
            updateGroupBox.Controls.Add(createUserIdNumeric);
            updateGroupBox.Controls.Add(createInterpretationText);
            updateGroupBox.Controls.Add(createMovieIdNumeric);
            updateGroupBox.Location = new Point(301, 16);
            updateGroupBox.Margin = new Padding(3, 2, 3, 2);
            updateGroupBox.Name = "updateGroupBox";
            updateGroupBox.Padding = new Padding(3, 2, 3, 2);
            updateGroupBox.Size = new Size(1249, 836);
            updateGroupBox.TabIndex = 2;
            updateGroupBox.TabStop = false;
            updateGroupBox.Text = "Update Group";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20F);
            label1.Location = new Point(470, 453);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 5;
            label1.Text = "Interpretation Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 20F);
            label2.Location = new Point(540, 274);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 4;
            label2.Text = "Movie ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 20F);
            label3.Location = new Point(540, 105);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 3;
            label3.Text = "User ID:";
            // 
            // createUserIdNumeric
            // 
            createUserIdNumeric.Font = new Font("Rockwell", 20F);
            createUserIdNumeric.Location = new Point(474, 155);
            createUserIdNumeric.Margin = new Padding(3, 2, 3, 2);
            createUserIdNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            createUserIdNumeric.Name = "createUserIdNumeric";
            createUserIdNumeric.Size = new Size(276, 39);
            createUserIdNumeric.TabIndex = 2;
            createUserIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // createInterpretationText
            // 
            createInterpretationText.Font = new Font("Rockwell", 17F);
            createInterpretationText.Location = new Point(47, 512);
            createInterpretationText.Margin = new Padding(3, 2, 3, 2);
            createInterpretationText.Multiline = true;
            createInterpretationText.Name = "createInterpretationText";
            createInterpretationText.Size = new Size(1159, 289);
            createInterpretationText.TabIndex = 1;
            // 
            // createMovieIdNumeric
            // 
            createMovieIdNumeric.Font = new Font("Rockwell", 20F);
            createMovieIdNumeric.Location = new Point(474, 316);
            createMovieIdNumeric.Margin = new Padding(3, 2, 3, 2);
            createMovieIdNumeric.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            createMovieIdNumeric.Name = "createMovieIdNumeric";
            createMovieIdNumeric.Size = new Size(276, 39);
            createMovieIdNumeric.TabIndex = 0;
            createMovieIdNumeric.TextAlign = HorizontalAlignment.Center;
            // 
            // previousPageBtnInterpretations
            // 
            previousPageBtnInterpretations.BackColor = Color.MediumTurquoise;
            previousPageBtnInterpretations.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            previousPageBtnInterpretations.Location = new Point(6, 992);
            previousPageBtnInterpretations.Name = "previousPageBtnInterpretations";
            previousPageBtnInterpretations.Size = new Size(197, 36);
            previousPageBtnInterpretations.TabIndex = 13;
            previousPageBtnInterpretations.Text = "Previous Page";
            previousPageBtnInterpretations.UseVisualStyleBackColor = false;
            previousPageBtnInterpretations.Click += previousPageBtnInterpretations_Click;
            // 
            // nextPageBtnInterpretations
            // 
            nextPageBtnInterpretations.BackColor = Color.MediumTurquoise;
            nextPageBtnInterpretations.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            nextPageBtnInterpretations.Location = new Point(1695, 992);
            nextPageBtnInterpretations.Name = "nextPageBtnInterpretations";
            nextPageBtnInterpretations.Size = new Size(197, 36);
            nextPageBtnInterpretations.TabIndex = 14;
            nextPageBtnInterpretations.Text = "Next Page";
            nextPageBtnInterpretations.UseVisualStyleBackColor = false;
            nextPageBtnInterpretations.Click += nextPageBtnInterpretations_Click;
            // 
            // searchBarInterpretations
            // 
            searchBarInterpretations.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchBarInterpretations.Location = new Point(307, 13);
            searchBarInterpretations.Name = "searchBarInterpretations";
            searchBarInterpretations.Size = new Size(773, 30);
            searchBarInterpretations.TabIndex = 15;
            // 
            // searchBtnInterpretations
            // 
            searchBtnInterpretations.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtnInterpretations.Location = new Point(1111, 12);
            searchBtnInterpretations.Name = "searchBtnInterpretations";
            searchBtnInterpretations.Size = new Size(198, 31);
            searchBtnInterpretations.TabIndex = 16;
            searchBtnInterpretations.Text = "Search 🔍";
            searchBtnInterpretations.UseVisualStyleBackColor = true;
            searchBtnInterpretations.Click += searchBtnInterpretations_Click;
            // 
            // filterBarInterpretations
            // 
            filterBarInterpretations.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterBarInterpretations.FormattingEnabled = true;
            filterBarInterpretations.Location = new Point(1328, 12);
            filterBarInterpretations.Name = "filterBarInterpretations";
            filterBarInterpretations.Size = new Size(319, 31);
            filterBarInterpretations.TabIndex = 17;
            filterBarInterpretations.SelectedIndexChanged += filterBarInterpretations_SelectedIndexChanged;
            // 
            // addInterpretationBtn
            // 
            addInterpretationBtn.BackColor = Color.MediumTurquoise;
            addInterpretationBtn.Font = new Font("Rockwell", 15F, FontStyle.Bold);
            addInterpretationBtn.Location = new Point(1665, 13);
            addInterpretationBtn.Name = "addInterpretationBtn";
            addInterpretationBtn.Size = new Size(228, 30);
            addInterpretationBtn.TabIndex = 18;
            addInterpretationBtn.Text = "Add Interpretation";
            addInterpretationBtn.UseVisualStyleBackColor = false;
            addInterpretationBtn.Click += addInterpretationBtn_Click;
            // 
            // interpretationDashHomeBtn
            // 
            interpretationDashHomeBtn.Image = (Image)resources.GetObject("interpretationDashHomeBtn.Image");
            interpretationDashHomeBtn.Location = new Point(13, 13);
            interpretationDashHomeBtn.Margin = new Padding(3, 2, 3, 2);
            interpretationDashHomeBtn.Name = "interpretationDashHomeBtn";
            interpretationDashHomeBtn.Size = new Size(52, 48);
            interpretationDashHomeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            interpretationDashHomeBtn.TabIndex = 19;
            interpretationDashHomeBtn.TabStop = false;
            interpretationDashHomeBtn.Click += interpretationDashHomeBtn_Click;
            // 
            // totalInterpretationsLabel
            // 
            totalInterpretationsLabel.Font = new Font("Rockwell", 13F, FontStyle.Bold);
            totalInterpretationsLabel.Location = new Point(71, 13);
            totalInterpretationsLabel.Name = "totalInterpretationsLabel";
            totalInterpretationsLabel.Size = new Size(230, 48);
            totalInterpretationsLabel.TabIndex = 20;
            totalInterpretationsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // interpretationMgmtErrorLabel
            // 
            interpretationMgmtErrorLabel.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            interpretationMgmtErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            interpretationMgmtErrorLabel.Location = new Point(307, 51);
            interpretationMgmtErrorLabel.Name = "interpretationMgmtErrorLabel";
            interpretationMgmtErrorLabel.Size = new Size(1340, 34);
            interpretationMgmtErrorLabel.TabIndex = 21;
            interpretationMgmtErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InterpretationManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1904, 1033);
            Controls.Add(interpretationMgmtErrorLabel);
            Controls.Add(totalInterpretationsLabel);
            Controls.Add(interpretationDashHomeBtn);
            Controls.Add(addInterpretationBtn);
            Controls.Add(filterBarInterpretations);
            Controls.Add(searchBtnInterpretations);
            Controls.Add(searchBarInterpretations);
            Controls.Add(nextPageBtnInterpretations);
            Controls.Add(previousPageBtnInterpretations);
            Controls.Add(interpretationViewTabCtrl);
            MaximumSize = new Size(1920, 1078);
            MinimumSize = new Size(1920, 1052);
            Name = "InterpretationManagement";
            Text = "Interpretation Management";
            interpretationViewTabCtrl.ResumeLayout(false);
            InterpretationMgmtPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)interpretationsDataGrid).EndInit();
            interpretationUpdate.ResumeLayout(false);
            updateInterpretationGroup.ResumeLayout(false);
            updateInterpretationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieIdNumeric).EndInit();
            createInterpretationTab.ResumeLayout(false);
            updateGroupBox.ResumeLayout(false);
            updateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)createUserIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)createMovieIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)interpretationDashHomeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl interpretationViewTabCtrl;
        private TabPage InterpretationMgmtPage;
        private TabPage interpretationUpdate;
        private TabPage createInterpretationTab;
        private Button previousPageBtnInterpretations;
        private Button nextPageBtnInterpretations;
        private TextBox searchBarInterpretations;
        private Button searchBtnInterpretations;
        private ComboBox filterBarInterpretations;
        private Button addInterpretationBtn;
        private PictureBox interpretationDashHomeBtn;
        private GroupBox updateInterpretationGroup;
        private TextBox interpretationTextBox;
        private NumericUpDown movieIdNumeric;
        private Label userIdInterpretationLabel;
        private NumericUpDown userIdNumeric;
        private Label interpretationTextLabel;
        private Label movieIdLabel;
        private Button updateInterpretationBtn;
        private GroupBox updateGroupBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown createUserIdNumeric;
        private TextBox createInterpretationText;
        private NumericUpDown createMovieIdNumeric;
        private Button createInterpretationBtn;
        private Label totalInterpretationsLabel;
        private Label interpretationMgmtErrorLabel;
        private DataGridView interpretationsDataGrid;
    }
}