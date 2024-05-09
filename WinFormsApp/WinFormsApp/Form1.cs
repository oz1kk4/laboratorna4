using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ConcertLibrary;
using Newtonsoft.Json;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Concert> concerts;
        private string jsonFilePath = "concerts.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConcertsFromJson();
            ShowConcerts();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConcertsToFile();
        }
        private void SaveConcertsToFile()
        {
            // Серіалізуємо список концертів у JSON і зберігаємо у файл
            string json = JsonConvert.SerializeObject(concerts);
            File.WriteAllText(jsonFilePath, json);
        }

        private void LoadConcertsFromJson()
        {
            

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                concerts = JsonConvert.DeserializeObject<List<Concert>>(json);
            }
            else
            {
                concerts = new List<Concert>();
            }
        }

        private void ShowConcerts()
        {
            concertsListBox.Items.Clear();

            foreach (Concert concert in concerts)
            {
                concertsListBox.Items.Add(concert.ToShortString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (concertsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = concertsListBox.SelectedIndex;
                Concert selectedConcert = concerts[selectedIndex];

                EditForm editForm = new EditForm(selectedConcert);
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    concerts[selectedIndex] = editForm.editedConcert;
                    ShowConcerts();
                }
            }
            else
            {
                MessageBox.Show("No concert selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addConcertButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Concert("", DateTime.Now));
            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Concert concert = editForm.editedConcert;
                concerts.Add(concert);
                ShowConcerts();
            }
        }
    }
}
