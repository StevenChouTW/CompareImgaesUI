using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareImgaesUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string RootDir = "";

        private void button21_Click(object sender, EventArgs e)
        {
            HomeFolder.Items.Clear();

            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "請選擇資料夾";

            //dilog.SelectedPath = @"X:\uScan\00_資料收集\02_測試影像\20181213_挑選高榮2018年1+trace照片\";

            //dilog.SelectedPath = @"C:\Users\Steven\Desktop\FourClassWrongRect\1\2\3\4\yoloResult\";
            //dilog.SelectedPath = @"F:\01_imageSet\";
            dilog.SelectedPath = textBox1.Text;

            if (dilog.ShowDialog() == DialogResult.OK)
            {
                RootDir = dilog.SelectedPath;
            }
            else
            {
                return;
            }

            RootDir = dilog.SelectedPath;

            string[] dirs = Directory.GetDirectories(RootDir);
            foreach (string dir in dirs)
            {
                HomeFolder.Items.Add(dir);

            }
            if (HomeFolder.Items.Count > 0)
            {
                HomeFolder.SelectedIndex = 0;
            }


        }

        private void HomeFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            //dataGridView4.Rows.Clear();


            string filepath = "";
            if (HomeFolder.SelectedIndex < 0)
            { MessageBox.Show("dirList has no item"); }

            filepath = HomeFolder.Items[HomeFolder.SelectedIndex].ToString();
            if (filepath == "")
            { return; }
            // 取得資料夾內所有檔案
            Subfolder.Items.Clear();


            foreach (string fname in System.IO.Directory.GetDirectories(filepath))
            {
                Subfolder.Items.Add(fname);
            }
            if (Subfolder.Items.Count > 0)
            {
                Subfolder.SelectedIndex = 0;
            }
        }

        private void Subfolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }


            string filepath = "";
            if (Subfolder.SelectedIndex < 0)
            { MessageBox.Show("myList2 has no item"); }

            filepath = Subfolder.Items[Subfolder.SelectedIndex].ToString();
            if (filepath == "")
            { return; }
            // 取得資料夾內所有檔案
            imgFileList.Items.Clear();


            foreach (string fname in System.IO.Directory.GetFileSystemEntries(filepath))
            {
                if (File.Exists(fname))
                {

                    if (fname.ToLower().Contains(".bmp") || fname.ToLower().Contains(".jpg"))
                    {

                        imgFileList.Items.Add(fname);
                    }
                }

            }
            if (imgFileList.Items.Count > 0)
            {
                imgFileList.SelectedIndex = 0;
            }
        }

        private void imgFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PaintRec(true);
            if (imgFileList.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(imgFileList.SelectedItem.ToString());
                pictureBox1.Image = BMPHSI_src;


                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
                pictureBox1.Width = 744;
                pictureBox1.Height = 615;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeFolder2.Items.Clear();

            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "請選擇資料夾";

            //dilog.SelectedPath = @"X:\uScan\00_資料收集\02_測試影像\20181213_挑選高榮2018年1+trace照片\";

            //dilog.SelectedPath = @"C:\Users\Steven\Desktop\FourClassWrongRect\1\2\3\4\yoloResult\";
            //dilog.SelectedPath = @"F:\01_imageSet\";
            dilog.SelectedPath = textBox2.Text;

            if (dilog.ShowDialog() == DialogResult.OK)
            {
                RootDir = dilog.SelectedPath;
            }
            else
            {
                return;
            }

            RootDir = dilog.SelectedPath;

            string[] dirs = Directory.GetDirectories(RootDir);
            foreach (string dir in dirs)
            {
                HomeFolder2.Items.Add(dir);

            }
            if (HomeFolder2.Items.Count > 0)
            {
                HomeFolder2.SelectedIndex = 0;
            }


        }

        private void HomeFolder2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            //dataGridView4.Rows.Clear();


            string filepath = "";
            if (HomeFolder2.SelectedIndex < 0)
            { MessageBox.Show("dirList has no item"); }

            filepath = HomeFolder2.Items[HomeFolder2.SelectedIndex].ToString();
            if (filepath == "")
            { return; }
            // 取得資料夾內所有檔案
            Subfolder2.Items.Clear();


            foreach (string fname in System.IO.Directory.GetDirectories(filepath))
            {
                Subfolder2.Items.Add(fname);
            }
            if (Subfolder2.Items.Count > 0)
            {
                Subfolder2.SelectedIndex = 0;
            }
        }

        private void Subfolder2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }


            string filepath = "";
            if (Subfolder2.SelectedIndex < 0)
            { MessageBox.Show("myList2 has no item"); }

            filepath = Subfolder2.Items[Subfolder2.SelectedIndex].ToString();
            if (filepath == "")
            { return; }
            // 取得資料夾內所有檔案
            imgFileList2.Items.Clear();


            foreach (string fname in System.IO.Directory.GetFileSystemEntries(filepath))
            {
                if (File.Exists(fname))
                {

                    if (fname.ToLower().Contains(".bmp") || fname.ToLower().Contains(".jpg"))
                    {

                        imgFileList2.Items.Add(fname);
                    }
                }

            }
            if (imgFileList2.Items.Count > 0)
            {
                imgFileList2.SelectedIndex = 0;
            }
        }

        private void imgFileList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PaintRec(true);
            if (imgFileList2.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(imgFileList2.SelectedItem.ToString());
                pictureBox2.Image = BMPHSI_src;

                pictureBox2.Left = 0;
                pictureBox2.Top = 0;
                pictureBox2.Width = 744;
                pictureBox2.Height = 615;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            theSamePart.Items.Clear();
            DifferentPart.Items.Clear();
            theSamePart2.Items.Clear();
            Different2.Items.Clear();

            for (int i = 0; i < imgFileList.Items.Count; i++) {
                string img1_filename = Path.GetFileName(imgFileList.Items[i].ToString());
                if (img1_filename.ToLower().Contains(".jpg") && img1_filename.ToLower().Contains("+"))
                {
                    int j = isExist(imgFileList2, img1_filename);
                    if (  j>=0)
                    {
                        theSamePart.Items.Add(imgFileList.Items[i].ToString());
                        theSamePart2.Items.Add(imgFileList2.Items[j].ToString());
                    }
                    else
                    {
                        DifferentPart.Items.Add(imgFileList.Items[i].ToString());
                    }

                }
            }

            label1.Text = theSamePart.Items.Count.ToString();
            label2.Text = DifferentPart.Items.Count.ToString();
            label3.Text = theSamePart2.Items.Count.ToString();


            for (int i = 0; i < imgFileList2.Items.Count; i++)
            {
                string img2_filename = Path.GetFileName(imgFileList2.Items[i].ToString());
                if (img2_filename.ToLower().Contains(".jpg") && img2_filename.ToLower().Contains("+"))
                {
                    int j = isExist(imgFileList, img2_filename);
                    if (j == -1)
                    {
                        Different2.Items.Add(imgFileList2.Items[i].ToString());
                        
                    }
                }

            }

            label4.Text = Different2.Items.Count.ToString();


        }

        private int isExist(ListBox lsbox, string var)
        {
            for (int i = 0; i < lsbox.Items.Count; i++)

                if (var == Path.GetFileName(lsbox.Items[i].ToString()))
                {
                    return i;
                }
            return -1;
        }



        private void theSamePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theSamePart.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(theSamePart.SelectedItem.ToString());
                pictureBox1.Image = BMPHSI_src;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
                pictureBox1.Width = 744;
                pictureBox1.Height = 615;
            }

        }

        private void DifferentPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DifferentPart.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(DifferentPart.SelectedItem.ToString());
                pictureBox1.Image = BMPHSI_src;
                pictureBox1.Left = 0;
                pictureBox1.Top = 0;
                pictureBox1.Width = 744;
                pictureBox1.Height = 615;
            }
        }

        private void theSamePart2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theSamePart2.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(theSamePart2.SelectedItem.ToString());
                pictureBox2.Image = BMPHSI_src;
                pictureBox2.Left = 0;
                pictureBox2.Top = 0;
                pictureBox2.Width = 744;
                pictureBox2.Height = 615;
            }
        }

        private void Different2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Different2.SelectedItem != null)
            {
                Bitmap BMPHSI_src = new Bitmap(Different2.SelectedItem.ToString());
                pictureBox2.Image = BMPHSI_src;
                pictureBox2.Left = 0;
                pictureBox2.Top = 0;
                pictureBox2.Width = 744;
                pictureBox2.Height = 615;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (theSamePart.SelectedItem != null)
            {
                string targetPath = HomeFolder.Text + "\\select\\";
                string sourceFile = theSamePart.Text;
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(theSamePart.Text));

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("沒有選影像");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DifferentPart.SelectedItem != null)
            {
                string targetPath = HomeFolder.Text + "\\select\\";
                string sourceFile = DifferentPart.Text;
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(DifferentPart.Text));

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("沒有選影像");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (theSamePart2.SelectedItem != null)
            {
                string targetPath = HomeFolder2.Text + "\\select\\";
                string sourceFile = theSamePart2.Text;
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(theSamePart2.Text));

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("沒有選影像");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Different2.SelectedItem != null)
            {
                string targetPath = HomeFolder2.Text + "\\select\\";
                string sourceFile = Different2.Text;
                string destFile = System.IO.Path.Combine(targetPath, Path.GetFileName(Different2.Text));

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show("沒有選影像");
            }
        }

        private void theSamePart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (theSamePart.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(theSamePart.SelectedItem.ToString());
            }
        }

        private void DifferentPart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DifferentPart.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(DifferentPart.SelectedItem.ToString());
            }
        }

        private void theSamePart2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (theSamePart2.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(theSamePart2.SelectedItem.ToString());
            }
        }

        private void Different2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Different2.SelectedItem != null)
            {
                System.Diagnostics.Process.Start(Different2.SelectedItem.ToString());
            }
        }





        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            pictureBox1.Cursor = Cursors.SizeAll;
        }
      

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            double scale = 1;
            if (pictureBox1.Height > 0)
                {
                    scale = (double)pictureBox1.Width / (double)pictureBox1.Height;
                }

            if (pictureBox1.Width < 3000 && e.Delta > 0)
            {
                pictureBox1.Width += (int)(e.Delta * scale);
                pictureBox1.Height += e.Delta;
            }

            if (pictureBox1.Width > 500 && e.Delta < 0)
            {
                pictureBox1.Width += (int)(e.Delta * scale);
                pictureBox1.Height += e.Delta;
            }



        }
        

        public System.Drawing.Point mouseDownPoint;//存储鼠标焦点的全局变量
        public bool isSelected = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelected && IsMouseInPanel())//确定已经激发MouseDown事件，和鼠标在picturebox的范围内
            {
                pictureBox1.Left = pictureBox1.Left + (Cursor.Position.X - mouseDownPoint.X);
                pictureBox1.Top = pictureBox1.Top + (Cursor.Position.Y - mouseDownPoint.Y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        private bool IsMouseInPanel()
         {
             if (this.panel_Picture.Left<PointToClient(Cursor.Position).X
                     && PointToClient(Cursor.Position).X< this.panel_Picture.Left
                     + this.panel_Picture.Width && this.panel_Picture.Top
                     < PointToClient(Cursor.Position).Y && PointToClient(Cursor.Position).Y
                     < this.panel_Picture.Top + this.panel_Picture.Height)
             {
                return true;
             }
             else
             {
                return false;
             }       
         }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              mouseDownPoint.X = Cursor.Position.X;  //注：全局变量mouseDownPoint前面已定义为Point类型  
              mouseDownPoint.Y = Cursor.Position.Y;
              isSelected = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isSelected = false;
        }










        private void pictureBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            double scale = 1;
            if (pictureBox2.Height > 0)
            {
                scale = (double)pictureBox2.Width / (double)pictureBox2.Height;
            }


            int delta = e.Delta;
         

            pictureBox2.Width += (int)(delta * scale);
            pictureBox2.Height += delta;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isSelected = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;  //注：全局变量mouseDownPoint前面已定义为Point类型  
                mouseDownPoint.Y = Cursor.Position.Y;
                isSelected = true;
            }
        }

        private bool IsMouseInPanel_2()
        {
            if (this.panel2.Left < PointToClient(Cursor.Position).X
                    && PointToClient(Cursor.Position).X < this.panel2.Left
                    + this.panel2.Width && this.panel2.Top
                    < PointToClient(Cursor.Position).Y && PointToClient(Cursor.Position).Y
                    < this.panel2.Top + this.panel2.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelected && IsMouseInPanel_2())//确定已经激发MouseDown事件，和鼠标在picturebox的范围内
            {
                pictureBox2.Left = pictureBox2.Left + (Cursor.Position.X - mouseDownPoint.X);
                pictureBox2.Top = pictureBox2.Top + (Cursor.Position.Y - mouseDownPoint.Y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Focus();
            pictureBox2.Cursor = Cursors.SizeAll;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
