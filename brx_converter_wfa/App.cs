using brx_converter_wfa.Controllers;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace brx_converter_wfa
{
    public partial class App : Form
    {
        private string _inputFolder;
        private string _outputFolder;
        private int _nbFilesFound;
        private bool _canceled;
        private Converter _converter;

        private delegate void IntArgReturningVoidDelegate(int value);
        private delegate void StringArgReturningVoidDelegate(string text);

        public App()
        {
            InitializeComponent();
            _converter = new Converter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputFolderBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = inputFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _inputFolder = inputFolderDialog.SelectedPath;
                _converter.UpdateFilesList(_inputFolder);
                inputFolderPath.Text = _inputFolder;
                _nbFilesFound = _converter.FilesToConvert.Count;
                filesFoundLabel.Text = "Found " + _nbFilesFound + " file(s) to convert.";
                convertButton.Enabled = CanConvert();
            }
        }

        private void outputFolderBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _outputFolder = outputFolderDialog.SelectedPath;
                outputFolderPath.Text = _outputFolder;
                convertButton.Enabled = CanConvert();
            }
        }


        private async void convertButton_Click(object sender, EventArgs e)
        {
            if(CanConvert())
            {
                Height = 218;
                inputFolderBrowse.Enabled = false;
                outputFolderBrowse.Enabled = false;
                convertButton.Visible = false;
                filesFoundLabel.Visible = false;

                conversionProgressBar.Maximum = _nbFilesFound;
                conversionProgressBar.Visible = true;
                conversionProgressBar.Refresh();

                convertedSongLabel.Visible = true;
                convertedSongLabel.Refresh();

                finishButton.Visible = true;
                finishButton.Refresh();

                cancelButton.Visible = true;
                cancelButton.Refresh();

                await _converter.ConvertAll(_inputFolder, _outputFolder);

                if(_canceled)
                {
                    convertedSongLabel.Text = "Conversion canceled";
                    conversionProgressBar.SetState(2);
                    UpdateProgressBar(_nbFilesFound);
                }
                else
                {
                    convertedSongLabel.Text = "Conversion completed";
                }
                openOutputOnExit.Visible = true;
                finishButton.Enabled = true;
                cancelButton.Visible = false;
            }
        }

        private bool CanConvert()
        {
            return (Directory.Exists(_inputFolder) &&
                    Directory.Exists(_outputFolder) &&
                    _nbFilesFound > 0);
        }

        public void UpdateProgressBar(int value)
        {
            if (conversionProgressBar.InvokeRequired)
            {
                IntArgReturningVoidDelegate d = new IntArgReturningVoidDelegate(UpdateProgressBar);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                conversionProgressBar.Value = value;
                conversionProgressBar.Refresh();
            }
        }

        public void UpdateConvertedSongLabel(string text)
        {
            if (convertedSongLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(UpdateConvertedSongLabel);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                convertedSongLabel.Text = text;
                convertedSongLabel.Refresh();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (openOutputOnExit.Checked)
                Process.Start(_outputFolder);
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _converter.CancelConversion();
            _canceled = true;
        }
    }

    //Method source : https://stackoverflow.com/a/9753302
    // Used to change progress bar color
    // States => 1 (Green), 2 (Red), 3 (Yellow)
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
