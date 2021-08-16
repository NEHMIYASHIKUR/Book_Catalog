namespace BookCatalog
{
    partial class AddAuthor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNationality = new System.Windows.Forms.TextBox();
            this.TextBoxGender = new System.Windows.Forms.TextBox();
            this.AddAuthorSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxName.Location = new System.Drawing.Point(123, 88);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(204, 22);
            this.TextBoxName.TabIndex = 2;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "NATIONALITY";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "GENDER";
            // 
            // TextBoxNationality
            // 
            this.TextBoxNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNationality.Location = new System.Drawing.Point(175, 148);
            this.TextBoxNationality.Name = "TextBoxNationality";
            this.TextBoxNationality.Size = new System.Drawing.Size(173, 22);
            this.TextBoxNationality.TabIndex = 5;
            this.TextBoxNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxGender
            // 
            this.TextBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxGender.Location = new System.Drawing.Point(134, 205);
            this.TextBoxGender.Name = "TextBoxGender";
            this.TextBoxGender.Size = new System.Drawing.Size(204, 22);
            this.TextBoxGender.TabIndex = 6;
            this.TextBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAuthorSubmitButton
            // 
            this.AddAuthorSubmitButton.BackColor = System.Drawing.Color.CadetBlue;
            this.AddAuthorSubmitButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAuthorSubmitButton.Location = new System.Drawing.Point(216, 283);
            this.AddAuthorSubmitButton.Name = "AddAuthorSubmitButton";
            this.AddAuthorSubmitButton.Size = new System.Drawing.Size(111, 37);
            this.AddAuthorSubmitButton.TabIndex = 7;
            this.AddAuthorSubmitButton.Text = "Submit";
            this.AddAuthorSubmitButton.UseVisualStyleBackColor = false;
            this.AddAuthorSubmitButton.Click += new System.EventHandler(this.AddAuthorSubmitButton_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(360, 406);
            this.Controls.Add(this.AddAuthorSubmitButton);
            this.Controls.Add(this.TextBoxGender);
            this.Controls.Add(this.TextBoxNationality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddAuthor";
            this.Text = "AddAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNationality;
        private System.Windows.Forms.TextBox TextBoxGender;
        private System.Windows.Forms.Button AddAuthorSubmitButton;
    }
}