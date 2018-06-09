using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int count = 0;
        int count1 = 0;
        int errors;
        int tries = 0;
        bool move1 = true;
        bool move2 = false;
        bool firstwent = false;
        bool enterlink = false;
        bool byelink = false;
        bool linkgud = false;
        string dlfolderpath = "";
        string path2 = "";
        string[] array = new string[] { "" };
        string[] array1 = new string[] { "" };
        string[] array2 = new string[] { "" };
        string[] array3 = new string[] { "" };
        string[] array4 = new string[] { "" };
        string[] array5 = new string[] { "" };
        string[] array6 = new string[] { "" };
        string[] array7 = new string[] { "" };

        public Form1()
        {
            InitializeComponent();
            button1.Text = "DL Location";
            button2.Text = "Enter URL";
            button3.Text = "Download files";
            nodownloadbox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetpos();
            timer1.Start();
        }

        //Visual design

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (move1 == true)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
                count += 10;
            }
            if (count == 320)
            {
                move1 = false;
                move2 = true;
                count = 0;
            }
            if (move2 == true)
            {
                timer1.Interval = 3;

                button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
                count += 10;
                if (count == 20)
                {
                    timer1.Stop();
                }
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            
            timer3.Start();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            else if (this.Opacity > 1)
            {
                this.Opacity = 1;
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.90)
            {
                this.Opacity -= 0.01;
            }
            else if (this.Opacity < 0.90)
            {
                this.Opacity = 0.90;
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(firstwent == false)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
                count += 10;
                if (count == 320)
                {
                    button1.Dispose();
                    button3.Location = new Point(button3.Location.X, button3.Location.Y - 80);
                    count = 0;
                    firstwent = true;
                    move1 = true;
                }
            }
            
            if (move1 == true)
            {
                button2.Location = new Point(button2.Location.X, button2.Location.Y - 10);
                button3.Location = new Point(button3.Location.X, button3.Location.Y - 10);
                count += 10;
            }
            if (count == 320)
            {
                move1 = false;
                move2 = true;
                count = 0;
            }
            if (move2 == true)
            {
                timer1.Interval = 3;

                button2.Location = new Point(button2.Location.X, button2.Location.Y + 10);
                button3.Location = new Point(button3.Location.X, button3.Location.Y + 10);
                count += 10;
                if (count == 20)
                {
                    timer4.Stop();
                }
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (enterlink == true)
            {
                button2.Location = new Point(button2.Location.X - 20, button2.Location.Y);
                button3.Location = new Point(button3.Location.X - 20, button3.Location.Y);

                label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
                button4.Location = new Point(button4.Location.X - 20, button4.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X - 20, pictureBox5.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X - 20, pictureBox4.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X - 20, pictureBox3.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X - 20, pictureBox6.Location.Y);
                textBox1.Location = new Point(textBox1.Location.X - 20, textBox1.Location.Y);
            }
            if (byelink == true)
            {
                button2.Location = new Point(button2.Location.X + 20, button2.Location.Y);
                button3.Location = new Point(button3.Location.X + 20, button3.Location.Y);

                label2.Location = new Point(label2.Location.X + 20, label2.Location.Y);
                button4.Location = new Point(button4.Location.X + 20, button4.Location.Y);
                pictureBox5.Location = new Point(pictureBox5.Location.X + 20, pictureBox5.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X + 20, pictureBox4.Location.Y);
                pictureBox3.Location = new Point(pictureBox3.Location.X + 20, pictureBox3.Location.Y);
                pictureBox6.Location = new Point(pictureBox6.Location.X + 20, pictureBox6.Location.Y);
                textBox1.Location = new Point(textBox1.Location.X + 20, textBox1.Location.Y);
            }

            count += 10;
            if (count == 400)
            {
                if(byelink == true)
                {
                    label2.Visible = false;
                    button4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox6.Visible = false;
                    textBox1.Visible = false;

                    resetpos();
                    byelink = false;
                    
                }
                
                enterlink = false;
                timer5.Stop();
                count = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nodownloadbox();
            label2.Visible = true;
            button4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox6.Visible = true;
            textBox1.Visible = true;
            resetpos();
            

            enterlink = true;

            timer5.Start();
            
        }

        private void resetpos()
        {
            count = 0;
            button2.Location = new Point(275, button2.Location.Y);
            button3.Location = new Point(275, button3.Location.Y);
            label2.Location = new Point(1180, label2.Location.Y);
            button4.Location = new Point(1438, button4.Location.Y);
            pictureBox5.Location = new Point(866, pictureBox5.Location.Y);
            pictureBox4.Location = new Point(866, pictureBox4.Location.Y);
            pictureBox3.Location = new Point(866, pictureBox3.Location.Y);
            pictureBox6.Location = new Point(1539, pictureBox6.Location.Y);
            textBox1.Location = new Point(882, textBox1.Location.Y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byelink = true;
            timer5.Start();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            downloadbox();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            nodownloadbox();
        }

        private void downloadbox()
        {
            pictureBox7.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            pictureBox7.Location = new Point(569, 81);
        }
        private void nodownloadbox()
        {
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            pictureBox7.Visible = false;
            pictureBox7.Location = new Point(1000, 1000);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Stop();
        }


        //the fun starts here


        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog slctfolder = new FolderBrowserDialog();
            slctfolder.RootFolder = Environment.SpecialFolder.MyComputer;
            if (slctfolder.ShowDialog() == System.Windows.Forms.DialogResult.OK && System.IO.Directory.Exists(slctfolder.SelectedPath))
            {
                dlfolderpath = @slctfolder.SelectedPath;
                move1 = false;
                move2 = false;
                timer4.Start();
            }
            else
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "";
            string filename = "";
            int i1 = 0;
            int strcount = 0;
            string path1 = "";
            string html = "";
            bool linkgud9 = false;
            bool linkgud4 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud4 = true;
            }
            catch
            {
                linkgud4 = false;
            }

            if (linkgud4 == true)
            {
                Task.Run(() =>
                {

                    //Store and read html to look for image paths
                    string url = textBox1.Text;
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                    html = streamrdr.ReadToEnd();
                    Char del = '"';
                    String[] htmlstrings = html.Split(del);
                    WebClient webClient = new WebClient();
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount = dir.GetFiles().Length;

                    Console.WriteLine(htmlstrings);

                    for (int i = 0; i < htmlstrings.Length; i++)
                    {
                        if (htmlstrings[i].Contains(".jpeg") == false && htmlstrings[i].Contains(".png") == false && htmlstrings[i].Contains(".gif") == false && htmlstrings[i].Contains(".jpg") == false && htmlstrings[i].Contains(".tif") == false && htmlstrings[i].Contains(".tiff") == false && htmlstrings[i].Contains(".gif") == false && htmlstrings[i].Contains(".jif") == false && htmlstrings[i].Contains(".jiff") == false && htmlstrings[i].Contains(".jp2") == false && htmlstrings[i].Contains(".jpx") == false && htmlstrings[i].Contains(".j2k") == false && htmlstrings[i].Contains(".j2c") == false && htmlstrings[i].Contains(".jpx") == false && htmlstrings[i].Contains(".pcd") == false && htmlstrings[i].Contains(".pdf") == false)
                        {
                            //Console.WriteLine("failed to pass first link check" + htmlstrings[i]);
                            Array.Resize(ref array7, array7.Length + 1);
                            array7[array7.Length - 1] = htmlstrings[i];
                        }
                        else
                        {
                            if (array7.Contains(htmlstrings[i]) == false)
                            {
                                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button5.ForeColor = Color.Red; });
                                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button5.Text = "Downloading"; });
                                //Console.WriteLine("passed first link check" + htmlstrings[i]);
                                if (htmlstrings[i].Contains(".jpeg") || htmlstrings[i].Contains(".png") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".jpg") || htmlstrings[i].Contains(".tif") || htmlstrings[i].Contains(".tiff") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".jif") || htmlstrings[i].Contains(".jiff") || htmlstrings[i].Contains(".jp2") || htmlstrings[i].Contains(".jpx") || htmlstrings[i].Contains(".j2k") || htmlstrings[i].Contains(".j2c") || htmlstrings[i].Contains(".jpx") || htmlstrings[i].Contains(".pcd") || htmlstrings[i].Contains(".pdf"))
                                {
                                    //Console.WriteLine(htmlstrings[i]);
                                    char deli = '/';
                                    String[] filename1 = htmlstrings[i].Split(deli);
                                    for (i1 = 0; i1 < filename1.Length; i1++) { }
                                    string filename3 = filename1[i1 - 1];
                                    string filename2 = filename3.Replace("/", "");
                                    string filename4 = filename2.Replace(@"\", "");
                                    string filename5 = filename4.Replace("*", "");
                                    string filename6 = filename5.Replace("\"", "");
                                    string filename7 = filename6.Replace("<", "");
                                    string filename8 = filename7.Replace(">", "");
                                    string filename9 = filename8.Replace(":", "");
                                    string filename10 = filename9.Replace(";", "");
                                    string filename11 = filename10.Replace("</a>", "");
                                    string filename12 = filename11.Replace("</p>", "");
                                    filename = filename12.Replace("|", "");

                                    if (htmlstrings[i].Contains(".jpg"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jpg");
                                        path1 = (@dlfolderpath + @"\" + i + ".jpg");
                                    }
                                    if (htmlstrings[i].Contains(".jpeg"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jpeg");
                                        path1 = (@dlfolderpath + @"\" + i + ".jpeg");
                                    }
                                    if (htmlstrings[i].Contains(".png"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".png");
                                        path1 = (@dlfolderpath + @"\" + i + ".png");
                                    }
                                    if (htmlstrings[i].Contains(".gif"))
                                    {
                                        if (htmlstrings[i].Contains(".gifv"))
                                        {
                                            path = (@dlfolderpath + @"\" + filename + ".gifv");
                                            path1 = (@dlfolderpath + @"\" + i + ".gifv");
                                        }
                                        else
                                        {
                                            path = (@dlfolderpath + @"\" + filename + ".gif");
                                            path1 = (@dlfolderpath + @"\" + i + ".gif");
                                        }   
                                    }
                                    if (htmlstrings[i].Contains(".tif"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".tif");
                                        path1 = (@dlfolderpath + @"\" + i + ".tif");
                                    }
                                    if (htmlstrings[i].Contains(".tiff"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".tiff");
                                        path1 = (@dlfolderpath + @"\" + i + ".tiff");
                                    }
                                    if (htmlstrings[i].Contains(".jif"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jif");
                                        path1 = (@dlfolderpath + @"\" + i + ".jif");
                                    }
                                    if (htmlstrings[i].Contains(".jiff"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jiff");
                                        path1 = (@dlfolderpath + @"\" + i + ".jiff");
                                    }
                                    if (htmlstrings[i].Contains(".jp2"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jp2");
                                        path1 = (@dlfolderpath + @"\" + i + ".jp2");
                                    }
                                    if (htmlstrings[i].Contains(".jpx"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".jpx");
                                        path1 = (@dlfolderpath + @"\" + i + ".jpx");
                                    }
                                    if (htmlstrings[i].Contains(".j2k"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".j2k");
                                        path1 = (@dlfolderpath + @"\" + i + ".j2k");
                                    }
                                    if (htmlstrings[i].Contains(".j2c"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".j2c");
                                        path1 = (@dlfolderpath + @"\" + i + ".j2c");
                                    }
                                    if (htmlstrings[i].Contains(".fpx"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".fpx");
                                        path1 = (@dlfolderpath + @"\" + i + ".fpx");
                                    }
                                    if (htmlstrings[i].Contains(".pcd"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".pcd");
                                        path1 = (@dlfolderpath + @"\" + i + ".pcd");
                                    }
                                    if (htmlstrings[i].Contains(".pdf"))
                                    {
                                        path = (@dlfolderpath + @"\" + filename + ".pdf");
                                        path1 = (@dlfolderpath + @"\" + i + ".pdf");

                                    }

                                    
                                    try
                                    {
                                        WebClient wc = new WebClient();
                                        string HTMLSource = wc.DownloadString(htmlstrings[i]);
                                        linkgud4 = true;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("link fail.." + htmlstrings[i]);
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    try
                                    {
                                        if (array3.Contains(filename) == false)
                                        {
                                            webClient.DownloadFile(htmlstrings[i], @path.Replace(@"//", @""));
                                            tries++;
                                        }
                                    }
                                    catch
                                    { 
                                        
                                        try
                                        {
                                            webClient.DownloadFile(htmlstrings[i], @path1.Replace(@"//", @""));
                                        }
                                        catch
                                        {
                                            Console.WriteLine("failed to download file" + htmlstrings[i]);
                                            errors++;
                                        }
                                    }
                                    Array.Resize(ref array3, array3.Length + 1);
                                    array3[array3.Length - 1] = filename;
                                }
                                else
                                {
                                    //Console.WriteLine("failed to pass second link test" + htmlstrings[i]);
                                }
                            }
                        }
                    }

                    System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount1 = dir.GetFiles().Length;
                    MessageBox.Show("Completed with" + errors + " errors " + "and " + (filecount1 - filecount) + " successful");

                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button5.ForeColor = Color.Black; });
                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button5.Text = "Images"; });

                    System.Diagnostics.Process.Start(dlfolderpath);
                });
            }
        }
        

        public void vid()
        {
            string path = "";
            string filename = "";
            int i1 = 0;
            int strcount = 0;
            string html = "";
            string url = "";
            bool linkgud3 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud3 = true;
            }
            catch
            {
                linkgud3 = false;
            }

            if (linkgud3 == true)
            {

                Task.Run(() =>
                {
                    while (count1 < 100000000)
                    {
                        Thread.Sleep(5000);
                        if (count1 == 0)
                        {
                            url = textBox1.Text;
                        }
                        else if (array.Length > 1)
                        {
                            var rndmnum = new Random();
                            int index = rndmnum.Next(2, array.Length);
                            url = Convert.ToString(array[index]);

                        }
                        count1++;
                        try
                        {
                            HttpWebRequest webreqq = (HttpWebRequest)WebRequest.Create(url);
                            HttpWebResponse webress = (HttpWebResponse)webreqq.GetResponse();
                            StreamReader streamrdrr = new StreamReader(webress.GetResponseStream());
                            html = streamrdrr.ReadToEnd();
                        }
                        catch
                        {
                            vid();
                        }
                        HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                        StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                        html = streamrdr.ReadToEnd();
                        Char del = '"';
                        String[] htmlstrings = html.Split(del);
                        WebClient webClient = new WebClient();
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                        int filecount = dir.GetFiles().Length;
                        for (int i = 0; i < htmlstrings.Length; i++)
                        {
                            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.ForeColor = Color.Red; });
                            this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.Text = "Downloading"; });

                            if (htmlstrings[i].Contains(".com"))
                            {
                                if (array.Contains(htmlstrings[i]) == false)
                                {
                                    try
                                    {
                                        WebClient wc = new WebClient();
                                        string HTMLSource = wc.DownloadString(htmlstrings[i]);
                                        linkgud = true;
                                    }
                                    catch
                                    {
                                        linkgud = false;
                                    }

                                    if (linkgud == true)
                                    {
                                        int num = i;
                                        Console.WriteLine(num);
                                        Array.Resize(ref array, array.Length + 1);
                                        array[array.Length - 1] = htmlstrings[i];
                                    }

                                }

                            }

                            if (htmlstrings[i].Contains(".webm") || htmlstrings[i].Contains(".mkv") || htmlstrings[i].Contains(".flv") || htmlstrings[i].Contains(".vob") || htmlstrings[i].Contains(".ogv") || htmlstrings[i].Contains(".ogg") || htmlstrings[i].Contains(".drc") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".gifv") || htmlstrings[i].Contains(".mng") || htmlstrings[i].Contains(".avi") || htmlstrings[i].Contains(".mov") || htmlstrings[i].Contains(".qt") || htmlstrings[i].Contains(".wmv") || htmlstrings[i].Contains(".yuv") || htmlstrings[i].Contains(".rm") || htmlstrings[i].Contains(".rmvb") || htmlstrings[i].Contains(".asf") || htmlstrings[i].Contains(".amv") || htmlstrings[i].Contains(".mp4") || htmlstrings[i].Contains(".m4p") || htmlstrings[i].Contains(".m4v") || htmlstrings[i].Contains(".mpg") || htmlstrings[i].Contains(".mp2") || htmlstrings[i].Contains(".mpeg") || htmlstrings[i].Contains(".mpe") || htmlstrings[i].Contains(".mpv") || htmlstrings[i].Contains(".mpg") || htmlstrings[i].Contains(".mpeg") || htmlstrings[i].Contains(".m2v") || htmlstrings[i].Contains(".m4v") || htmlstrings[i].Contains(".svi") || htmlstrings[i].Contains(".3gp") || htmlstrings[i].Contains(".3g2") || htmlstrings[i].Contains(".mxf") || htmlstrings[i].Contains(".roq") || htmlstrings[i].Contains(".nsv") || htmlstrings[i].Contains(".flv") || htmlstrings[i].Contains(".f4v") || htmlstrings[i].Contains(".f4p") || htmlstrings[i].Contains(".f4a") || htmlstrings[i].Contains(".f4b"))
                            {
                                char deli = '/';
                                String[] filename1 = htmlstrings[i].Split(deli);
                                for (int ii = 0; ii < filename1.Length; ii++)
                                {
                                    if (filename1[ii].Contains(".webm"))
                                    {
                                        filename = filename1[ii].Replace(".webm", "");
                                    }
                                    if (filename1[ii].Contains("mkv"))
                                    {
                                        filename = filename1[ii].Replace("mkv", "");
                                    }
                                    if (filename1[ii].Contains(".flv"))
                                    {
                                        filename = filename1[ii].Replace(".flv", "");
                                    }
                                    if (filename1[ii].Contains(".vob"))
                                    {
                                        filename = filename1[ii].Replace(".vob", "");
                                    }
                                    if (filename1[ii].Contains(".ogv"))
                                    {
                                        filename = filename1[ii].Replace(".ogv", "");
                                    }
                                    if (filename1[ii].Contains(".ogg"))
                                    {
                                        filename = filename1[ii].Replace(".ogg", "");
                                    }
                                    if (filename1[ii].Contains(".drc"))
                                    {
                                        filename = filename1[ii].Replace(".drc", "");
                                    }
                                    if (filename1[ii].Contains(".gif"))
                                    {
                                        filename = filename1[ii].Replace(".gif", "");
                                    }
                                    if (filename1[ii].Contains(".gifv"))
                                    {
                                        filename = filename1[ii].Replace(".gifv", "");
                                    }
                                    if (filename1[ii].Contains(".mng"))
                                    {
                                        filename = filename1[ii].Replace(".mng", "");
                                    }
                                    if (filename1[ii].Contains(".avi"))
                                    {
                                        filename = filename1[ii].Replace(".avi", "");
                                    }
                                    if (filename1[ii].Contains(".mov"))
                                    {
                                        filename = filename1[ii].Replace(".mov", "");
                                    }
                                    if (filename1[ii].Contains(".qt"))
                                    {
                                        filename = filename1[ii].Replace(".qt", "");
                                    }
                                    if (filename1[ii].Contains(".wmv"))
                                    {
                                        filename = filename1[ii].Replace(".wmv", "");
                                    }
                                    if (filename1[ii].Contains(".yuv"))
                                    {
                                        filename = filename1[ii].Replace(".yuv", "");
                                    }




                                    if (filename1[ii].Contains("rm"))
                                    {
                                        filename = filename1[ii].Replace("rm", "");
                                    }
                                    if (filename1[ii].Contains(".rmvb"))
                                    {
                                        filename = filename1[ii].Replace(".rmvb", "");
                                    }
                                    if (filename1[ii].Contains(".asf"))
                                    {
                                        filename = filename1[ii].Replace(".asf", "");
                                    }
                                    if (filename1[ii].Contains(".amv"))
                                    {
                                        filename = filename1[ii].Replace(".amv", "");
                                    }
                                    if (filename1[ii].Contains(".mp4"))
                                    {
                                        filename = filename1[ii].Replace(".mp4", "");
                                    }
                                    if (filename1[ii].Contains(".m4p"))
                                    {
                                        filename = filename1[ii].Replace(".m4p", "");
                                    }
                                    if (filename1[ii].Contains(".m4v"))
                                    {
                                        filename = filename1[ii].Replace(".m4v", "");
                                    }
                                    if (filename1[ii].Contains(".mpg"))
                                    {
                                        filename = filename1[ii].Replace(".mpg", "");
                                    }
                                    if (filename1[ii].Contains(".mp2"))
                                    {
                                        filename = filename1[ii].Replace(".mp2", "");
                                    }
                                    if (filename1[ii].Contains(".mpeg"))
                                    {
                                        filename = filename1[ii].Replace(".mpeg", "");
                                    }
                                    if (filename1[ii].Contains(".mpe"))
                                    {
                                        filename = filename1[ii].Replace(".mpe", "");
                                    }
                                    if (filename1[ii].Contains(".mpv"))
                                    {
                                        filename = filename1[ii].Replace(".mpv", "");
                                    }
                                    if (filename1[ii].Contains(".mpg"))
                                    {
                                        filename = filename1[ii].Replace(".mpg", "");
                                    }
                                    if (filename1[ii].Contains(".mpeg"))
                                    {
                                        filename = filename1[ii].Replace(".mpeg", "");
                                    }


                                    if (filename1[ii].Contains(".m2v"))
                                    {
                                        filename = filename1[ii].Replace(".m2v", "");
                                    }
                                    if (filename1[ii].Contains(".m4v"))
                                    {
                                        filename = filename1[ii].Replace(".m4v", "");
                                    }
                                    if (filename1[ii].Contains(".svi"))
                                    {
                                        filename = filename1[ii].Replace(".svi", "");
                                    }
                                    if (filename1[ii].Contains(".3gp"))
                                    {
                                        filename = filename1[ii].Replace(".3gp", "");
                                    }
                                    if (filename1[ii].Contains(".3g2"))
                                    {
                                        filename = filename1[ii].Replace(".3g2", "");
                                    }
                                    if (filename1[ii].Contains(".mxf"))
                                    {
                                        filename = filename1[ii].Replace(".mxf", "");
                                    }
                                    if (filename1[ii].Contains(".roq"))
                                    {
                                        filename = filename1[ii].Replace(".roq", "");
                                    }


                                    if (filename1[ii].Contains(".nsv"))
                                    {
                                        filename = filename1[ii].Replace(".nsv", "");
                                    }
                                    if (filename1[ii].Contains(".flv"))
                                    {
                                        filename = filename1[ii].Replace(".flv", "");
                                    }
                                    if (filename1[ii].Contains(".f4v"))
                                    {
                                        filename = filename1[ii].Replace(".f4v", "");
                                    }
                                    if (filename1[ii].Contains(".f4p"))
                                    {
                                        filename = filename1[ii].Replace(".f4p", "");
                                    }
                                    if (filename1[ii].Contains(".f4a"))
                                    {
                                        filename = filename1[ii].Replace(".f4a", "");
                                    }
                                    if (filename1[ii].Contains(".f4b"))
                                    {
                                        filename = filename1[ii].Replace(".f4b", "");
                                    }

                                }

                                if (htmlstrings[i].Contains(".webm"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".webm");
                                }
                                if (htmlstrings[i].Contains(".mkv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mkv");
                                }
                                if (htmlstrings[i].Contains(".flv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".flv");
                                }
                                if (htmlstrings[i].Contains(".vob"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".vob");
                                }
                                if (htmlstrings[i].Contains(".ogv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".ogg");
                                }
                                if (htmlstrings[i].Contains(".drc"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".drc");
                                }
                                if (htmlstrings[i].Contains(".gif"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".gif");
                                }
                                if (htmlstrings[i].Contains(".gifv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".jiff");
                                }
                                if (htmlstrings[i].Contains(".mng"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mng");
                                }
                                if (htmlstrings[i].Contains(".avi"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".avi");
                                }
                                if (htmlstrings[i].Contains(".mov"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mov");
                                }
                                if (htmlstrings[i].Contains(".qt"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".qt");
                                }
                                if (htmlstrings[i].Contains(".wmv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".wmv");
                                }
                                if (htmlstrings[i].Contains(".yuv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".yuv");
                                }
                                if (htmlstrings[i].Contains(".rm"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".rm");
                                }
                                if (htmlstrings[i].Contains(".rmvb"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".rmvb");

                                }
                                if (htmlstrings[i].Contains(".asf"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".asf");
                                }
                                if (htmlstrings[i].Contains(".amv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".amv");
                                }
                                if (htmlstrings[i].Contains(".mp4"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mp4");
                                }
                                if (htmlstrings[i].Contains(".m4p"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".m4p");
                                }
                                if (htmlstrings[i].Contains(".m4v"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".m4v");
                                }
                                if (htmlstrings[i].Contains(".mpg"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpg");
                                }
                                if (htmlstrings[i].Contains(".mp2"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mp2");
                                }
                                if (htmlstrings[i].Contains(".mpeg"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpeg");
                                }
                                if (htmlstrings[i].Contains(".mpe"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpe");
                                }
                                if (htmlstrings[i].Contains(".mpv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpv");
                                }
                                if (htmlstrings[i].Contains(".mpg"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpg");
                                }
                                if (htmlstrings[i].Contains(".mpeg"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mpeg");
                                }
                                if (htmlstrings[i].Contains(".m2v"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".m2v");
                                }
                                if (htmlstrings[i].Contains(".m4v"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".m4v");
                                }
                                if (htmlstrings[i].Contains(".svi"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".svi");
                                }
                                if (htmlstrings[i].Contains(".3gp"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".3gp");

                                }



                                if (htmlstrings[i].Contains(".3g2"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".3g2");
                                }
                                if (htmlstrings[i].Contains(".mxf"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".mxf");
                                }
                                if (htmlstrings[i].Contains(".roq"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".roq");
                                }
                                if (htmlstrings[i].Contains(".nsv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".nsv");
                                }
                                if (htmlstrings[i].Contains(".flv"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".flv");
                                }
                                if (htmlstrings[i].Contains(".f4v"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".f4v");
                                }
                                if (htmlstrings[i].Contains(".f4p"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".f4p");
                                }
                                if (htmlstrings[i].Contains(".f4a"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".f4a");
                                }
                                if (htmlstrings[i].Contains(".f4b"))
                                {
                                    path = (@dlfolderpath + @"\" + filename + ".f4b");
                                }


                                string path1 = (@path.Replace(@"\\", @"\"));
                                try
                                {                              
                                    if(array1.Contains(filename) == false)
                                    {
                                        webClient.DownloadFile(htmlstrings[i], @path1.Replace(@"\\", @"\"));
                                        tries++;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine(@path1.Replace(@"\\", @"\"));
                                    errors++;
                                }
                                Array.Resize(ref array1, array1.Length + 1);
                                array1[array1.Length - 1] = filename;
                            }

                        }
                    }
                        for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }

                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.ForeColor = Color.Black; });
                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.Text = "Picture download external sites"; });

                    System.Diagnostics.Process.Start(dlfolderpath);
                });
            }

        }
        public void pic()
        {
            string path = "";
            string filename = "";
            int i1 = 0;
            int strcount = 0;
            string html = "";
            bool linkgud3 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud3 = true;
            }
            catch
            {
                linkgud3 = false;
            }

            if (linkgud3 == true)
            {

            Task.Run(() =>
            {
                string url = "";
                while (count1 < 100000000)
                {
                    Thread.Sleep(5000);
                    if (count1 == 0)
                    {
                        url = textBox1.Text;
                    }
                    else if (array.Length > 1)
                    {
                        var rndmnum = new Random();
                        int index = rndmnum.Next(2, array.Length);
                        url = Convert.ToString(array[index]);

                    }
                    count1++;
                    try
                    {
                        HttpWebRequest webreqq = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse webress = (HttpWebResponse)webreqq.GetResponse();
                        StreamReader streamrdrr = new StreamReader(webress.GetResponseStream());
                        html = streamrdrr.ReadToEnd();
                    }
                    catch
                    {
                        pic();
                    }
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                    html = streamrdr.ReadToEnd();
                    Char del = '"';
                    String[] htmlstrings = html.Split(del);
                    WebClient webClient = new WebClient();
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount = dir.GetFiles().Length;
                    for (int i = 0; i < htmlstrings.Length; i++)
                    {
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.ForeColor = Color.Red; });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.Text = "Downloading"; });

                        if (htmlstrings[i].Contains(".com"))
                        {
                            if (array.Contains(htmlstrings[i]) == false)
                            {
                                try
                                {
                                    WebClient wc = new WebClient();
                                    string HTMLSource = wc.DownloadString(htmlstrings[i]);
                                    linkgud = true;
                                }
                                catch
                                {
                                    linkgud = false;
                                }

                                if (linkgud == true)
                                {
                                    int num = i;
                                    Console.WriteLine(num);
                                    Array.Resize(ref array, array.Length + 1);
                                    array[array.Length - 1] = htmlstrings[i];
                                }

                            }

                        }

                        if (htmlstrings[i].Contains(".jpeg") || htmlstrings[i].Contains(".png") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".jpg") || htmlstrings[i].Contains(".tif") || htmlstrings[i].Contains(".tiff") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".jif") || htmlstrings[i].Contains(".jiff") || htmlstrings[i].Contains(".jp2") || htmlstrings[i].Contains(".jpx") || htmlstrings[i].Contains(".j2k") || htmlstrings[i].Contains(".j2c") || htmlstrings[i].Contains(".jpx") || htmlstrings[i].Contains(".pcd") || htmlstrings[i].Contains(".pdf"))
                        {
                            char deli = '/';
                            String[] filename1 = htmlstrings[i].Split(deli);
                            for (int ii = 0; ii < filename1.Length; ii++)
                            {
                                if (filename1[ii].Contains(".jpeg"))
                                {
                                    filename = filename1[ii].Replace(".jpeg", "");
                                }
                                if (filename1[ii].Contains(".tif"))
                                {
                                    filename = filename1[ii].Replace(".tif", "");
                                }
                                if (filename1[ii].Contains(".tiff"))
                                {
                                    filename = filename1[ii].Replace(".tiff", "");
                                }
                                if (filename1[ii].Contains(".gif"))
                                {
                                    filename = filename1[ii].Replace(".gif", "");
                                }
                                if (filename1[ii].Contains(".jpg"))
                                {
                                    filename = filename1[ii].Replace(".jpg", "");
                                }
                                if (filename1[ii].Contains(".jif"))
                                {
                                    filename = filename1[ii].Replace(".jif", "");
                                }
                                if (filename1[ii].Contains(".jiff"))
                                {
                                    filename = filename1[ii].Replace(".jiff", "");
                                }
                                if (filename1[ii].Contains(".jp2"))
                                {
                                    filename = filename1[ii].Replace(".jp2", "");
                                }
                                if (filename1[ii].Contains(".jpx"))
                                {
                                    filename = filename1[ii].Replace(".jpx", "");
                                }
                                if (filename1[ii].Contains(".j2k"))
                                {
                                    filename = filename1[ii].Replace(".j2k", "");
                                }
                                if (filename1[ii].Contains(".j2c"))
                                {
                                    filename = filename1[ii].Replace(".j2c", "");
                                }
                                if (filename1[ii].Contains(".fpx"))
                                {
                                    filename = filename1[ii].Replace(".fpx", "");
                                }
                                if (filename1[ii].Contains(".pcd"))
                                {
                                    filename = filename1[ii].Replace(".pcd", "");
                                }
                                if (filename1[ii].Contains(".png"))
                                {
                                    filename = filename1[ii].Replace(".png", "");
                                }
                                if (filename1[ii].Contains(".pdf"))
                                {
                                    filename = filename1[ii].Replace(".pdf", "");
                                }
                            }

                            if (htmlstrings[i].Contains(".jpg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jpg");
                            }
                            if (htmlstrings[i].Contains(".jpeg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jpeg");
                            }
                            if (htmlstrings[i].Contains(".png"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".png");
                            }
                            if (htmlstrings[i].Contains(".gif"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".gif");
                            }
                            if (htmlstrings[i].Contains(".tif"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".tif");
                            }
                            if (htmlstrings[i].Contains(".tiff"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".tiff");
                            }
                            if (htmlstrings[i].Contains(".jif"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jif");
                            }
                            if (htmlstrings[i].Contains(".jiff"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jiff");
                            }
                            if (htmlstrings[i].Contains(".jp2"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jp2");
                            }
                            if (htmlstrings[i].Contains(".jpx"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jpx");
                            }
                            if (htmlstrings[i].Contains(".j2k"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".j2k");
                            }
                            if (htmlstrings[i].Contains(".j2c"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".j2c");
                            }
                            if (htmlstrings[i].Contains(".fpx"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".fpx");
                            }
                            if (htmlstrings[i].Contains(".pcd"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".pcd");
                            }
                            if (htmlstrings[i].Contains(".pcd"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".pcd");
                            }
                            if (htmlstrings[i].Contains(".pdf"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".pdf");

                            }

                            string path1 = (@path.Replace(@"\\", @"\"));
                            try
                            {
                                if (array2.Contains(filename) == false)
                                {
                                    webClient.DownloadFile(htmlstrings[i], @path1.Replace(@"\\", @"\"));
                                    tries++;
                                }
                            }
                            catch
                            {
                                Console.WriteLine(@path1.Replace(@"\\", @"\"));
                                errors++;
                            }
                            Array.Resize(ref array2, array2.Length + 1);
                            array2[array2.Length - 1] = filename;
                        }
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.ForeColor = Color.Black; });
                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button9.Text = "Picture download external sites"; });

                System.Diagnostics.Process.Start(dlfolderpath);
                });
            }
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            pic();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "";
            int i1 = 0;
            int strcount = 0;
            string html = "";
            
            
            bool linkgud5 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud5 = true;
            }
            catch
            {
                linkgud5 = false;
            }

            if (linkgud5 == true)
            {
                Task.Run(() =>
                {
                    string filename = "";
                    //Store and read html to look for image paths
                    string url = textBox1.Text;
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                    html = streamrdr.ReadToEnd();
                    Char del = '"';
                    String[] htmlstrings = html.Split(del);
                    WebClient webClient = new WebClient();
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount = dir.GetFiles().Length;
                    for (int i = 0; i < htmlstrings.Length; i++)
                    {
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button6.ForeColor = Color.Red; });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button6.Text = "Downloading"; });

                        if (htmlstrings[i].Contains(".3pg") || htmlstrings[i].Contains(".aa") || htmlstrings[i].Contains(".aac") || htmlstrings[i].Contains(".aax") || htmlstrings[i].Contains(".act") || htmlstrings[i].Contains(".aiff") || htmlstrings[i].Contains(".amr") || htmlstrings[i].Contains(".ape") || htmlstrings[i].Contains(".au") || htmlstrings[i].Contains(".awb") || htmlstrings[i].Contains(".dct") || htmlstrings[i].Contains(".dss") || htmlstrings[i].Contains(".flac") || htmlstrings[i].Contains(".gsm") || htmlstrings[i].Contains(".iklax") || htmlstrings[i].Contains(".ivs") || htmlstrings[i].Contains(".m4a") || htmlstrings[i].Contains(".m4b") || htmlstrings[i].Contains(".m4p") || htmlstrings[i].Contains(".mmf") || htmlstrings[i].Contains(".mp3") || htmlstrings[i].Contains(".mpc") || htmlstrings[i].Contains(".msv") || htmlstrings[i].Contains(".ogg") || htmlstrings[i].Contains(".oga") || htmlstrings[i].Contains(".mogg") || htmlstrings[i].Contains(".pdf") || htmlstrings[i].Contains(".opus") || htmlstrings[i].Contains(".ra") || htmlstrings[i].Contains(".rm") || htmlstrings[i].Contains(".raw") || htmlstrings[i].Contains(".sln") || htmlstrings[i].Contains(".tta") || htmlstrings[i].Contains(".vox") || htmlstrings[i].Contains(".wav") || htmlstrings[i].Contains(".wma") || htmlstrings[i].Contains(".wv") || htmlstrings[i].Contains(".webm") || htmlstrings[i].Contains(".8svx"))
                        {
                            char deli = '/';
                            String[] filename1 = htmlstrings[i].Split(deli);
                            for (int ii = 0; ii < filename1.Length; ii++)
                            {
                                if (filename1[ii].Contains(".3pg"))
                                {
                                    filename = filename1[ii].Replace(".3pg", "");
                                }
                                if (filename1[ii].Contains(".aa"))
                                {
                                    filename = filename1[ii].Replace(".aa", "");
                                }
                                if (filename1[ii].Contains(".aac"))
                                {
                                    filename = filename1[ii].Replace(".aac", "");
                                }
                                if (filename1[ii].Contains(".aax"))
                                {
                                    filename = filename1[ii].Replace(".aax", "");
                                }
                                if (filename1[ii].Contains(".act"))
                                {
                                    filename = filename1[ii].Replace(".act", "");
                                }
                                if (filename1[ii].Contains(".aiff"))
                                {
                                    filename = filename1[ii].Replace(".aiff", "");
                                }
                                if (filename1[ii].Contains(".amr"))
                                {
                                    filename = filename1[ii].Replace(".amr", "");
                                }
                                if (filename1[ii].Contains(".ape"))
                                {
                                    filename = filename1[ii].Replace(".ape", "");
                                }
                                if (filename1[ii].Contains(".au"))
                                {
                                    filename = filename1[ii].Replace(".au", "");
                                }
                                if (filename1[ii].Contains(".awb"))
                                {
                                    filename = filename1[ii].Replace(".awb", "");
                                }
                                if (filename1[ii].Contains(".dct"))
                                {
                                    filename = filename1[ii].Replace(".dct", "");
                                }
                                if (filename1[ii].Contains(".dss"))
                                {
                                    filename = filename1[ii].Replace(".dss", "");
                                }
                                if (filename1[ii].Contains(".dvf"))
                                {
                                    filename = filename1[ii].Replace(".dvf", "");
                                }
                                if (filename1[ii].Contains(".flac"))
                                {
                                    filename = filename1[ii].Replace(".flac", "");
                                }
                                if (filename1[ii].Contains(".gsm"))
                                {
                                    filename = filename1[ii].Replace(".gsm", "");
                                }

                                if (filename1[ii].Contains(".iklax"))
                                {
                                    filename = filename1[ii].Replace(".iklax", "");
                                }
                                if (filename1[ii].Contains(".ivs"))
                                {
                                    filename = filename1[ii].Replace(".ivs", "");
                                }
                                if (filename1[ii].Contains(".m4a"))
                                {
                                    filename = filename1[ii].Replace(".m4a", "");
                                }
                                if (filename1[ii].Contains(".m4b"))
                                {
                                    filename = filename1[ii].Replace(".m4b", "");
                                }
                                if (filename1[ii].Contains(".mmf"))
                                {
                                    filename = filename1[ii].Replace(".mmf", "");
                                }
                                if (filename1[ii].Contains(".mp3"))
                                {
                                    filename = filename1[ii].Replace(".mp3", "");
                                }
                                if (filename1[ii].Contains(".mpc"))
                                {
                                    filename = filename1[ii].Replace(".mpc", "");
                                }
                                if (filename1[ii].Contains(".ogg"))
                                {
                                    filename = filename1[ii].Replace(".ogg", "");
                                }
                                if (filename1[ii].Contains(".oga"))
                                {
                                    filename = filename1[ii].Replace(".oga", "");
                                }
                                if (filename1[ii].Contains(".mogg"))
                                {
                                    filename = filename1[ii].Replace(".mogg", "");
                                }
                                if (filename1[ii].Contains(".opus"))
                                {
                                    filename = filename1[ii].Replace(".opus", "");
                                }
                                if (filename1[ii].Contains(".ra"))
                                {
                                    filename = filename1[ii].Replace(".rm", "");
                                }
                                if (filename1[ii].Contains(".raw"))
                                {
                                    filename = filename1[ii].Replace(".raw", "");
                                }
                                if (filename1[ii].Contains(".sln"))
                                {
                                    filename = filename1[ii].Replace(".sln", "");
                                }
                                if (filename1[ii].Contains(".tta"))
                                {
                                    filename = filename1[ii].Replace(".tta", "");
                                }

                                if (filename1[ii].Contains(".vox"))
                                {
                                    filename = filename1[ii].Replace(".vox", "");
                                }
                                if (filename1[ii].Contains(".wav"))
                                {
                                    filename = filename1[ii].Replace(".wav", "");
                                }
                                if (filename1[ii].Contains(".wma"))
                                {
                                    filename = filename1[ii].Replace(".wma", "");
                                }
                                if (filename1[ii].Contains(".wv"))
                                {
                                    filename = filename1[ii].Replace(".wv", "");
                                }
                                if (filename1[ii].Contains(".webm"))
                                {
                                    filename = filename1[ii].Replace(".webm", "");
                                }
                                if (filename1[ii].Contains(".8svx"))
                                {
                                    filename = filename1[ii].Replace(".8svs", "");
                                }
                            }
                            ////
                            if (htmlstrings[i].Contains(".3gp"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".3gp");
                                path2 = (@dlfolderpath + @"\" + i + ".3gp");
                            }
                            if (htmlstrings[i].Contains(".aa"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".aa");
                                path2 = (@dlfolderpath + @"\" + i + ".aa");
                            }
                            if (htmlstrings[i].Contains(".aac"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".aac");
                                path2 = (@dlfolderpath + @"\" + i + ".aac");
                            }
                            if (htmlstrings[i].Contains(".aax"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".aax");
                                path2 = (@dlfolderpath + @"\" + i + ".aac");
                            }
                            if (htmlstrings[i].Contains(".act"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".act");
                                path2 = (@dlfolderpath + @"\" + i + ".act");
                            }
                            if (htmlstrings[i].Contains(".aiff"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".aiff");
                                path2 = (@dlfolderpath + @"\" + i + ".aiff");
                            }
                            if (htmlstrings[i].Contains(".amr"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".amr");
                                path2 = (@dlfolderpath + @"\" + i + ".amr");
                            }
                            if (htmlstrings[i].Contains(".ape"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".ape");
                                path2 = (@dlfolderpath + @"\" + i + ".ape");
                            }
                            if (htmlstrings[i].Contains(".au"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".au");
                                path2 = (@dlfolderpath + @"\" + i + ".au");
                            }
                            if (htmlstrings[i].Contains(".awb"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".awb");
                                path2 = (@dlfolderpath + @"\" + i + ".awb");
                            }
                            if (htmlstrings[i].Contains(".dct"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".dct");
                                path2 = (@dlfolderpath + @"\" + i + ".dct");
                            }
                            if (htmlstrings[i].Contains(".dss"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".dss");
                                path2 = (@dlfolderpath + @"\" + i + ".dss");
                            }
                            if (htmlstrings[i].Contains(".dvf"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".dvf");
                                path2 = (@dlfolderpath + @"\" + i + ".dvf");
                            }
                            if (htmlstrings[i].Contains(".flac"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".flac");
                                path2 = (@dlfolderpath + @"\" + i + ".flac");
                            }
                            if (htmlstrings[i].Contains(".gsm"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".gsm");
                                path2 = (@dlfolderpath + @"\" + i + ".gsm");
                            }
                            if (htmlstrings[i].Contains(".iklax"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".iklax");
                                path2 = (@dlfolderpath + @"\" + i + ".iklax");

                            }
                            if (htmlstrings[i].Contains(".ivs"));
                            {
                                path = (@dlfolderpath + @"\" + filename + ".ivs");
                                path2 = (@dlfolderpath + @"\" + i + ".ivs");
                            }
                            if (htmlstrings[i].Contains(".m4a"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m4a");
                                path2 = (@dlfolderpath + @"\" + i + ".m4a");
                            }
                            if (htmlstrings[i].Contains(".m4b"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m4b");
                                path2 = (@dlfolderpath + @"\" + i + ".m4b");
                            }
                            if (htmlstrings[i].Contains(".mmf"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mmf");
                                path2 = (@dlfolderpath + @"\" + i + ".mmf");
                            }
                            if (htmlstrings[i].Contains(".mp3"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mp3");
                                path2 = (@dlfolderpath + @"\" + i + ".mp3");
                            }
                            if (htmlstrings[i].Contains(".mpc"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpc");
                                path2 = (@dlfolderpath + @"\" + i + ".mpc");
                            }
                            if (htmlstrings[i].Contains(".msv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".msv");
                                path2 = (@dlfolderpath + @"\" + i + ".msv");
                            }
                            if (htmlstrings[i].Contains(".ogg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".ogg");
                                path2 = (@dlfolderpath + @"\" + i + ".ogg");
                            }
                            if (htmlstrings[i].Contains(".oga"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".oga");
                                path2 = (@dlfolderpath + @"\" + i + ".oga");
                            }
                            if (htmlstrings[i].Contains(".mogg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mogg");
                                path2 = (@dlfolderpath + @"\" + i + ".mogg");
                            }
                            if (htmlstrings[i].Contains(".opus"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".opus");
                                path2 = (@dlfolderpath + @"\" + i + ".opus");
                            }
                            if (htmlstrings[i].Contains(".ra"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".ra");
                                path2 = (@dlfolderpath + @"\" + i + ".ra");
                            }
                            if (htmlstrings[i].Contains(".rm"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".rm");
                                path2 = (@dlfolderpath + @"\" + i + ".rm");
                            }
                            if (htmlstrings[i].Contains(".raw"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".raw");
                                path2 = (@dlfolderpath + @"\" + i + ".raw");
                            }
                            if (htmlstrings[i].Contains(".sln"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".sln");
                                path2 = (@dlfolderpath + @"\" + i + ".dln");
                            }
                            if (htmlstrings[i].Contains(".tta"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".tta");
                                path2 = (@dlfolderpath + @"\" + i + ".tta");
                            }
                            if (htmlstrings[i].Contains(".vox"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".vox");
                                path2 = (@dlfolderpath + @"\" + i + ".vox");

                            }
                            if (htmlstrings[i].Contains(".wav"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".wav");
                                path2 = (@dlfolderpath + @"\" + i + ".wav");
                            }
                            if (htmlstrings[i].Contains(".wma"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".wma");
                                path2 = (@dlfolderpath + @"\" + i + ".wma");
                            }
                            if (htmlstrings[i].Contains(".wv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".wv");
                                path2 = (@dlfolderpath + @"\" + i + ".wv");
                            }
                            if (htmlstrings[i].Contains(".webm"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".webm");
                                path2 = (@dlfolderpath + @"\" + i + ".webm");
                            }
                            if (htmlstrings[i].Contains(".8svx"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".8svx");
                                path2 = (@dlfolderpath + @"\" + i + ".8svx");
                            }


                            string path1 = (@path.Replace(@"\\", @"\"));
                            try
                            {
                                if (array4.Contains(filename) == false)
                                {
                                    webClient.DownloadFile(htmlstrings[i], @path1.Replace(@"\\", @"\"));
                                    tries++;
                                }
                            }
                            catch
                            {
                                try
                                {
                                    if (array4.Contains(filename) == false)
                                    {
                                        webClient.DownloadFile(htmlstrings[i], @path2.Replace(@"\\", @"\"));
                                        tries++;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine(@path1.Replace(@"\\", @"\"));
                                    errors++;
                                }
                                
                            }
                            Array.Resize(ref array4, array4.Length + 1);
                            array4[array4.Length - 1] = filename;
                        }

                    }
                    System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount1 = dir.GetFiles().Length;
                    MessageBox.Show("Completed with" + errors + " errors " + "and " + (filecount1 - filecount) + " successful");

                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button6.ForeColor = Color.Black; });
                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button6.Text = "Audio"; });

                    System.Diagnostics.Process.Start(dlfolderpath);
                });
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string filename = "";
            int i1 = 0;
            int strcount = 0;
            string html = "";
            string url = "";
            bool linkgud1 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud1 = true;
            }
            catch
            {
                linkgud1 = false;
            }

            if (linkgud1 == true)
            {
                string path = "";
                Task.Run(() =>
                {
                    string urll = textBox1.Text;
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(urll);
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                    html = streamrdr.ReadToEnd();
                    Char del = '"';
                    String[] htmlstrings = html.Split(del);
                    WebClient webClient = new WebClient();
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount = dir.GetFiles().Length;
                    for (int i = 0; i < htmlstrings.Length; i++)
                    {
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button8.ForeColor = Color.Red; });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button8.Text = "Downloading"; });

                        if (htmlstrings[i].Contains("."))
                        {
                            if (array.Contains(htmlstrings[i]) == false)
                            {
                                try
                                {
                                    WebClient wc = new WebClient();
                                    string HTMLSource = wc.DownloadString(htmlstrings[i]);
                                    linkgud = true;
                                }
                                catch
                                {
                                    linkgud = false;
                                }

                                if (linkgud == true)
                                {
                                    int num = i;
                                    Console.WriteLine(num);
                                    Array.Resize(ref array, array.Length + 1);
                                    array[array.Length - 1] = htmlstrings[i];
                                }

                            }

                        }
                    }
                    //
                    
                    try
                    {
                        
                            path = @dlfolderpath + @"\" + "LINKS" + ".txt";
                            File.WriteAllLines(@path.Replace(@"\\", @"\"), array, Encoding.UTF8);

                            tries++;
                        
                    }
                    catch
                    {
                        
                        errors++;
                    }
                    




                    //
                    

                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button8.ForeColor = Color.Black; });
                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button8.Text = "Links"; });

                    System.Diagnostics.Process.Start(dlfolderpath);
                });
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = "";
            string filename = "";
            int i1 = 0;
            int strcount = 0;
            string html = "";
            
            bool linkgud8 = false;
            try
            {
                WebClient wc = new WebClient();
                string HTMLSource = wc.DownloadString(textBox1.Text);
                linkgud8 = true;
            }
            catch
            {
                linkgud8 = false;
            }

            if (linkgud8 == true)
            {
                Task.Run(() =>
                {

                    //Store and read html to look for image paths
                    string url = textBox1.Text;
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    StreamReader streamrdr = new StreamReader(webres.GetResponseStream());
                    html = streamrdr.ReadToEnd();
                    Console.WriteLine(html);
                    Char del = '"';
                    String[] htmlstrings = html.Split(del);
                    WebClient webClient = new WebClient();
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount = dir.GetFiles().Length;
                    for (int i = 0; i < htmlstrings.Length; i++)
                    {
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.ForeColor = Color.Red; });
                        this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.Text = "Downloading"; });

                        if (htmlstrings[i].Contains(".webm") || htmlstrings[i].Contains(".mkv") || htmlstrings[i].Contains(".flv") || htmlstrings[i].Contains(".vob") || htmlstrings[i].Contains(".ogv") || htmlstrings[i].Contains(".ogg") || htmlstrings[i].Contains(".drc") || htmlstrings[i].Contains(".gif") || htmlstrings[i].Contains(".gifv") || htmlstrings[i].Contains(".mng") || htmlstrings[i].Contains(".avi") || htmlstrings[i].Contains(".mov") || htmlstrings[i].Contains(".qt") || htmlstrings[i].Contains(".wmv") || htmlstrings[i].Contains(".yuv") || htmlstrings[i].Contains(".rm") || htmlstrings[i].Contains(".rmvb") || htmlstrings[i].Contains(".asf") || htmlstrings[i].Contains(".amv") || htmlstrings[i].Contains(".mp4") || htmlstrings[i].Contains(".m4p") || htmlstrings[i].Contains(".m4v") || htmlstrings[i].Contains(".mpg") || htmlstrings[i].Contains(".mp2") || htmlstrings[i].Contains(".mpeg") || htmlstrings[i].Contains(".mpe") || htmlstrings[i].Contains(".mpv") || htmlstrings[i].Contains(".mpg") || htmlstrings[i].Contains(".mpeg") || htmlstrings[i].Contains(".m2v") || htmlstrings[i].Contains(".m4v") || htmlstrings[i].Contains(".svi") || htmlstrings[i].Contains(".3gp") || htmlstrings[i].Contains(".3g2") || htmlstrings[i].Contains(".mxf") || htmlstrings[i].Contains(".roq") || htmlstrings[i].Contains(".nsv") || htmlstrings[i].Contains(".flv") || htmlstrings[i].Contains(".f4v") || htmlstrings[i].Contains(".f4p") || htmlstrings[i].Contains(".f4a") || htmlstrings[i].Contains(".f4b"))
                        {
                            char deli = '/';
                            String[] filename1 = htmlstrings[i].Split(deli);
                            for (int ii = 0; ii < filename1.Length; ii++)
                            {
                                if (filename1[ii].Contains(".webm"))
                                {
                                    filename = filename1[ii].Replace(".webm", "");
                                }
                                if (filename1[ii].Contains("mkv"))
                                {
                                    filename = filename1[ii].Replace("mkv", "");
                                }
                                if (filename1[ii].Contains(".flv"))
                                {
                                    filename = filename1[ii].Replace(".flv", "");
                                }
                                if (filename1[ii].Contains(".vob"))
                                {
                                    filename = filename1[ii].Replace(".vob", "");
                                }
                                if (filename1[ii].Contains(".ogv"))
                                {
                                    filename = filename1[ii].Replace(".ogv", "");
                                }
                                if (filename1[ii].Contains(".ogg"))
                                {
                                    filename = filename1[ii].Replace(".ogg", "");
                                }
                                if (filename1[ii].Contains(".drc"))
                                {
                                    filename = filename1[ii].Replace(".drc", "");
                                }
                                if (filename1[ii].Contains(".gif"))
                                {
                                    filename = filename1[ii].Replace(".gif", "");
                                }
                                if (filename1[ii].Contains(".gifv"))
                                {
                                    filename = filename1[ii].Replace(".gifv", "");
                                }
                                if (filename1[ii].Contains(".mng"))
                                {
                                    filename = filename1[ii].Replace(".mng", "");
                                }
                                if (filename1[ii].Contains(".avi"))
                                {
                                    filename = filename1[ii].Replace(".avi", "");
                                }
                                if (filename1[ii].Contains(".mov"))
                                {
                                    filename = filename1[ii].Replace(".mov", "");
                                }
                                if (filename1[ii].Contains(".qt"))
                                {
                                    filename = filename1[ii].Replace(".qt", "");
                                }
                                if (filename1[ii].Contains(".wmv"))
                                {
                                    filename = filename1[ii].Replace(".wmv", "");
                                }
                                if (filename1[ii].Contains(".yuv"))
                                {
                                    filename = filename1[ii].Replace(".yuv", "");
                                }




                                if (filename1[ii].Contains("rm"))
                                {
                                    filename = filename1[ii].Replace("rm", "");
                                }
                                if (filename1[ii].Contains(".rmvb"))
                                {
                                    filename = filename1[ii].Replace(".rmvb", "");
                                }
                                if (filename1[ii].Contains(".asf"))
                                {
                                    filename = filename1[ii].Replace(".asf", "");
                                }
                                if (filename1[ii].Contains(".amv"))
                                {
                                    filename = filename1[ii].Replace(".amv", "");
                                }
                                if (filename1[ii].Contains(".mp4"))
                                {
                                    filename = filename1[ii].Replace(".mp4", "");
                                }
                                if (filename1[ii].Contains(".m4p"))
                                {
                                    filename = filename1[ii].Replace(".m4p", "");
                                }
                                if (filename1[ii].Contains(".m4v"))
                                {
                                    filename = filename1[ii].Replace(".m4v", "");
                                }
                                if (filename1[ii].Contains(".mpg"))
                                {
                                    filename = filename1[ii].Replace(".mpg", "");
                                }
                                if (filename1[ii].Contains(".mp2"))
                                {
                                    filename = filename1[ii].Replace(".mp2", "");
                                }
                                if (filename1[ii].Contains(".mpeg"))
                                {
                                    filename = filename1[ii].Replace(".mpeg", "");
                                }
                                if (filename1[ii].Contains(".mpe"))
                                {
                                    filename = filename1[ii].Replace(".mpe", "");
                                }
                                if (filename1[ii].Contains(".mpv"))
                                {
                                    filename = filename1[ii].Replace(".mpv", "");
                                }
                                if (filename1[ii].Contains(".mpg"))
                                {
                                    filename = filename1[ii].Replace(".mpg", "");
                                }
                                if (filename1[ii].Contains(".mpeg"))
                                {
                                    filename = filename1[ii].Replace(".mpeg", "");
                                }


                                if (filename1[ii].Contains(".m2v"))
                                {
                                    filename = filename1[ii].Replace(".m2v", "");
                                }
                                if (filename1[ii].Contains(".m4v"))
                                {
                                    filename = filename1[ii].Replace(".m4v", "");
                                }
                                if (filename1[ii].Contains(".svi"))
                                {
                                    filename = filename1[ii].Replace(".svi", "");
                                }
                                if (filename1[ii].Contains(".3gp"))
                                {
                                    filename = filename1[ii].Replace(".3gp", "");
                                }
                                if (filename1[ii].Contains(".3g2"))
                                {
                                    filename = filename1[ii].Replace(".3g2", "");
                                }
                                if (filename1[ii].Contains(".mxf"))
                                {
                                    filename = filename1[ii].Replace(".mxf", "");
                                }
                                if (filename1[ii].Contains(".roq"))
                                {
                                    filename = filename1[ii].Replace(".roq", "");
                                }


                                if (filename1[ii].Contains(".nsv"))
                                {
                                    filename = filename1[ii].Replace(".nsv", "");
                                }
                                if (filename1[ii].Contains(".flv"))
                                {
                                    filename = filename1[ii].Replace(".flv", "");
                                }
                                if (filename1[ii].Contains(".f4v"))
                                {
                                    filename = filename1[ii].Replace(".f4v", "");
                                }
                                if (filename1[ii].Contains(".f4p"))
                                {
                                    filename = filename1[ii].Replace(".f4p", "");
                                }
                                if (filename1[ii].Contains(".f4a"))
                                {
                                    filename = filename1[ii].Replace(".f4a", "");
                                }
                                if (filename1[ii].Contains(".f4b"))
                                {
                                    filename = filename1[ii].Replace(".f4b", "");
                                }
                                
                            }

                            if (htmlstrings[i].Contains(".webm"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".webm");
                            }
                            if (htmlstrings[i].Contains(".mkv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mkv");
                            }
                            if (htmlstrings[i].Contains(".flv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".flv");
                            }
                            if (htmlstrings[i].Contains(".vob"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".vob");
                            }
                            if (htmlstrings[i].Contains(".ogv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".ogg");
                            }
                            if (htmlstrings[i].Contains(".drc"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".drc");
                            }
                            if (htmlstrings[i].Contains(".gif"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".gif");
                            }
                            if (htmlstrings[i].Contains(".gifv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".jiff");
                            }
                            if (htmlstrings[i].Contains(".mng"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mng");
                            }
                            if (htmlstrings[i].Contains(".avi"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".avi");
                            }
                            if (htmlstrings[i].Contains(".mov"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mov");
                            }
                            if (htmlstrings[i].Contains(".qt"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".qt");
                            }
                            if (htmlstrings[i].Contains(".wmv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".wmv");
                            }
                            if (htmlstrings[i].Contains(".yuv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".yuv");
                            }
                            if (htmlstrings[i].Contains(".rm"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".rm");
                            }
                            if (htmlstrings[i].Contains(".rmvb"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".rmvb");

                            }
                            if (htmlstrings[i].Contains(".asf"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".asf");
                            }
                            if (htmlstrings[i].Contains(".amv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".amv");
                            }
                            if (htmlstrings[i].Contains(".mp4"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mp4");
                            }
                            if (htmlstrings[i].Contains(".m4p"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m4p");
                            }
                            if (htmlstrings[i].Contains(".m4v"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m4v");
                            }
                            if (htmlstrings[i].Contains(".mpg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpg");
                            }
                            if (htmlstrings[i].Contains(".mp2"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mp2");
                            }
                            if (htmlstrings[i].Contains(".mpeg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpeg");
                            }
                            if (htmlstrings[i].Contains(".mpe"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpe");
                            }
                            if (htmlstrings[i].Contains(".mpv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpv");
                            }
                            if (htmlstrings[i].Contains(".mpg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpg");
                            }
                            if (htmlstrings[i].Contains(".mpeg"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mpeg");
                            }
                            if (htmlstrings[i].Contains(".m2v"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m2v");
                            }
                            if (htmlstrings[i].Contains(".m4v"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".m4v");
                            }
                            if (htmlstrings[i].Contains(".svi"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".svi");
                            }
                            if (htmlstrings[i].Contains(".3gp"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".3gp");

                            }



                            if (htmlstrings[i].Contains(".3g2"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".3g2");
                            }
                            if (htmlstrings[i].Contains(".mxf"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".mxf");
                            }
                            if (htmlstrings[i].Contains(".roq"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".roq");
                            }
                            if (htmlstrings[i].Contains(".nsv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".nsv");
                            }
                            if (htmlstrings[i].Contains(".flv"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".flv");
                            }
                            if (htmlstrings[i].Contains(".f4v"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".f4v");
                            }
                            if (htmlstrings[i].Contains(".f4p"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".f4p");
                            }
                            if (htmlstrings[i].Contains(".f4a"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".f4a");
                            }
                            if (htmlstrings[i].Contains(".f4b"))
                            {
                                path = (@dlfolderpath + @"\" + filename + ".f4b");
                            }


                            string path1 = (@path.Replace(@"\\", @"\"));
                            try
                            {
                                if (array5.Contains(filename) == false)
                                {
                                    webClient.DownloadFile(htmlstrings[i], @path1.Replace(@"\\", @"\"));
                                    tries++;
                                }
                            }
                            catch
                            {
                                Console.WriteLine(@path1.Replace(@"\\", @"\"));
                                errors++;
                            }
                            Array.Resize(ref array5, array5.Length + 1);
                            array5[array5.Length - 1] = filename;
                        }

                    }
                    System.IO.DirectoryInfo dir1 = new System.IO.DirectoryInfo(dlfolderpath);
                    int filecount1 = dir.GetFiles().Length;
                    MessageBox.Show("Completed wit h" + errors + " errors " + "and " + (filecount1 - filecount) + " successful");

                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.ForeColor = Color.Black; });
                    this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate () { button10.Text = "Video"; });

                    System.Diagnostics.Process.Start(dlfolderpath);
                });
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vid();
        }
    }
}
