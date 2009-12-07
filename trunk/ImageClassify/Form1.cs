using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace ImageClassify
{    
    public partial class Image_label : Form
    {
        private int counter;
        private string source_path = "C:/porn/";
        private string destination_porn = "C:/porn/";
        private string destination_not_porn= "C:/notporn/";
        private System.Collections.IList iconFiles;
        public Image_label()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            iconFiles = Directory.GetFiles(source_path, "*.jpg");

            foreach (string iconFile in iconFiles)
            {
                //Icon newIcon = new Icon(iconFile);
                //Console.WriteLine(iconFile);
               //iconImages.Add("iconFile");
            }
            //pictureBox1.Image = Image.FromFile((string)iconImages[2]);
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Console.WriteLine(iconFiles.Count);
            //Console.WriteLine(iconFiles[2]);
            //Console.WriteLine(pictureBox1.Image);
            try
            {
                string[] filename = Regex.Split(((string)iconFiles[counter]), "/");
                string destination_porn_save = @destination_porn + filename[filename.Count() - 1];
                
                //Console.WriteLine(filename[filename.Count() - 1]);
                pictureBox1.Image.Save(destination_porn_save);
                pictureBox1.Image = Image.FromFile((string)iconFiles[counter]);
                counter += 1;
            }
            catch {

                MessageBox.Show("Image finished");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] filename = Regex.Split(((string)iconFiles[counter]), "/");
                string destination_not_porn_save = @destination_not_porn + filename[filename.Count() - 1];

                pictureBox1.Image.Save(destination_not_porn_save);
                
                pictureBox1.Image = Image.FromFile((string)iconFiles[counter]);
                counter += 1;
            }
            catch
            {

                MessageBox.Show("finished");
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            srcdir.ShowDialog();
            source_path = srcdir.SelectedPath + '/';
            MessageBox.Show(source_path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            porndir.ShowDialog();
            destination_porn = porndir.SelectedPath + '/';
            MessageBox.Show(destination_porn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notporn.ShowDialog();
            destination_not_porn = notporn.SelectedPath+ '/';
            MessageBox.Show(destination_not_porn);
        }

       
    }
}

