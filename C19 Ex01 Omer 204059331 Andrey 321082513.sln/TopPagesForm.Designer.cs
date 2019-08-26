namespace C19_Ex01_Omer_204059331_Andrey_321082513.sln
{
    partial class TopPagesForm
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
            this.pagesLikedListBox = new System.Windows.Forms.ListBox();
            this.pagePicturebox = new System.Windows.Forms.PictureBox();
            this.pagesLikesNameLabel = new System.Windows.Forms.Label();
            this.pageAdressNameLabel = new System.Windows.Forms.Label();
            this.descriptionNameLabel = new System.Windows.Forms.Label();
            this.pageAdressFillLabel = new System.Windows.Forms.Label();
            this.descriptionFillLabel = new System.Windows.Forms.Label();
            this.pagesLikesNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pagesLikedListBox
            // 
            this.pagesLikedListBox.FormattingEnabled = true;
            this.pagesLikedListBox.Location = new System.Drawing.Point(39, 33);
            this.pagesLikedListBox.Name = "pagesLikedListBox";
            this.pagesLikedListBox.Size = new System.Drawing.Size(120, 95);
            this.pagesLikedListBox.TabIndex = 0;
            this.pagesLikedListBox.SelectedIndexChanged += new System.EventHandler(this.pageLiked_OnIndexChanged);
            // 
            // pagePicturebox
            // 
            this.pagePicturebox.Location = new System.Drawing.Point(363, 33);
            this.pagePicturebox.Name = "pagePicturebox";
            this.pagePicturebox.Size = new System.Drawing.Size(114, 95);
            this.pagePicturebox.TabIndex = 1;
            this.pagePicturebox.TabStop = false;
            // 
            // pagesLikesNameLabel
            // 
            this.pagesLikesNameLabel.AutoSize = true;
            this.pagesLikesNameLabel.Location = new System.Drawing.Point(36, 171);
            this.pagesLikesNameLabel.Name = "pagesLikesNameLabel";
            this.pagesLikesNameLabel.Size = new System.Drawing.Size(64, 13);
            this.pagesLikesNameLabel.TabIndex = 2;
            this.pagesLikesNameLabel.Text = "Pages likes:";
            // 
            // pageAdressNameLabel
            // 
            this.pageAdressNameLabel.AutoSize = true;
            this.pageAdressNameLabel.Location = new System.Drawing.Point(36, 222);
            this.pageAdressNameLabel.Name = "pageAdressNameLabel";
            this.pageAdressNameLabel.Size = new System.Drawing.Size(39, 13);
            this.pageAdressNameLabel.TabIndex = 3;
            this.pageAdressNameLabel.Text = "Adress";
            // 
            // descriptionNameLabel
            // 
            this.descriptionNameLabel.AutoSize = true;
            this.descriptionNameLabel.Location = new System.Drawing.Point(36, 198);
            this.descriptionNameLabel.Name = "descriptionNameLabel";
            this.descriptionNameLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionNameLabel.TabIndex = 4;
            this.descriptionNameLabel.Text = "Description: ";
            // 
            // pageAdressFillLabel
            // 
            this.pageAdressFillLabel.AutoSize = true;
            this.pageAdressFillLabel.Location = new System.Drawing.Point(77, 222);
            this.pageAdressFillLabel.Name = "pageAdressFillLabel";
            this.pageAdressFillLabel.Size = new System.Drawing.Size(0, 13);
            this.pageAdressFillLabel.TabIndex = 5;
            // 
            // descriptionFillLabel
            // 
            this.descriptionFillLabel.AutoSize = true;
            this.descriptionFillLabel.Location = new System.Drawing.Point(91, 198);
            this.descriptionFillLabel.Name = "descriptionFillLabel";
            this.descriptionFillLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionFillLabel.TabIndex = 6;
            // 
            // pagesLikesNumberLabel
            // 
            this.pagesLikesNumberLabel.AutoSize = true;
            this.pagesLikesNumberLabel.Location = new System.Drawing.Point(106, 171);
            this.pagesLikesNumberLabel.Name = "pagesLikesNumberLabel";
            this.pagesLikesNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.pagesLikesNumberLabel.TabIndex = 7;
            // 
            // TopPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.pagesLikesNumberLabel);
            this.Controls.Add(this.descriptionFillLabel);
            this.Controls.Add(this.pageAdressFillLabel);
            this.Controls.Add(this.descriptionNameLabel);
            this.Controls.Add(this.pageAdressNameLabel);
            this.Controls.Add(this.pagesLikesNameLabel);
            this.Controls.Add(this.pagePicturebox);
            this.Controls.Add(this.pagesLikedListBox);
            this.Name = "TopPagesForm";
            this.Text = "Top Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pagesLikedListBox;
        private System.Windows.Forms.PictureBox pagePicturebox;
        private System.Windows.Forms.Label pagesLikesNameLabel;
        private System.Windows.Forms.Label pageAdressNameLabel;
        private System.Windows.Forms.Label descriptionNameLabel;
        private System.Windows.Forms.Label pageAdressFillLabel;
        private System.Windows.Forms.Label descriptionFillLabel;
        private System.Windows.Forms.Label pagesLikesNumberLabel;
    }
}