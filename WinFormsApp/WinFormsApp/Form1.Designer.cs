namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.concertsListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addConcertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // concertsListBox
            // 
            this.concertsListBox.FormattingEnabled = true;
            this.concertsListBox.ItemHeight = 20;
            this.concertsListBox.Location = new System.Drawing.Point(16, 18);
            this.concertsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.concertsListBox.Name = "concertsListBox";
            this.concertsListBox.Size = new System.Drawing.Size(457, 284);
            this.concertsListBox.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(16, 326);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 35);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addConcertButton
            // 
            this.addConcertButton.Location = new System.Drawing.Point(139, 326);
            this.addConcertButton.Name = "addConcertButton";
            this.addConcertButton.Size = new System.Drawing.Size(101, 35);
            this.addConcertButton.TabIndex = 2;
            this.addConcertButton.Text = "Add";
            this.addConcertButton.UseVisualStyleBackColor = true;
            this.addConcertButton.Click += new System.EventHandler(this.addConcertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.addConcertButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.concertsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Concert App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox concertsListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addConcertButton;
    }
}
