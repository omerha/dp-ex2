namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    partial class TopEventsForm
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
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.selectedEventPictureBox = new System.Windows.Forms.PictureBox();
            this.eventDescriptionNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionFillLabel = new System.Windows.Forms.Label();
            this.eventNumOfGoingFillLabel = new System.Windows.Forms.Label();
            this.eventLocationNameLabel = new System.Windows.Forms.Label();
            this.eventNumOfGoingNameLabel = new System.Windows.Forms.Label();
            this.eventLocationFillLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedEventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(34, 45);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(162, 108);
            this.eventsListBox.TabIndex = 0;
            // 
            // selectedEventPictureBox
            // 
            this.selectedEventPictureBox.Location = new System.Drawing.Point(424, 45);
            this.selectedEventPictureBox.Name = "selectedEventPictureBox";
            this.selectedEventPictureBox.Size = new System.Drawing.Size(134, 108);
            this.selectedEventPictureBox.TabIndex = 1;
            this.selectedEventPictureBox.TabStop = false;
            // 
            // eventDescriptionNameLabel
            // 
            this.eventDescriptionNameLabel.AutoSize = true;
            this.eventDescriptionNameLabel.Location = new System.Drawing.Point(31, 186);
            this.eventDescriptionNameLabel.Name = "eventDescriptionNameLabel";
            this.eventDescriptionNameLabel.Size = new System.Drawing.Size(95, 13);
            this.eventDescriptionNameLabel.TabIndex = 2;
            this.eventDescriptionNameLabel.Text = "Event description: ";
            // 
            // eventDescriptionFillLabel
            // 
            this.eventDescriptionFillLabel.AutoSize = true;
            this.eventDescriptionFillLabel.Location = new System.Drawing.Point(131, 186);
            this.eventDescriptionFillLabel.Name = "eventDescriptionFillLabel";
            this.eventDescriptionFillLabel.Size = new System.Drawing.Size(0, 13);
            this.eventDescriptionFillLabel.TabIndex = 3;
            // 
            // eventNumOfGoingFillLabel
            // 
            this.eventNumOfGoingFillLabel.AutoSize = true;
            this.eventNumOfGoingFillLabel.Location = new System.Drawing.Point(131, 241);
            this.eventNumOfGoingFillLabel.Name = "eventNumOfGoingFillLabel";
            this.eventNumOfGoingFillLabel.Size = new System.Drawing.Size(0, 13);
            this.eventNumOfGoingFillLabel.TabIndex = 4;
            // 
            // eventLocationNameLabel
            // 
            this.eventLocationNameLabel.AutoSize = true;
            this.eventLocationNameLabel.Location = new System.Drawing.Point(31, 214);
            this.eventLocationNameLabel.Name = "eventLocationNameLabel";
            this.eventLocationNameLabel.Size = new System.Drawing.Size(81, 13);
            this.eventLocationNameLabel.TabIndex = 5;
            this.eventLocationNameLabel.Text = "Event location: ";
            // 
            // eventNumOfGoingNameLabel
            // 
            this.eventNumOfGoingNameLabel.AutoSize = true;
            this.eventNumOfGoingNameLabel.Location = new System.Drawing.Point(31, 241);
            this.eventNumOfGoingNameLabel.Name = "eventNumOfGoingNameLabel";
            this.eventNumOfGoingNameLabel.Size = new System.Drawing.Size(41, 13);
            this.eventNumOfGoingNameLabel.TabIndex = 6;
            this.eventNumOfGoingNameLabel.Text = "Going: ";
            // 
            // eventLocationFillLabel
            // 
            this.eventLocationFillLabel.AutoSize = true;
            this.eventLocationFillLabel.Location = new System.Drawing.Point(131, 214);
            this.eventLocationFillLabel.Name = "eventLocationFillLabel";
            this.eventLocationFillLabel.Size = new System.Drawing.Size(0, 13);
            this.eventLocationFillLabel.TabIndex = 7;
            // 
            // TopEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.eventLocationFillLabel);
            this.Controls.Add(this.eventNumOfGoingNameLabel);
            this.Controls.Add(this.eventLocationNameLabel);
            this.Controls.Add(this.eventNumOfGoingFillLabel);
            this.Controls.Add(this.eventDescriptionFillLabel);
            this.Controls.Add(this.eventDescriptionNameLabel);
            this.Controls.Add(this.selectedEventPictureBox);
            this.Controls.Add(this.eventsListBox);
            this.Name = "TopEventsForm";
            this.Text = "TopEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.selectedEventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.PictureBox selectedEventPictureBox;
        private System.Windows.Forms.Label eventDescriptionNameLabel;
        private System.Windows.Forms.Label eventDescriptionFillLabel;
        private System.Windows.Forms.Label eventNumOfGoingFillLabel;
        private System.Windows.Forms.Label eventLocationNameLabel;
        private System.Windows.Forms.Label eventNumOfGoingNameLabel;
        private System.Windows.Forms.Label eventLocationFillLabel;
    }
}