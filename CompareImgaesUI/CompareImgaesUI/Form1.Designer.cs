namespace CompareImgaesUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeFolder = new System.Windows.Forms.ListBox();
            this.Subfolder = new System.Windows.Forms.ListBox();
            this.button21 = new System.Windows.Forms.Button();
            this.imgFileList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeFolder2 = new System.Windows.Forms.ListBox();
            this.Subfolder2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imgFileList2 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.theSamePart = new System.Windows.Forms.ListBox();
            this.theSamePart2 = new System.Windows.Forms.ListBox();
            this.DifferentPart = new System.Windows.Forms.ListBox();
            this.Different2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel_Picture = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_Picture.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeFolder
            // 
            this.HomeFolder.FormattingEnabled = true;
            this.HomeFolder.HorizontalScrollbar = true;
            this.HomeFolder.ItemHeight = 12;
            this.HomeFolder.Location = new System.Drawing.Point(2, 45);
            this.HomeFolder.Name = "HomeFolder";
            this.HomeFolder.ScrollAlwaysVisible = true;
            this.HomeFolder.Size = new System.Drawing.Size(560, 64);
            this.HomeFolder.TabIndex = 50;
            this.HomeFolder.SelectedIndexChanged += new System.EventHandler(this.HomeFolder_SelectedIndexChanged);
            // 
            // Subfolder
            // 
            this.Subfolder.FormattingEnabled = true;
            this.Subfolder.HorizontalScrollbar = true;
            this.Subfolder.ItemHeight = 12;
            this.Subfolder.Location = new System.Drawing.Point(2, 119);
            this.Subfolder.Name = "Subfolder";
            this.Subfolder.ScrollAlwaysVisible = true;
            this.Subfolder.Size = new System.Drawing.Size(119, 160);
            this.Subfolder.TabIndex = 48;
            this.Subfolder.SelectedIndexChanged += new System.EventHandler(this.Subfolder_SelectedIndexChanged);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(12, 16);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 23);
            this.button21.TabIndex = 47;
            this.button21.Text = "瀏覽";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // imgFileList
            // 
            this.imgFileList.FormattingEnabled = true;
            this.imgFileList.HorizontalScrollbar = true;
            this.imgFileList.ItemHeight = 12;
            this.imgFileList.Location = new System.Drawing.Point(2, 285);
            this.imgFileList.Name = "imgFileList";
            this.imgFileList.ScrollAlwaysVisible = true;
            this.imgFileList.Size = new System.Drawing.Size(119, 448);
            this.imgFileList.TabIndex = 49;
            this.imgFileList.SelectedIndexChanged += new System.EventHandler(this.imgFileList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 615);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // HomeFolder2
            // 
            this.HomeFolder2.FormattingEnabled = true;
            this.HomeFolder2.HorizontalScrollbar = true;
            this.HomeFolder2.ItemHeight = 12;
            this.HomeFolder2.Location = new System.Drawing.Point(884, 45);
            this.HomeFolder2.Name = "HomeFolder2";
            this.HomeFolder2.ScrollAlwaysVisible = true;
            this.HomeFolder2.Size = new System.Drawing.Size(566, 64);
            this.HomeFolder2.TabIndex = 55;
            this.HomeFolder2.SelectedIndexChanged += new System.EventHandler(this.HomeFolder2_SelectedIndexChanged);
            // 
            // Subfolder2
            // 
            this.Subfolder2.FormattingEnabled = true;
            this.Subfolder2.HorizontalScrollbar = true;
            this.Subfolder2.ItemHeight = 12;
            this.Subfolder2.Location = new System.Drawing.Point(884, 115);
            this.Subfolder2.Name = "Subfolder2";
            this.Subfolder2.ScrollAlwaysVisible = true;
            this.Subfolder2.Size = new System.Drawing.Size(134, 160);
            this.Subfolder2.TabIndex = 53;
            this.Subfolder2.SelectedIndexChanged += new System.EventHandler(this.Subfolder2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "瀏覽";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgFileList2
            // 
            this.imgFileList2.FormattingEnabled = true;
            this.imgFileList2.HorizontalScrollbar = true;
            this.imgFileList2.ItemHeight = 12;
            this.imgFileList2.Location = new System.Drawing.Point(884, 281);
            this.imgFileList2.Name = "imgFileList2";
            this.imgFileList2.ScrollAlwaysVisible = true;
            this.imgFileList2.Size = new System.Drawing.Size(131, 460);
            this.imgFileList2.TabIndex = 54;
            this.imgFileList2.SelectedIndexChanged += new System.EventHandler(this.imgFileList2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(744, 615);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            this.pictureBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseWheel);
            // 
            // theSamePart
            // 
            this.theSamePart.FormattingEnabled = true;
            this.theSamePart.HorizontalScrollbar = true;
            this.theSamePart.ItemHeight = 12;
            this.theSamePart.Location = new System.Drawing.Point(17, 766);
            this.theSamePart.Name = "theSamePart";
            this.theSamePart.ScrollAlwaysVisible = true;
            this.theSamePart.Size = new System.Drawing.Size(395, 232);
            this.theSamePart.TabIndex = 57;
            this.theSamePart.SelectedIndexChanged += new System.EventHandler(this.theSamePart_SelectedIndexChanged);
            this.theSamePart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.theSamePart_MouseDoubleClick);
            // 
            // theSamePart2
            // 
            this.theSamePart2.FormattingEnabled = true;
            this.theSamePart2.HorizontalScrollbar = true;
            this.theSamePart2.ItemHeight = 12;
            this.theSamePart2.Location = new System.Drawing.Point(911, 766);
            this.theSamePart2.Name = "theSamePart2";
            this.theSamePart2.ScrollAlwaysVisible = true;
            this.theSamePart2.Size = new System.Drawing.Size(426, 232);
            this.theSamePart2.TabIndex = 58;
            this.theSamePart2.SelectedIndexChanged += new System.EventHandler(this.theSamePart2_SelectedIndexChanged);
            this.theSamePart2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.theSamePart2_MouseDoubleClick);
            // 
            // DifferentPart
            // 
            this.DifferentPart.FormattingEnabled = true;
            this.DifferentPart.HorizontalScrollbar = true;
            this.DifferentPart.ItemHeight = 12;
            this.DifferentPart.Location = new System.Drawing.Point(430, 766);
            this.DifferentPart.Name = "DifferentPart";
            this.DifferentPart.ScrollAlwaysVisible = true;
            this.DifferentPart.Size = new System.Drawing.Size(418, 232);
            this.DifferentPart.TabIndex = 59;
            this.DifferentPart.SelectedIndexChanged += new System.EventHandler(this.DifferentPart_SelectedIndexChanged);
            this.DifferentPart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DifferentPart_MouseDoubleClick);
            // 
            // Different2
            // 
            this.Different2.FormattingEnabled = true;
            this.Different2.HorizontalScrollbar = true;
            this.Different2.ItemHeight = 12;
            this.Different2.Location = new System.Drawing.Point(1343, 766);
            this.Different2.Name = "Different2";
            this.Different2.ScrollAlwaysVisible = true;
            this.Different2.Size = new System.Drawing.Size(419, 232);
            this.Different2.TabIndex = 60;
            this.Different2.SelectedIndexChanged += new System.EventHandler(this.Different2_SelectedIndexChanged);
            this.Different2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Different2_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(852, 767);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 96);
            this.button2.TabIndex = 61;
            this.button2.Text = "比較";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 745);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 751);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1250, 751);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1677, 751);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "E:\\01_imageSet";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(935, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(412, 22);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = "E:\\01_imageSet";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 740);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 68;
            this.button3.Text = "copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(797, 740);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 69;
            this.button4.Text = "copy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1289, 740);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 23);
            this.button5.TabIndex = 70;
            this.button5.Text = "copy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1716, 742);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 23);
            this.button6.TabIndex = 71;
            this.button6.Text = "copy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel_Picture
            // 
            this.panel_Picture.Controls.Add(this.pictureBox1);
            this.panel_Picture.Location = new System.Drawing.Point(124, 116);
            this.panel_Picture.Name = "panel_Picture";
            this.panel_Picture.Size = new System.Drawing.Size(754, 619);
            this.panel_Picture.TabIndex = 72;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1021, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 621);
            this.panel2.TabIndex = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 1012);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Different2);
            this.Controls.Add(this.DifferentPart);
            this.Controls.Add(this.theSamePart2);
            this.Controls.Add(this.theSamePart);
            this.Controls.Add(this.HomeFolder2);
            this.Controls.Add(this.Subfolder2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgFileList2);
            this.Controls.Add(this.HomeFolder);
            this.Controls.Add(this.Subfolder);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.imgFileList);
            this.Controls.Add(this.panel_Picture);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompareImages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_Picture.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HomeFolder;
        private System.Windows.Forms.ListBox Subfolder;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.ListBox imgFileList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox HomeFolder2;
        private System.Windows.Forms.ListBox Subfolder2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox imgFileList2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox theSamePart;
        private System.Windows.Forms.ListBox theSamePart2;
        private System.Windows.Forms.ListBox DifferentPart;
        private System.Windows.Forms.ListBox Different2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel_Picture;
        private System.Windows.Forms.Panel panel2;
    }
}

