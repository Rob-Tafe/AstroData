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
            this.LabelListBoxData = new System.Windows.Forms.Label();
            this.LabelBinarySearch = new System.Windows.Forms.Label();
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
            this.ListBoxData.Location = new System.Drawing.Point(12, 64);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(139, 303);
            this.ListBoxData.TabIndex = 1;
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(166, 64);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonBubbleSort.TabIndex = 2;
            this.ButtonBubbleSort.Text = "Bubble Sort";
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(166, 154);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(86, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(166, 180);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(86, 23);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // LabelListBoxData
            // 
            this.LabelListBoxData.AutoSize = true;
            this.LabelListBoxData.Location = new System.Drawing.Point(10, 48);
            this.LabelListBoxData.Name = "LabelListBoxData";
            this.LabelListBoxData.Size = new System.Drawing.Size(78, 13);
            this.LabelListBoxData.TabIndex = 5;
            this.LabelListBoxData.Text = "Index.     Value";
            // 
            // LabelBinarySearch
            // 
            this.LabelBinarySearch.AutoSize = true;
            this.LabelBinarySearch.Location = new System.Drawing.Point(163, 138);
            this.LabelBinarySearch.Name = "LabelBinarySearch";
            this.LabelBinarySearch.Size = new System.Drawing.Size(37, 13);
            this.LabelBinarySearch.TabIndex = 6;
            this.LabelBinarySearch.Text = "Value:";
            // 
            // AstroDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 380);
            this.Controls.Add(this.LabelBinarySearch);
            this.Controls.Add(this.LabelListBoxData);
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
        private System.Windows.Forms.Label LabelListBoxData;
        private System.Windows.Forms.Label LabelBinarySearch;
    }
}

