using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace brx_converter_wfa.Controllers
{
    public class Converter
    {
        private List<string> _filesToConvert;
        private App _app;
        private bool _canceled;

        public List<string> FilesToConvert
        {
            private set => _filesToConvert = value;
            get => _filesToConvert;
        }

        public Converter(App app)
        {
            _app = app;
            FilesToConvert = new List<string>();
            _canceled = false;
        }

        public void UpdateFilesList(string folder)
        {
            FilesToConvert.Clear();
            PopulateFilesList(folder);
        }

        private void PopulateFilesList(string folder)
        {
            string[] subfolders = Directory.GetDirectories(folder);
            foreach (string sub in subfolders)
            {
                PopulateFilesList(sub);
            }

            foreach (string file in Directory.GetFiles(folder))
            {
                if (file.EndsWith(".BR4") || file.EndsWith(".BR5"))
                {
                    FilesToConvert.Add(file);
                }
            }
        }

        public async Task ConvertAll(string inputFolder, string outputFolder)
        {
            await Task.Run(() =>
            {
                foreach (string file in FilesToConvert.TakeWhile(x => !_canceled))
                {
                    _app.UpdateProgressBar(FilesToConvert.IndexOf(file) + 1);
                    _app.UpdateConvertedSongLabel("Converting " + MakeRelativePath(inputFolder, file));
                    byte[] bytes = System.IO.File.ReadAllBytes(file);
                    byte[] reversed = InvertBytesArray(bytes);
                    string outputPath = outputFolder + "\\" + MakeRelativePath(inputFolder, file);
                    outputPath = Path.ChangeExtension(outputPath, ".mp3");
                    string outputPathFolder = Path.GetDirectoryName(outputPath);
                    if (!Directory.Exists(outputPathFolder))
                    {
                        Directory.CreateDirectory(outputPathFolder);
                    }
                    System.IO.File.WriteAllBytes(outputPath, reversed);
                }
            });
        }

        public void CancelConversion()
        {
            if(!_canceled)
            {
                _canceled = true;
            }
        }

        private byte[] InvertBytesArray(byte[] bytes)
        {
            List<byte> reversed = new List<byte>();
            foreach (byte @byte in bytes)
            {
                byte reversedByte = @byte;
                reversedByte ^= byte.MaxValue;
                reversed.Add(reversedByte);
            }
            return reversed.ToArray();
        }

        //Method source : https://stackoverflow.com/a/340454
        /// <summary>
        /// Creates a relative path from one file or folder to another.
        /// </summary>
        /// <param name="fromPath">Contains the directory that defines the start of the relative path.</param>
        /// <param name="toPath">Contains the path that defines the endpoint of the relative path.</param>
        /// <returns>The relative path from the start directory to the end path or <c>toPath</c> if the paths are not related.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="UriFormatException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        private static String MakeRelativePath(String fromPath, String toPath)
        {
            if (String.IsNullOrEmpty(fromPath)) throw new ArgumentNullException("fromPath");
            if (String.IsNullOrEmpty(toPath)) throw new ArgumentNullException("toPath");

            Uri fromUri = new Uri(fromPath);
            Uri toUri = new Uri(toPath);

            if (fromUri.Scheme != toUri.Scheme) { return toPath; } // path can't be made relative.

            Uri relativeUri = fromUri.MakeRelativeUri(toUri);
            String relativePath = Uri.UnescapeDataString(relativeUri.ToString());

            if (toUri.Scheme.Equals("file", StringComparison.InvariantCultureIgnoreCase))
            {
                relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            }

            return relativePath;
        }
    }
}
