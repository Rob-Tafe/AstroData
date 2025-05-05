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
            this.TextBoxInputData = new System.Windows.Forms.TextBox();
            this.ButtonInputData = new System.Windows.Forms.Button();
            this.LabelInputValue = new System.Windows.Forms.Label();
            this.ButtonDeleteData = new System.Windows.Forms.Button();
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
            this.TextBoxSearch.Location = new System.Drawing.Point(166, 142);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(86, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(166, 168);
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
            this.LabelBinarySearch.Location = new System.Drawing.Point(166, 126);
            this.LabelBinarySearch.Name = "LabelBinarySearch";
            this.LabelBinarySearch.Size = new System.Drawing.Size(86, 13);
            this.LabelBinarySearch.TabIndex = 6;
            this.LabelBinarySearch.Text = "Value to Search:";
            // 
            // TextBoxInputData
            // 
            this.TextBoxInputData.Location = new System.Drawing.Point(166, 244);
            this.TextBoxInputData.Name = "TextBoxInputData";
            this.TextBoxInputData.Size = new System.Drawing.Size(86, 20);
            this.TextBoxInputData.TabIndex = 7;
            // 
            // ButtonInputData
            // 
            this.ButtonInputData.Location = new System.Drawing.Point(166, 270);
            this.ButtonInputData.Name = "ButtonInputData";
            this.ButtonInputData.Size = new System.Drawing.Size(86, 36);
            this.ButtonInputData.TabIndex = 8;
            this.ButtonInputData.Text = "Edit Selected Data";
            this.ButtonInputData.UseVisualStyleBackColor = true;
            this.ButtonInputData.Click += new System.EventHandler(this.ButtonInputData_Click);
            // 
            // LabelInputValue
            // 
            this.LabelInputValue.AutoSize = true;
            this.LabelInputValue.Location = new System.Drawing.Point(165, 228);
            this.LabelInputValue.Name = "LabelInputValue";
            this.LabelInputValue.Size = new System.Drawing.Size(76, 13);
            this.LabelInputValue.TabIndex = 9;
            this.LabelInputValue.Text = "Value to Input:";
            // 
            // ButtonDeleteData
            // 
            this.ButtonDeleteData.Location = new System.Drawing.Point(166, 330);
            this.ButtonDeleteData.Name = "ButtonDeleteData";
            this.ButtonDeleteData.Size = new System.Drawing.Size(86, 37);
            this.ButtonDeleteData.TabIndex = 10;
            this.ButtonDeleteData.Text = "Delete Selected Data";
            this.ButtonDeleteData.UseVisualStyleBackColor = true;
            this.ButtonDeleteData.Click += new System.EventHandler(this.ButtonDeleteData_Click);
            // 
            // AstroDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 380);
            this.Controls.Add(this.ButtonDeleteData);
            this.Controls.Add(this.LabelInputValue);
            this.Controls.Add(this.ButtonInputData);
            this.Controls.Add(this.TextBoxInputData);
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
        private System.Windows.Forms.TextBox TextBoxInputData;
        private System.Windows.Forms.Button ButtonInputData;
        private System.Windows.Forms.Label LabelInputValue;
        private System.Windows.Forms.Button ButtonDeleteData;
    }
}

