using System;
using System.Linq;
using System.Windows.Forms;
using ConcertLibrary;

namespace WinFormsApp
{
    public partial class EditForm : Form
    {
        public Concert editedConcert;
        public EditForm(Concert concert)
        {
            InitializeComponent();
            editedConcert = concert;

            organizerTextBox.Text = editedConcert.Organizer;
            concertDatePicker.Value = editedConcert.Date;

            foreach (Performance performance in editedConcert.Performances)
            {
                ListViewItem item = new ListViewItem(performance.Performer.ToString());
                item.SubItems.Add(performance.Title);
                item.SubItems.Add(performance.Duration.ToString());
                performancesListView.Items.Add(item);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerformanceForm addPerformanceForm = new AddPerformanceForm();
            if (addPerformanceForm.ShowDialog() == DialogResult.OK)
            {
                Performer performer = new Performer(addPerformanceForm.Performer.FirstName, addPerformanceForm.Performer.LastName);
                string title = addPerformanceForm.Title;
                int duration = addPerformanceForm.Duration;

                Performance performance = new Performance(performer, title, duration);
                ListViewItem item = new ListViewItem(performer.ToString());
                item.SubItems.Add(title);
                item.SubItems.Add(duration.ToString());
                performancesListView.Items.Add(item);
                editedConcert.Performances.Add(performance);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (performancesListView.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = performancesListView.SelectedItems[0];

                int selectedIndex = performancesListView.Items.IndexOf(selectedItem);

                Performance selectedPerformance = editedConcert.Performances[selectedIndex];

                EditPerformanceForm editPerformanceForm = new EditPerformanceForm(selectedPerformance);
                if (editPerformanceForm.ShowDialog() == DialogResult.OK)
                {
                    selectedPerformance.Performer.FirstName = editPerformanceForm.PerformerFirstName;
                    selectedPerformance.Performer.LastName = editPerformanceForm.PerformerLastName;
                    selectedPerformance.Title = editPerformanceForm.Title;
                    selectedPerformance.Duration = editPerformanceForm.Duration;

                    selectedItem.SubItems[0].Text = selectedPerformance.Performer.ToString();
                    selectedItem.SubItems[1].Text = selectedPerformance.Title;
                    selectedItem.SubItems[2].Text = selectedPerformance.Duration.ToString();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (performancesListView.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = performancesListView.SelectedItems[0];
                
                int selectedIndex = performancesListView.Items.IndexOf(selectedItem);

                editedConcert.Performances.RemoveAt(selectedIndex);
                performancesListView.Items.Remove(selectedItem);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            editedConcert.Organizer = organizerTextBox.Text;
            editedConcert.Date = concertDatePicker.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
