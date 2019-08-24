namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    partial class TopFriendsForm
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
            this.topFriendsListbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topFriendsListbox
            // 
            this.topFriendsListbox.FormattingEnabled = true;
            this.topFriendsListbox.Location = new System.Drawing.Point(44, 28);
            this.topFriendsListbox.Name = "topFriendsListbox";
            this.topFriendsListbox.Size = new System.Drawing.Size(120, 82);
            this.topFriendsListbox.TabIndex = 0;
            this.topFriendsListbox.SelectedIndexChanged += new System.EventHandler(this.topFriendsListbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TopFriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topFriendsListbox);
            this.Name = "TopFriendsForm";
            this.Text = "My best friends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox topFriendsListbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}