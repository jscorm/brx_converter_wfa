namespace brx_converter_wfa
{
    partial class App
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
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.inputFolderPath = new System.Windows.Forms.TextBox();
            this.inputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.inputFolderBrowse = new System.Windows.Forms.Button();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderPath = new System.Windows.Forms.TextBox();
            this.outputFolderBrowse = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.convertButton = new System.Windows.Forms.Button();
            this.filesFoundLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.conversionProgressBar = new System.Windows.Forms.ProgressBar();
            this.convertedSongLabel = new System.Windows.Forms.Label();
            this.openOutputOnExit = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(14, 33);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(123, 17);
            this.inputFolderLabel.TabIndex = 0;
            this.inputFolderLabel.Text = "Folder to convert :";
            // 
            // inputFolderPath
            // 
            this.inputFolderPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputFolderPath.Enabled = false;
            this.inputFolderPath.Location = new System.Drawing.Point(143, 28);
            this.inputFolderPath.Name = "inputFolderPath";
            this.inputFolderPath.Size = new System.Drawing.Size(504, 22);
            this.inputFolderPath.TabIndex = 1;
            // 
            // inputFolderDialog
            // 
            this.inputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // inputFolderBrowse
            // 
            this.inputFolderBrowse.Location = new System.Drawing.Point(653, 27);
            this.inputFolderBrowse.Name = "inputFolderBrowse";
            this.inputFolderBrowse.Size = new System.Drawing.Size(37, 23);
            this.inputFolderBrowse.TabIndex = 2;
            this.inputFolderBrowse.Text = "...";
            this.inputFolderBrowse.UseVisualStyleBackColor = true;
            this.inputFolderBrowse.Click += new System.EventHandler(this.inputFolderBrowse_Click);
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(38, 73);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(99, 17);
            this.outputFolderLabel.TabIndex = 3;
            this.outputFolderLabel.Text = "Output folder :";
            // 
            // outputFolderPath
            // 
            this.outputFolderPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputFolderPath.Enabled = false;
            this.outputFolderPath.Location = new System.Drawing.Point(143, 70);
            this.outputFolderPath.Name = "outputFolderPath";
            this.outputFolderPath.Size = new System.Drawing.Size(504, 22);
            this.outputFolderPath.TabIndex = 4;
            // 
            // outputFolderBrowse
            // 
            this.outputFolderBrowse.Location = new System.Drawing.Point(653, 70);
            this.outputFolderBrowse.Name = "outputFolderBrowse";
            this.outputFolderBrowse.Size = new System.Drawing.Size(37, 23);
            this.outputFolderBrowse.TabIndex = 5;
            this.outputFolderBrowse.Text = "...";
            this.outputFolderBrowse.UseVisualStyleBackColor = true;
            this.outputFolderBrowse.Click += new System.EventHandler(this.outputFolderBrowse_Click);
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(615, 151);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // filesFoundLabel
            // 
            this.filesFoundLabel.AutoSize = true;
            this.filesFoundLabel.Location = new System.Drawing.Point(140, 118);
            this.filesFoundLabel.Name = "filesFoundLabel";
            this.filesFoundLabel.Size = new System.Drawing.Size(375, 17);
            this.filesFoundLabel.TabIndex = 7;
            this.filesFoundLabel.Text = "Please select the folder containing the .br* files to convert.";
            // 
            // finishButton
            // 
            this.finishButton.Enabled = false;
            this.finishButton.Location = new System.Drawing.Point(615, 183);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 8;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // conversionProgressBar
            // 
            this.conversionProgressBar.Location = new System.Drawing.Point(143, 112);
            this.conversionProgressBar.Name = "conversionProgressBar";
            this.conversionProgressBar.Size = new System.Drawing.Size(504, 23);
            this.conversionProgressBar.TabIndex = 9;
            this.conversionProgressBar.Visible = false;
            // 
            // convertedSongLabel
            // 
            this.convertedSongLabel.AutoSize = true;
            this.convertedSongLabel.Location = new System.Drawing.Point(143, 151);
            this.convertedSongLabel.MaximumSize = new System.Drawing.Size(504, 0);
            this.convertedSongLabel.Name = "convertedSongLabel";
            this.convertedSongLabel.Size = new System.Drawing.Size(104, 17);
            this.convertedSongLabel.TabIndex = 10;
            this.convertedSongLabel.Text = "convertedSong";
            this.convertedSongLabel.Visible = false;
            // 
            // openOutputOnExit
            // 
            this.openOutputOnExit.AutoSize = true;
            this.openOutputOnExit.Location = new System.Drawing.Point(143, 183);
            this.openOutputOnExit.Name = "openOutputOnExit";
            this.openOutputOnExit.Size = new System.Drawing.Size(194, 21);
            this.openOutputOnExit.TabIndex = 11;
            this.openOutputOnExit.Text = "Open output folder on exit";
            this.openOutputOnExit.UseVisualStyleBackColor = true;
            this.openOutputOnExit.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(534, 183);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 183);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openOutputOnExit);
            this.Controls.Add(this.convertedSongLabel);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.filesFoundLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputFolderBrowse);
            this.Controls.Add(this.outputFolderPath);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.inputFolderBrowse);
            this.Controls.Add(this.inputFolderPath);
            this.Controls.Add(this.inputFolderLabel);
            this.Controls.Add(this.conversionProgressBar);
            this.Name = "App";
            this.Text = "BRX Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.TextBox inputFolderPath;
        private System.Windows.Forms.FolderBrowserDialog inputFolderDialog;
        private System.Windows.Forms.Button inputFolderBrowse;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TextBox outputFolderPath;
        private System.Windows.Forms.Button outputFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label filesFoundLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.ProgressBar conversionProgressBar;
        private System.Windows.Forms.Label convertedSongLabel;
        private System.Windows.Forms.CheckBox openOutputOnExit;
        private System.Windows.Forms.Button cancelButton;
    }
}

