namespace AstroData
{
    partial class AstroDataForm
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
            this.ButtonRandomData = new System.Windows.Forms.Button();
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.ButtonBubbleSort = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonRandomData
            // 
            this.ButtonRandomData.Location = new System.Drawing.Point(13, 13);
            this.ButtonRandomData.Name = "ButtonRandomData";
            this.ButtonRandomData.Size = new System.Drawing.Size(139, 23);
            this.ButtonRandomData.TabIndex = 0;
            this.ButtonRandomData.Text = "Load Astrometric Data";
            this.ButtonRandomData.UseVisualStyleBackColor = true;
            this.ButtonRandomData.Click += new System.EventHandler(this.ButtonRandomData_Click);
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.Location = new System.Drawing.Point(13, 52);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(139, 303);
            this.ListBoxData.TabIndex = 1;
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(176, 52);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonBubbleSort.TabIndex = 2;
            this.ButtonBubbleSort.Text = "Bubble Sort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(176, 160);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(86, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(176, 131);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(86, 23);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            // 
            // AstroDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 404);
            this.Controls.Add(this.ButtonBinarySearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonBubbleSort);
            this.Controls.Add(this.ListBoxData);
            this.Controls.Add(this.ButtonRandomData);
            this.Name = "AstroDataForm";
            this.Text = "AstroData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomData;
        private System.Windows.Forms.ListBox ListBoxData;
        private System.Windows.Forms.Button ButtonBubbleSort;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonBinarySearch;
    }
}

