namespace DesktopApp.Forms
{
	partial class MovieDashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDashboard));
			homeBtnMovies = new PictureBox();
			searchBarMovies = new TextBox();
			filterBarMovies = new ComboBox();
			moviesDataGrid = new DataGridView();
			totalMovies = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)homeBtnMovies).BeginInit();
			((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
			SuspendLayout();
			// 
			// homeBtnMovies
			// 
			homeBtnMovies.BackColor = Color.RoyalBlue;
			homeBtnMovies.Image = (Image)resources.GetObject("homeBtnMovies.Image");
			homeBtnMovies.Location = new Point(3, 2);
			homeBtnMovies.Name = "homeBtnMovies";
			homeBtnMovies.Size = new Size(86, 71);
			homeBtnMovies.SizeMode = PictureBoxSizeMode.StretchImage;
			homeBtnMovies.TabIndex = 1;
			homeBtnMovies.TabStop = false;
			// 
			// searchBarMovies
			// 
			searchBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			searchBarMovies.Location = new Point(147, 25);
			searchBarMovies.Name = "searchBarMovies";
			searchBarMovies.Size = new Size(573, 30);
			searchBarMovies.TabIndex = 2;
			// 
			// filterBarMovies
			// 
			filterBarMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			filterBarMovies.FormattingEnabled = true;
			filterBarMovies.Location = new Point(903, 24);
			filterBarMovies.Name = "filterBarMovies";
			filterBarMovies.Size = new Size(256, 31);
			filterBarMovies.TabIndex = 3;
			// 
			// moviesDataGrid
			// 
			moviesDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
			moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			moviesDataGrid.Location = new Point(28, 105);
			moviesDataGrid.Name = "moviesDataGrid";
			moviesDataGrid.Size = new Size(1131, 503);
			moviesDataGrid.TabIndex = 4;
			moviesDataGrid.CellContentClick += moviesDataGrid_CellContentClick;
			// 
			// totalMovies
			// 
			totalMovies.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			totalMovies.Location = new Point(105, 68);
			totalMovies.Name = "totalMovies";
			totalMovies.Size = new Size(123, 34);
			totalMovies.TabIndex = 5;
			// 
			// button1
			// 
			button1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.Location = new Point(738, 24);
			button1.Name = "button1";
			button1.Size = new Size(140, 31);
			button1.TabIndex = 6;
			button1.Text = "Search 🔍";
			button1.UseVisualStyleBackColor = true;
			// 
			// MovieDashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 255);
			ClientSize = new Size(1182, 630);
			Controls.Add(button1);
			Controls.Add(totalMovies);
			Controls.Add(moviesDataGrid);
			Controls.Add(filterBarMovies);
			Controls.Add(searchBarMovies);
			Controls.Add(homeBtnMovies);
			Name = "MovieDashboard";
			Text = "MovieDashboard";
			((System.ComponentModel.ISupportInitialize)homeBtnMovies).EndInit();
			((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox homeBtnMovies;
		private TextBox searchBarMovies;
		private ComboBox filterBarMovies;
		private DataGridView moviesDataGrid;
		private Label totalMovies;
		private Button button1;
	}
}