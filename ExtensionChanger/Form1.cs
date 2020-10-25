using System;
using System.IO;
using System.Windows.Forms;

namespace HTML2PHP
{
    public partial class ExtensionChanger_form : Form
    {
        private int fileNumber = 0;
        private string directoryPath;

        public ExtensionChanger_form()
        {
            InitializeComponent();
        }


        private void select_html_folder_btn_Click(object sender, EventArgs e)
        {
            string currentExt = currentExtension.Text;
            string newExt = newExtension.Text;
            if (currentExt == "" && newExt == "")
            {
                MessageBox.Show("You must specify both the current extension and the desired new extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (currentExt == "")
            {
                MessageBox.Show("You must specify the current extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (newExt == "")
            {
                MessageBox.Show("You must specify the desired new extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.fileNumber = 0;
                this.directoryPath = folderDlg.SelectedPath;
                foreach (string file in Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories))
                {
                    if (file.EndsWith("."+currentExt))
                    {
                        this.fileNumber++;
                    }
                }
                html_files_lbl.Text = "Loaded " + fileNumber + " " + currentExt + " files";
            }
        }

        private void convert_to_php_btn_Click(object sender, EventArgs e)
        {
            string currentExt = currentExtension.Text;
            string newExt = newExtension.Text;
            if (directoryPath == null)
            {
                MessageBox.Show("Invalid directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (fileNumber == 0)
            {
                MessageBox.Show("No files with " + currentExt + " extension found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string file in Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories))
            {
                if (file.EndsWith("."+currentExt))
                {
                    File.Move(file, Path.ChangeExtension(file, "."+newExt));
                }
            }
            //MessageBox.Show("Successfully replaced " + fileNumber + " files from " + currentExt + " to " + newExt, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            html_files_lbl.Text = "Successfully replaced " + fileNumber + " files\nfrom " + currentExt + " to " + newExt;
            reset();
        }

        private void reset()
        {
            directoryPath = null;
            currentExtension.Text = "";
            newExtension.Text = "";
            fileNumber = 0;
        }
    }
}
