namespace BookCatalog
{
    partial class AuthorsInfo
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
            this.AuthorsInfoGridView = new System.Windows.Forms.DataGridView();
            this.AuthorDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorsInfoGridView
            // 
            this.AuthorsInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsInfoGridView.Location = new System.Drawing.Point(23, 31);
            this.AuthorsInfoGridView.Name = "AuthorsInfoGridView";
            this.AuthorsInfoGridView.Size = new System.Drawing.Size(445, 323);
            this.AuthorsInfoGridView.TabIndex = 0;
            // 
            // AuthorDeleteButton
            // 
            this.AuthorDeleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.AuthorDeleteButton.Location = new System.Drawing.Point(378, 376);
            this.AuthorDeleteButton.Name = "AuthorDeleteButton";
            this.AuthorDeleteButton.Size = new System.Drawing.Size(81, 34);
            this.AuthorDeleteButton.TabIndex = 1;
            this.AuthorDeleteButton.Text = "Delete";
            this.AuthorDeleteButton.UseVisualStyleBackColor = false;
            this.AuthorDeleteButton.Click += new System.EventHandler(this.AuthorDeleteButton_Click);
            // 
            // AuthorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(484, 422);
            this.Controls.Add(this.AuthorDeleteButton);
            this.Controls.Add(this.AuthorsInfoGridView);
            this.Name = "AuthorsInfo";
            this.Text = "AuthorsInfo";
            this.Load += new System.EventHandler(this.AuthorsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorsInfoGridView;
        private System.Windows.Forms.Button AuthorDeleteButton;
    }
}