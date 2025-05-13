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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroDataForm));
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
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.buttonSequentialSearch = new System.Windows.Forms.Button();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.TTListBoxdata = new System.Windows.Forms.ToolTip(this.components);
            this.TTAstroDataButton = new System.Windows.Forms.ToolTip(this.components);
            this.TTBubbleSort = new System.Windows.Forms.ToolTip(this.components);
            this.TTMidExtreme = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ButtonRandomData
            // 
            this.ButtonRandomData.Location = new System.Drawing.Point(130, 10);
            this.ButtonRandomData.Name = "ButtonRandomData";
            this.ButtonRandomData.Size = new System.Drawing.Size(120, 35);
            this.ButtonRandomData.TabIndex = 0;
            this.ButtonRandomData.Text = "Load Astrometric Data";
            this.TTAstroDataButton.SetToolTip(this.ButtonRandomData, "This button will generate an array of\r\nastrometric data and display it in the\r\nli" +
        "st box.");
            this.ButtonRandomData.UseVisualStyleBackColor = true;
            this.ButtonRandomData.Click += new System.EventHandler(this.ButtonRandomData_Click);
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.Location = new System.Drawing.Point(131, 70);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(118, 290);
            this.ListBoxData.TabIndex = 1;
            this.TTListBoxdata.SetToolTip(this.ListBoxData, "This is where the astrometric data\r\nwill be displayed. You can select a\r\nvalue to" +
        " be edited or deleted.");
            // 
            // ButtonBubbleSort
            // 
            this.ButtonBubbleSort.Location = new System.Drawing.Point(270, 10);
            this.ButtonBubbleSort.Name = "ButtonBubbleSort";
            this.ButtonBubbleSort.Size = new System.Drawing.Size(100, 35);
            this.ButtonBubbleSort.TabIndex = 2;
            this.ButtonBubbleSort.Text = "Bubble Sort";
            this.TTBubbleSort.SetToolTip(this.ButtonBubbleSort, "This button will sort the data displayed\r\nin the list box in ascending order.");
            this.ButtonBubbleSort.UseVisualStyleBackColor = true;
            this.ButtonBubbleSort.Click += new System.EventHandler(this.ButtonBubbleSort_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(271, 85);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(98, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(270, 110);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(100, 35);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // LabelListBoxData
            // 
            this.LabelListBoxData.AutoSize = true;
            this.LabelListBoxData.Location = new System.Drawing.Point(130, 55);
            this.LabelListBoxData.Name = "LabelListBoxData";
            this.LabelListBoxData.Size = new System.Drawing.Size(81, 13);
            this.LabelListBoxData.TabIndex = 5;
            this.LabelListBoxData.Text = "Index.      Value";
            // 
            // LabelBinarySearch
            // 
            this.LabelBinarySearch.AutoSize = true;
            this.LabelBinarySearch.Location = new System.Drawing.Point(270, 70);
            this.LabelBinarySearch.Name = "LabelBinarySearch";
            this.LabelBinarySearch.Size = new System.Drawing.Size(86, 13);
            this.LabelBinarySearch.TabIndex = 6;
            this.LabelBinarySearch.Text = "Value to Search:";
            // 
            // TextBoxInputData
            // 
            this.TextBoxInputData.Location = new System.Drawing.Point(271, 229);
            this.TextBoxInputData.Name = "TextBoxInputData";
            this.TextBoxInputData.Size = new System.Drawing.Size(98, 20);
            this.TextBoxInputData.TabIndex = 7;
            // 
            // ButtonInputData
            // 
            this.ButtonInputData.Location = new System.Drawing.Point(270, 256);
            this.ButtonInputData.Name = "ButtonInputData";
            this.ButtonInputData.Size = new System.Drawing.Size(100, 35);
            this.ButtonInputData.TabIndex = 8;
            this.ButtonInputData.Text = "Edit Selected Data";
            this.ButtonInputData.UseVisualStyleBackColor = true;
            this.ButtonInputData.Click += new System.EventHandler(this.ButtonInputData_Click);
            // 
            // LabelInputValue
            // 
            this.LabelInputValue.AutoSize = true;
            this.LabelInputValue.Location = new System.Drawing.Point(270, 213);
            this.LabelInputValue.Name = "LabelInputValue";
            this.LabelInputValue.Size = new System.Drawing.Size(76, 13);
            this.LabelInputValue.TabIndex = 9;
            this.LabelInputValue.Text = "Value to Input:";
            // 
            // ButtonDeleteData
            // 
            this.ButtonDeleteData.Location = new System.Drawing.Point(270, 325);
            this.ButtonDeleteData.Name = "ButtonDeleteData";
            this.ButtonDeleteData.Size = new System.Drawing.Size(100, 35);
            this.ButtonDeleteData.TabIndex = 10;
            this.ButtonDeleteData.Text = "Delete Selected Data";
            this.ButtonDeleteData.UseVisualStyleBackColor = true;
            this.ButtonDeleteData.Click += new System.EventHandler(this.ButtonDeleteData_Click);
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(10, 70);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(100, 30);
            this.ButtonMidExtreme.TabIndex = 11;
            this.ButtonMidExtreme.Text = "Mid-Extreme";
            this.TTMidExtreme.SetToolTip(this.ButtonMidExtreme, resources.GetString("ButtonMidExtreme.ToolTip"));
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(10, 145);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(100, 30);
            this.ButtonMode.TabIndex = 12;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(10, 225);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(100, 30);
            this.ButtonAverage.TabIndex = 13;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(10, 305);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(100, 30);
            this.ButtonRange.TabIndex = 14;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // buttonSequentialSearch
            // 
            this.buttonSequentialSearch.Location = new System.Drawing.Point(270, 150);
            this.buttonSequentialSearch.Name = "buttonSequentialSearch";
            this.buttonSequentialSearch.Size = new System.Drawing.Size(100, 35);
            this.buttonSequentialSearch.TabIndex = 15;
            this.buttonSequentialSearch.Text = "Sequential Search";
            this.buttonSequentialSearch.UseVisualStyleBackColor = true;
            this.buttonSequentialSearch.Click += new System.EventHandler(this.buttonSequentialSearch_Click);
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(11, 105);
            this.TextBoxMidExtreme.MaxLength = 4;
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.ReadOnly = true;
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(98, 20);
            this.TextBoxMidExtreme.TabIndex = 16;
            this.TextBoxMidExtreme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(11, 180);
            this.TextBoxMode.MaxLength = 4;
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.ReadOnly = true;
            this.TextBoxMode.Size = new System.Drawing.Size(98, 20);
            this.TextBoxMode.TabIndex = 17;
            this.TextBoxMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(11, 260);
            this.TextBoxAverage.MaxLength = 4;
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.ReadOnly = true;
            this.TextBoxAverage.Size = new System.Drawing.Size(98, 20);
            this.TextBoxAverage.TabIndex = 18;
            this.TextBoxAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(11, 340);
            this.TextBoxRange.MaxLength = 4;
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.ReadOnly = true;
            this.TextBoxRange.Size = new System.Drawing.Size(98, 20);
            this.TextBoxRange.TabIndex = 19;
            this.TextBoxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AstroDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 371);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.TextBoxAverage);
            this.Controls.Add(this.TextBoxMode);
            this.Controls.Add(this.TextBoxMidExtreme);
            this.Controls.Add(this.buttonSequentialSearch);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonMidExtreme);
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
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.Button buttonSequentialSearch;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.ToolTip TTListBoxdata;
        private System.Windows.Forms.ToolTip TTAstroDataButton;
        private System.Windows.Forms.ToolTip TTBubbleSort;
        private System.Windows.Forms.ToolTip TTMidExtreme;
    }
}

