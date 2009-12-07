using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace ImageClassify
{


    partial class Image_label
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image_label));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.porn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.srcdir = new System.Windows.Forms.FolderBrowserDialog();
            this.src = new System.Windows.Forms.Button();
            this.porn_folder = new System.Windows.Forms.Button();
            this.notporn_folder = new System.Windows.Forms.Button();
            this.porndir = new System.Windows.Forms.FolderBrowserDialog();
            this.notporn = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 642);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // porn
            // 
            this.porn.Location = new System.Drawing.Point(472, 29);
            this.porn.Name = "porn";
            this.porn.Size = new System.Drawing.Size(75, 23);
            this.porn.TabIndex = 1;
            this.porn.Text = "LOAD IMAGES";
            this.porn.UseVisualStyleBackColor = true;
            this.porn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "PORN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "NOT PORN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // srcdir
            // 
            this.srcdir.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(553, 29);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(58, 23);
            this.src.TabIndex = 4;
            this.src.Text = "srcdir";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.button3_Click);
            // 
            // porn_folder
            // 
            this.porn_folder.Location = new System.Drawing.Point(555, 83);
            this.porn_folder.Name = "porn_folder";
            this.porn_folder.Size = new System.Drawing.Size(56, 23);
            this.porn_folder.TabIndex = 5;
            this.porn_folder.Text = "porn_dir";
            this.porn_folder.UseVisualStyleBackColor = true;
            this.porn_folder.Click += new System.EventHandler(this.button4_Click);
            // 
            // notporn_folder
            // 
            this.notporn_folder.Location = new System.Drawing.Point(553, 148);
            this.notporn_folder.Name = "notporn_folder";
            this.notporn_folder.Size = new System.Drawing.Size(58, 23);
            this.notporn_folder.TabIndex = 6;
            this.notporn_folder.Text = "not_porn_dir";
            this.notporn_folder.UseVisualStyleBackColor = true;
            this.notporn_folder.Click += new System.EventHandler(this.button5_Click);
            // 
            // Image_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 511);
            this.Controls.Add(this.notporn_folder);
            this.Controls.Add(this.porn_folder);
            this.Controls.Add(this.src);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.porn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Image_label";
            this.Text = "Image Labeller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button porn;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog srcdir;
        private Button src;
        private Button porn_folder;
        private Button notporn_folder;
        private FolderBrowserDialog porndir;
        private FolderBrowserDialog notporn;
    }
}

