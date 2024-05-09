namespace WinFormsApp
{
    partial class EditForm
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
            this.organizerLabel = new System.Windows.Forms.Label();
            this.organizerTextBox = new System.Windows.Forms.TextBox();
            this.concertDateLabel = new System.Windows.Forms.Label();
            this.concertDatePicker = new System.Windows.Forms.DateTimePicker();
            this.performancesLabel = new System.Windows.Forms.Label();
            this.performancesListView = new System.Windows.Forms.ListView();
            this.performerHeader = new System.Windows.Forms.ColumnHeader();
            this.titleHeader = new System.Windows.Forms.ColumnHeader();
            this.durationHeader = new System.Windows.Forms.ColumnHeader();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // organizerLabel
            // 
            this.organizerLabel.AutoSize = true;
            this.organizerLabel.Location = new System.Drawing.Point(12, 15);
            this.organizerLabel.Name = "organizerLabel";
            this.organizerLabel.Size = new System.Drawing.Size(55, 13);
            this.organizerLabel.TabIndex = 0;
            this.organizerLabel.Text = "Organizer:";
            // 
            // organizerTextBox
            // 
            this.organizerTextBox.Location = new System.Drawing.Point(73, 12);
            this.organizerTextBox.Name = "organizerTextBox";
            this.organizerTextBox.Size = new System.Drawing.Size(200, 20);
            this.organizerTextBox.TabIndex = 1;
            // 
            // concertDateLabel
            // 
            this.concertDateLabel.AutoSize = true;
            this.concertDateLabel.Location = new System.Drawing.Point(12, 42);
            this.concertDateLabel.Name = "concertDateLabel";
            this.concertDateLabel.Size = new System.Drawing.Size(39, 13);
            this.concertDateLabel.TabIndex = 2;
            this.concertDateLabel.Text = "Date:";
            // 
            // concertDatePicker
            // 
            this.concertDatePicker.Location = new System.Drawing.Point(73, 38);
            this.concertDatePicker.Name = "concertDatePicker";
            this.concertDatePicker.Size = new System.Drawing.Size(200, 20);
            this.concertDatePicker.TabIndex = 3;
            // 
            // performancesLabel
            // 
            this.performancesLabel.AutoSize = true;
            this.performancesLabel.Location = new System.Drawing.Point(12, 77);
            this.performancesLabel.Name = "performancesLabel";
            this.performancesLabel.Size = new System.Drawing.Size(81, 13);
            this.performancesLabel.TabIndex = 4;
            this.performancesLabel.Text = "Performances:";
            // 
            // performancesListView
            // 
            this.performancesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.performerHeader,
            this.titleHeader,
            this.durationHeader});
            this.performancesListView.FullRowSelect = true;
            this.performancesListView.HideSelection = false;
            this.performancesListView.Location = new System.Drawing.Point(15, 93);
            this.performancesListView.MultiSelect = false;
            this.performancesListView.Name = "performancesListView";
            this.performancesListView.Size = new System.Drawing.Size(350, 150);
            this.performancesListView.TabIndex = 5;
            this.performancesListView.UseCompatibleStateImageBehavior = false;
            this.performancesListView.View = System.Windows.Forms.View.Details;
            // 
            // performerHeader
            // 
            this.performerHeader.Text = "Performer";
            this.performerHeader.Width = 120;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 120;
            // 
            // durationHeader
            // 
            this.durationHeader.Text = "Duration";
            this.durationHeader.Width = 80;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(96, 249);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(177, 249);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(290, 249);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.performancesListView);
            this.Controls.Add(this.performancesLabel);
            this.Controls.Add(this.concertDatePicker);
            this.Controls.Add(this.concertDateLabel);
            this.Controls.Add(this.organizerTextBox);
            this.Controls.Add(this.organizerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Concert";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label organizerLabel;
        private System.Windows.Forms.TextBox organizerTextBox;
        private System.Windows.Forms.Label concertDateLabel;
        private System.Windows.Forms.DateTimePicker concertDatePicker;
        private System.Windows.Forms.Label performancesLabel;
        private System.Windows.Forms.ListView performancesListView;
        private System.Windows.Forms.ColumnHeader performerHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader durationHeader;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}