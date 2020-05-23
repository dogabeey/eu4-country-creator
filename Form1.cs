using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Country_Creator
{
    public partial class Form1 : Form
    {
        FileOrganizer organizer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(File.ReadAllText(openFile.FileName), "^path=\".+?\"", RegexOptions.Multiline))
            {
                string modPath = Regex.Match(File.ReadAllText(openFile.FileName), "^path=\"(.+?)\"", RegexOptions.Multiline).Groups[1].Value;
                organizer = new FileOrganizer(new FileInfo(openFile.FileName).Directory.FullName.Replace("mod", "").Replace("/",@"\") + modPath + @"\");
                path.Text = new FileInfo(openFile.FileName).Directory.FullName.Replace("mod", "") + modPath;
                groupBox1.Enabled = true;
            }
            else MessageBox.Show("Error finding the mod path. Make sure the file you selected contains 'path=' line.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void countryTag_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void countryTag_TextChanged_1(object sender, EventArgs e)
        {
            if (Regex.IsMatch(countryTag.Text, "^([A-Z][A-Z][A-Z])|([A-Z][A-Z][0-9])|([A-Z][0-9][0-9])$"))
            {
                if (organizer.GetTags().Contains(countryTag.Text))
                {
                    tagError.Text = "Tag already exists";
                    countryTag.BackColor = Color.Orange;
                    tagError.ForeColor = Color.Orange;
                }
                else
                {
                    countryTag.BackColor = Color.White;
                    tagError.Text = "";
                }
            }
            else
            {
                tagError.Text = "Wrong Tag Format";
                tagError.ForeColor = Color.Red;
                countryTag.BackColor = Color.Red;
            }
        }

        private void countryName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(countryName.Text, @"^[^.,`;:\\\/?*|<>]+$"))
            {
                if (organizer.GetNames().Contains(countryName.Text))
                {
                    cntError.Text = "Country already exists";
                    countryName.BackColor = Color.Orange;
                    cntError.ForeColor = Color.Orange;
                }
                else
                {
                    countryName.BackColor = Color.White;
                    cntError.Text = "";
                }
            }
            else
            {
                cntError.Text = "Wrong Filename Format";
                cntError.ForeColor = Color.Red;
                countryName.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            organizer.WriteToTag(countryTag.Text, countryName.Text);
            organizer.WriteToLocalisation(countryTag.Text, countryName.Text);
            organizer.WriteToHistory(countryTag.Text, countryName.Text, historyContent.Text);
            organizer.WriteToCountry(countryTag.Text, countryName.Text, countryContent.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class FileOrganizer
    {
        string modPath, countryTagFolder, countriesFolder, countryHistoryFolder,localisationFile;

        public FileOrganizer(string modPath = @"C:\Users\dogac\OneDrive\Belgeler\Paradox Interactive\Europa Universalis IV\mod\WWU\", string countryTagFolder = @"common\country_tags\", string countriesFolder = @"common\countries\", string countryHistoryFolder = @"history\countries\", string localisationFile = @"localisation\prov_names_l_english.yml")
        {
            this.modPath = modPath;
            this.countryTagFolder = countryTagFolder;
            this.countriesFolder = countriesFolder;
            this.countryHistoryFolder = countryHistoryFolder;
            this.localisationFile = localisationFile;
        }

        public List<string> GetTags()
        {
            List<string> retVal = new List<string>();
            string[] files = Directory.GetFiles(modPath + countryHistoryFolder, "*.txt");
            foreach (string file in files)
            {
                string fileWithoutDir;
                ;
                retVal.Add(fileWithoutDir = Path.GetFileName(file).Substring(0, 3));
            }
            return retVal;
        }
        public List<string> GetNames()
        {
            List<string> retVal = new List<string>();
            string[] files = Directory.GetFiles(modPath + countryHistoryFolder, "*.txt");
            foreach (string file in files)
            {
                string fileWithoutDir;
                string[] str = { " - " };
                retVal.Add(fileWithoutDir = Path.GetFileNameWithoutExtension(file).Split(str, StringSplitOptions.None)[1]);
            }
            return retVal;
        }

        public void WriteToTag(string tag, string countryName)
        {
            string[] files = Directory.GetFiles(modPath + countryTagFolder);
            File.AppendAllText(files[0], "\n" + tag + " = \"countries/" + countryName + ".txt\"");
        }
        public void WriteToHistory(string tag, string countryName, string contents)
        {
            File.AppendAllText(modPath + countryHistoryFolder + tag + " - " + countryName + ".txt", contents);
        }
        public void WriteToCountry(string tag, string countryName, string contents)
        {
            File.AppendAllText(modPath + countriesFolder + countryName + ".txt", contents);
        }
        public void WriteToLocalisation(string tag, string countryName)
        {
            File.AppendAllText(modPath + localisationFile, "\n " + tag + ": \"" + countryName + "\"");
            string[] str = { " - " };
            File.AppendAllText(modPath + localisationFile, "\n " + tag + "_ADJ: \"" + countryName.Split(str,StringSplitOptions.None)[0] + "\"");
        }
    }

}
