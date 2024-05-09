using ConcertLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AddPerformanceForm : Form
    {
        public Performer Performer { get; private set; }
        public string Title { get; private set; }
        public int Duration { get; private set; }
        public AddPerformanceForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(performerFirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(performerLastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(durationTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(durationTextBox.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show("Please enter a valid duration (a positive integer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Performer = new Performer(performerFirstNameTextBox.Text, performerLastNameTextBox.Text);
            Title = titleTextBox.Text;
            Duration = duration;

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
