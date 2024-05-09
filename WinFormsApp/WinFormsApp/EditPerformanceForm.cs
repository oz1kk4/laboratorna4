using ConcertLibrary;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class EditPerformanceForm : Form
    {
        public string PerformerFirstName { get; private set; }
        public string PerformerLastName { get; private set; }
        public string Title { get; private set; }
        public int Duration { get; private set; }
        public EditPerformanceForm(Performance performance)
        {
            InitializeComponent();
            performerFirstNameTextBox.Text = performance.Performer.FirstName;
            performerLastNameTextBox.Text = performance.Performer.LastName;
            titleTextBox.Text = performance.Title;
            durationTextBox.Text = performance.Duration.ToString();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            PerformerFirstName = performerFirstNameTextBox.Text;
            PerformerLastName = performerLastNameTextBox.Text;
            Title = titleTextBox.Text;

            if (!int.TryParse(durationTextBox.Text, out int duration))
            {
                MessageBox.Show("Invalid duration. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Duration = duration;

            if (string.IsNullOrWhiteSpace(PerformerFirstName) || string.IsNullOrWhiteSpace(PerformerLastName) ||
                string.IsNullOrWhiteSpace(Title) || Duration <= 0)
            {
                MessageBox.Show("Please enter valid performance details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
