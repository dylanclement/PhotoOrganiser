using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoOrganiser
{
    public partial class MainForm : Form
    {
        public class ListEntry
        {
            [DisplayName("File Name")]
            public string FileName { get; set; }
            [DisplayName("Destination")]
            public string Destination { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private IList<ListEntry> filesToCopy = new List<ListEntry>();
        private static Regex r = new Regex(":");

        //retrieves the datetime WITHOUT loading the whole image
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                if (myImage.PropertyIdList.Any(x => x == 36867))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    return DateTime.Parse(dateTaken);
                } 
                else
                {
                    MessageBox.Show("Unable to find date data for image " + path + " : " + GetDateTakenFromFile(path));
                    return GetDateTakenFromFile(path);
                }
            }
        }

        public static DateTime GetDateTakenFromFile(string path)
        {
            return File.GetLastWriteTime(path);
        }


        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            if (sourceFolderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {
                sourceFolderText.Text = sourceFolderBrowserDialog.SelectedPath;
            }
        }

        private void destinationBrowseButton_Click(object sender, EventArgs e)
        {
            if (destinationFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                destinationFolderText.Text = destinationFolderBrowserDialog.SelectedPath;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            filesToCopy.Clear();
            ProcessDirectory(sourceFolderText.Text, destinationFolderText.Text);
            resultGridView.DataSource = filesToCopy.ToArray();
            CopyFiles(filesToCopy);
        }


        private void CopyFiles(IList<ListEntry> items)
        {
            foreach (var item in items)
            {
                var fi = new FileInfo(item.FileName);
                Directory.CreateDirectory(Path.GetDirectoryName(item.Destination));
                try
                {
                    fi.CopyTo(item.Destination);
                }
                catch (System.IO.IOException)
                {
                    // File Already exists, ignore
                }
            }
        }

        // Process all files in the directory passed in, recurse on any directories  
        // that are found, and process the files they contain. 
        public void ProcessDirectory(string targetDirectory, string destinationDirectory)
        {
            if (!Directory.Exists(targetDirectory) || !Directory.Exists(destinationDirectory))
            {
                MessageBox.Show("Invalid directory");
                return;
            }
            // Process the list of files found in the directory. 
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory, destinationDirectory);
        }

        private string GetDestinationName(string path, string file, DateTime date)
        {
            return string.Format("{0}\\{1}-{2}-{3}\\{4}", path, date.Year, date.Month.ToString().PadLeft(2, '0'), date.Day.ToString().PadLeft(2, '0' ), Path.GetFileName(file));
        }

        // Insert logic for processing found files here. 
        public void ProcessFile(string path)
        {
            var extension = Path.GetExtension(path).ToLower();
            if (extension == ".jpg")
            {
                filesToCopy.Add(new ListEntry { FileName = path, Destination = GetDestinationName(destinationFolderText.Text, path, GetDateTakenFromImage(path)) });
            }
            else if (extension == ".mpg" || extension == ".mp4" || extension == ".mov")
            {
                filesToCopy.Add(new ListEntry { FileName = path, Destination = GetDestinationName(destinationFolderText.Text, path, GetDateTakenFromFile(path)) });
            }
        }
    }
}
