namespace WinFormsApp
{
    partial class EditPerformanceForm
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
            this.performerFirstNameLabel = new System.Windows.Forms.Label();
            this.performerLastNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.performerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.performerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // performerFirstNameLabel
            // 
            this.performerFirstNameLabel.AutoSize = true;
            this.performerFirstNameLabel.Location = new System.Drawing.Point(12, 19);
            this.performerFirstNameLabel.Name = "performerFirstNameLabel";
            this.performerFirstNameLabel.Size = new System.Drawing.Size(152, 20);
            this.performerFirstNameLabel.TabIndex = 0;
            this.performerFirstNameLabel.Text = "Performer First Name:";
            // 
            // performerLastNameLabel
            // 
            this.performerLastNameLabel.AutoSize = true;
            this.performerLastNameLabel.Location = new System.Drawing.Point(12, 56);
            this.performerLastNameLabel.Name = "performerLastNameLabel";
            this.performerLastNameLabel.Size = new System.Drawing.Size(151, 20);
            this.performerLastNameLabel.TabIndex = 1;
            this.performerLastNameLabel.Text = "Performer Last Name:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 94);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(41, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(12, 131);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(136, 20);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration (minutes):";
            // 
            // performerFirstNameTextBox
            // 
            this.performerFirstNameTextBox.Location = new System.Drawing.Point(160, 16);
            this.performerFirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.performerFirstNameTextBox.Name = "performerFirstNameTextBox";
            this.performerFirstNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.performerFirstNameTextBox.TabIndex = 4;
            // 
            // performerLastNameTextBox
            // 
            this.performerLastNameTextBox.Location = new System.Drawing.Point(160, 53);
            this.performerLastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.performerLastNameTextBox.Name = "performerLastNameTextBox";
            this.performerLastNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.performerLastNameTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(160, 91);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 27);
            this.titleTextBox.TabIndex = 6;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(160, 129);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(200, 27);
            this.durationTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(122, 178);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 38);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 178);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 38);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.performerLastNameTextBox);
            this.Controls.Add(this.performerFirstNameTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.performerLastNameLabel);
            this.Controls.Add(this.performerFirstNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EditPerformanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label performerFirstNameLabel;
        private System.Windows.Forms.Label performerLastNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox performerFirstNameTextBox;
        private System.Windows.Forms.TextBox performerLastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}