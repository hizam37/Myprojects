﻿namespace XML_GUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.name_of_xml_first_file = new System.Windows.Forms.TextBox();
            this.name_of_xml_second_file = new System.Windows.Forms.TextBox();
            this.name_of_tag_of_first_xml_file = new System.Windows.Forms.TextBox();
            this.name_of_tag_of_second_xml_file = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сравнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_of_xml_first_file
            // 
            this.name_of_xml_first_file.Location = new System.Drawing.Point(189, 126);
            this.name_of_xml_first_file.Multiline = true;
            this.name_of_xml_first_file.Name = "name_of_xml_first_file";
            this.name_of_xml_first_file.Size = new System.Drawing.Size(189, 51);
            this.name_of_xml_first_file.TabIndex = 1;
            this.name_of_xml_first_file.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_of_xml_second_file
            // 
            this.name_of_xml_second_file.Location = new System.Drawing.Point(701, 123);
            this.name_of_xml_second_file.Multiline = true;
            this.name_of_xml_second_file.Name = "name_of_xml_second_file";
            this.name_of_xml_second_file.Size = new System.Drawing.Size(189, 51);
            this.name_of_xml_second_file.TabIndex = 2;
            this.name_of_xml_second_file.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name_of_tag_of_first_xml_file
            // 
            this.name_of_tag_of_first_xml_file.Location = new System.Drawing.Point(189, 243);
            this.name_of_tag_of_first_xml_file.Multiline = true;
            this.name_of_tag_of_first_xml_file.Name = "name_of_tag_of_first_xml_file";
            this.name_of_tag_of_first_xml_file.Size = new System.Drawing.Size(189, 42);
            this.name_of_tag_of_first_xml_file.TabIndex = 3;
            this.name_of_tag_of_first_xml_file.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // name_of_tag_of_second_xml_file
            // 
            this.name_of_tag_of_second_xml_file.Location = new System.Drawing.Point(701, 240);
            this.name_of_tag_of_second_xml_file.Multiline = true;
            this.name_of_tag_of_second_xml_file.Name = "name_of_tag_of_second_xml_file";
            this.name_of_tag_of_second_xml_file.Size = new System.Drawing.Size(189, 42);
            this.name_of_tag_of_second_xml_file.TabIndex = 4;
            this.name_of_tag_of_second_xml_file.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"Названия xml файл\".xml";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "\"Названия xml файл\".xml";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Названия тег";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Названия тег";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(533, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 148);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 509);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_of_tag_of_second_xml_file);
            this.Controls.Add(this.name_of_tag_of_first_xml_file);
            this.Controls.Add(this.name_of_xml_second_file);
            this.Controls.Add(this.name_of_xml_first_file);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_of_xml_first_file;
        private System.Windows.Forms.TextBox name_of_xml_second_file;
        private System.Windows.Forms.TextBox name_of_tag_of_first_xml_file;
        private System.Windows.Forms.TextBox name_of_tag_of_second_xml_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

