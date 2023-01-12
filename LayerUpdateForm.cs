using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCadProgrammingDemo
{
    public partial class LayerUpdateForm : Form
    {
        public LayerUpdateForm()
        {
            InitializeComponent();
        }

        private void LayerUpdateForm_Load(object sender, EventArgs e)
        {
            BrowseFileFromPath(txtPath.Text.Trim());
        }

        private void BrowseFileFromPath(String Path)
        {
            try
            {
                using (var browseFolder = new FolderBrowserDialog())
                {
                    browseFolder.SelectedPath = Path;
                    var allFile = Directory.GetFiles(browseFolder.SelectedPath, "*.dwg");
                    listFile.DataSource = allFile;
                    infoLabel.Text = "Total number of selected file= " + allFile.Length;
                }
            } catch (System.Exception exception)
            {
                
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var browseDialog = new FolderBrowserDialog())
            {
                var result = browseDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browseDialog.SelectedPath)) {
                    BrowseFileFromPath(browseDialog.SelectedPath);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 1;

            int totalCountFile = listFile.Items.Count;

            foreach (string file in listFile.Items)
            {
                
                infoLabel.Text = "Processing " + i.ToString() + "/" + totalCountFile.ToString();
                infoLabel.ForeColor = Color.Green;
                UpdateLayerUtil.drawCircle(file);
                i += 1;
            }
            infoLabel.Text = "Successfully";
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oldLayerLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
