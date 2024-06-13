using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Validation;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class InterpretationManagement : Form
    {
        private readonly IDesktopController desktopController;
        private int currentInterpretationId;
        private int currentPage = 1;

        public InterpretationManagement(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            InitializeInterpretationsGrid();
            LoadInterpretationsPage();
            Console.WriteLine("InterpretationManagement constructor called");
            //reviewsDashHomeBtn.Click += reviewsDashHomeBtn_Click;
            //reviewsDataGrid.CellContentClick += reviewsDataGrid_CellContentClick;
        }

        private void InitializeInterpretationsGrid()
        {
            interpretationsDataGrid.AutoGenerateColumns = false;
            interpretationsDataGrid.Columns.Clear();
            interpretationsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UserId", HeaderText = "User ID", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            interpretationsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MovieId", HeaderText = "Movie ID", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            interpretationsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "InterpretationText", HeaderText = "Content", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            interpretationsDataGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "InterpretationDate", HeaderText = "Date", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            UIStyler.StyleDataGridView(interpretationsDataGrid);
            UIStyler.AddButtonColumn(interpretationsDataGrid, "Edit", "Edit");
            UIStyler.AddButtonColumn(interpretationsDataGrid, "Delete", "Delete");
            previousPageBtnInterpretations.Click += (sender, e) => { currentPage--; LoadInterpretationsPage(); };
            nextPageBtnInterpretations.Click += (sender, e) => { currentPage++; LoadInterpretationsPage(); };
        }


        private void LoadInterpretationsPage()
        {
            try
            {
                var interpretations = desktopController.InterpretationService.GetInterpretationsPage(currentPage, desktopController.GetPageSize());
                if (interpretations.Count == 0 && currentPage > 1)
                {
                    currentPage--;
                    LoadInterpretationsPage();
                    return;
                }
                interpretationsDataGrid.DataSource = interpretations;
                totalInterpretationsLabel.Text = $"Total Interpretations:\n{desktopController.InterpretationService.GetTotalInterpretationsCount()}";
                interpretationsDataGrid.Refresh();
            }
            catch (GetInterpretationsPageError ex)
            {
                interpretationMgmtErrorLabel.Text = ex.Message;
            }
        }


        private async Task DeleteInterpretationAsync(int interpretationId)
        {
            try
            {
                desktopController.InterpretationService.DeleteInterpretation(interpretationId);
                LoadInterpretationsPage();
                interpretationMgmtErrorLabel.Text = "Interpretation deleted successfully!";
            }
            catch (DeleteInterpretationError ex)
            {
                interpretationMgmtErrorLabel.Text = ex.Message;
            }
            finally
            {
                await Task.Delay(3000);
                interpretationMgmtErrorLabel.Text = "";
            }
        }


        private void interpretationDashHomeBtn_Click(object sender, EventArgs e)
        {
            interpretationViewTabCtrl.SelectedIndex = 0;
        }

        private void addInterpretationBtn_Click(object sender, EventArgs e)
        {
            interpretationViewTabCtrl.SelectedIndex = 2;
        }

        private void searchBtnInterpretations_Click(object sender, EventArgs e)
        {
            // Implement search functionality if needed
        }

        private void filterBarInterpretations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implement filter functionality if needed
        }

        private async void createInterpretationBtn_Click(object sender, EventArgs e)
        {
            int userId = (int)createUserIdNumeric.Value;
            int movieId = (int)createMovieIdNumeric.Value;

            // Validate the user ID
            UserDTO user = desktopController.UserService.Read(userId);
            if (user == null)
            {
                await DisplayErrorAsync(interpretationMgmtErrorLabel, "Invalid user ID.");
                return;
            }

            // Validate the movie ID
            if (!desktopController.MovieService.MovieExists(movieId))
            {
                await DisplayErrorAsync(interpretationMgmtErrorLabel, $"Movie with ID: {movieId} was not found.");
                return;
            }
            var interpretation = new InterpretationDTO(0, userId, movieId, createInterpretationText.Text, DateTime.Now);
            try
            {
                InterpretationValidation.IsValidInterpretation(interpretation);
                desktopController.InterpretationService.AddInterpretation(interpretation);
                await DisplayErrorAsync(interpretationMgmtErrorLabel, "Interpretation created successfully!");
                LoadInterpretationsPage();
            }
            catch (CreateInterpretationError ex)
            {
                interpretationMgmtErrorLabel.Text = ex.Message;
            }
        }

        private async void updateInterpretationBtn_Click(object sender, EventArgs e)
        {
            var interpretation = new InterpretationDTO(currentInterpretationId, (int)userIdNumeric.Value, (int)movieIdNumeric.Value, interpretationTextBox.Text, DateTime.Now);

            if (!InterpretationValidation.IsValidInterpretation(interpretation))
            {
                await DisplayErrorAsync(interpretationMgmtErrorLabel, "Invalid interpretation data.");
                return;
            }
            try
            {
                desktopController.InterpretationService.UpdateInterpretation(interpretation);
                await DisplayErrorAsync(interpretationMgmtErrorLabel, "Interpretation updated successfully!");
                LoadInterpretationsPage();
            }
            catch (UpdateInterpretationError ex)
            {
                interpretationMgmtErrorLabel.Text = ex.Message;
            }
        }

        private void LoadInterpretationDetails(InterpretationDTO interpretation)
        {
            userIdNumeric.Value = interpretation.UserId;
            movieIdNumeric.Value = interpretation.MovieId;
            interpretationTextBox.Text = interpretation.InterpretationText;
        }

        private async Task DisplayErrorAsync(Label label, string message)
        {
            label.Text = message;
            await Task.Delay(3000);
            label.Text = "";
        }

        private async void interpretationMgmtDataGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var senderGrid = (DataGridView)sender;
            InterpretationDTO interpretation = (InterpretationDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
            {
                if (buttonColumn.Name == "Edit")
                {
                    interpretationViewTabCtrl.SelectedIndex = 1;
                    currentInterpretationId = interpretation.Id;
                    LoadInterpretationDetails(interpretation);
                }
                else if (buttonColumn.Name == "Delete")
                {
                    try
                    {
                        await DeleteInterpretationAsync(interpretation.Id);
                        LoadInterpretationsPage();
                        interpretationMgmtErrorLabel.Text = "Interpretation deleted successfully!";
                    }
                    catch (System.Exception ex)
                    {
                        interpretationMgmtErrorLabel.Text = $"An error occurred while deleting the interpretation: {ex.Message}";
                    }
                    finally
                    {
                        await Task.Delay(3000);
                        interpretationMgmtErrorLabel.Text = "";
                    }
                }
            }
            senderGrid.CurrentCell = null;
        }

        private void previousPageBtnInterpretations_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadInterpretationsPage();
        }

        private void nextPageBtnInterpretations_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadInterpretationsPage();
        }
    }
}
