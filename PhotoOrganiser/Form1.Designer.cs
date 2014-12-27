namespace PhotoOrganiser
{
    partial class MainForm
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
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceFolderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.destinationBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationFolderText = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceFolderText
            // 
            this.sourceFolderText.Location = new System.Drawing.Point(112, 22);
            this.sourceFolderText.Name = "sourceFolderText";
            this.sourceFolderText.Size = new System.Drawing.Size(441, 20);
            this.sourceFolderText.TabIndex = 0;
            this.sourceFolderText.Text = "D:\\Temp\\Dylan Pictures";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Folder:";
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(579, 20);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(45, 23);
            this.sourceBrowseButton.TabIndex = 2;
            this.sourceBrowseButton.Text = "...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // destinationBrowseButton
            // 
            this.destinationBrowseButton.Location = new System.Drawing.Point(579, 55);
            this.destinationBrowseButton.Name = "destinationBrowseButton";
            this.destinationBrowseButton.Size = new System.Drawing.Size(45, 23);
            this.destinationBrowseButton.TabIndex = 5;
            this.destinationBrowseButton.Text = "...";
            this.destinationBrowseButton.UseVisualStyleBackColor = true;
            this.destinationBrowseButton.Click += new System.EventHandler(this.destinationBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination Folder:";
            // 
            // destinationFolderText
            // 
            this.destinationFolderText.Location = new System.Drawing.Point(112, 57);
            this.destinationFolderText.Name = "destinationFolderText";
            this.destinationFolderText.Size = new System.Drawing.Size(441, 20);
            this.destinationFolderText.TabIndex = 3;
            this.destinationFolderText.Text = "D:\\Temp\\Test";
            // 
            // goButton
            // 
            this.goButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.goButton.Location = new System.Drawing.Point(549, 93);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "&Ok";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(16, 142);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.Size = new System.Drawing.Size(619, 168);
            this.resultGridView.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 322);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.destinationBrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinationFolderText);
            this.Controls.Add(this.sourceBrowseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFolderText);
            this.Name = "MainForm";
            this.Text = "Photo Organiser";
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderBrowserDialog;
        private System.Windows.Forms.TextBox sourceFolderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sourceBrowseButton;
        private System.Windows.Forms.Button destinationBrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationFolderText;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataGridView resultGridView;
    }
}

