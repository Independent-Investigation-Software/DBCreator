using DBCreator;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DBCreator
{
    public partial class Form1 : Form
    {
        bool oneExists = false;
        bool twoExists = false;
        bool threeExists = false;
        bool fourExists = false;
        bool fiveExists = false;
        bool sixExists = false;
        bool sevenExists = false;
        bool eightExists = false;
        bool nineExists = false;
        bool tenExists = false;

        bool oneClicked = false;
        bool twoClicked = false;
        bool threeClicked = false;
        bool fourClicked = false;
        bool fiveClicked = false;
        bool sixClicked = false;
        bool sevenClicked = false;
        bool eightClicked = false;
        bool nineClicked = false;
        bool tenClicked = false;

        public Form1()
        {
            InitializeComponent();
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void peopleDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peopleToolStripMenuItem.DropDownItems.Count < 1)
            {
                MessageBox.Show("Please create a person.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void one_Click(object sender, EventArgs e)
        {
            oneClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one\\one.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2] + Environment.NewLine, ListLines[3] + Environment.NewLine, ListLines[4] + Environment.NewLine, ListLines[5] + Environment.NewLine, ListLines[6] + Environment.NewLine, ListLines[7] + Environment.NewLine, ListLines[8]);
        }

        private void two_click(object sender, EventArgs e)
        {
            twoClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two\\two.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void three_click(object sender, EventArgs e)
        {
            threeClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three\\three.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void four_click(object sender, EventArgs e)
        {
            fourClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four\\four.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void five_click(object sender, EventArgs e)
        {
            fiveClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five\\five.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void six_click(object sender, EventArgs e)
        {
            sixClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six\\six.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void seven_click(object sender, EventArgs e)
        {
            sevenClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven\\seven.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void eight_click(object sender, EventArgs e)
        {
            eightClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight\\eight.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void nine_click(object sender, EventArgs e)
        {
            nineClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine\\nine.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void ten_click(object sender, EventArgs e)
        {
            tenClicked = true;
            TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten\\ten.txt");
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Add(ListLines[1], Environment.NewLine + ListLines[2], Environment.NewLine + ListLines[3], Environment.NewLine + ListLines[4], Environment.NewLine + ListLines[5], Environment.NewLine + ListLines[6], Environment.NewLine + ListLines[7], Environment.NewLine + ListLines[8], Environment.NewLine + ListLines[9]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oneExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\one\\one.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("1. " + ListLines[2]).Click += one_Click;
                }
                oneExists = true;
            }
            if (twoExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\two\\two.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("2. " + ListLines[2]).Click += two_click;
                }
                twoExists = true;
            }
            if (threeExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\three.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("3. " + ListLines[2]).Click += three_click;
                }
                threeExists = true;
            }
            if (fourExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\four\\four.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("4. " + ListLines[2]).Click += four_click;
                }
                fourExists = true;
            }
            if (fiveExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\five\\five.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("5. " + ListLines[2]).Click += five_click;
                }
                fiveExists = true;
            }
            if (sixExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\six.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("6. " + ListLines[2]).Click += six_click;
                }
                sixExists = true;
            }
            if (sevenExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\seven\\seven.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\seven\\seven.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("7. " + ListLines[2]).Click += seven_click;
                }
                sevenExists = true;
            }
            if (eightExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\eight\\eight.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\eight\\eight.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("8. " + ListLines[2]).Click += eight_click;
                }
                eightExists = true;
            }
            if (nineExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\nine\\nine.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\nine\\nine.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("9. " + ListLines[2]).Click += nine_click;
                }
                nineExists = true;
            }
            if (tenExists != true)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\ten\\ten.txt"))
                {
                    TextReader file = new StreamReader(Directory.GetCurrentDirectory() + "\\ten\\ten.txt");
                    int lines = 9;
                    string[] ListLines = new string[lines];
                    for (int i = 1; i < lines; i++)
                    {
                        ListLines[i] = file.ReadLine();
                    }
                    peopleToolStripMenuItem.DropDownItems.Add("10. " + ListLines[2]).Click += ten_click;
                }
                tenExists = true;
            }
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose an old record.";
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.ShowDialog();
            TextReader file = new StreamReader(open.FileName);
            int lines = 9;
            string[] ListLines = new string[lines];
            for (int i = 1; i < lines; i++)
            {
                ListLines[i] = file.ReadLine();
            }
            dataGridView1.Rows.Insert(1, ListLines[1]);
            dataGridView1.Rows.Insert(1, ListLines[2]);
            dataGridView1.Rows.Insert(1, ListLines[3]);
            dataGridView1.Rows.Insert(1, ListLines[4]);
            dataGridView1.Rows.Insert(1, ListLines[5]);
            dataGridView1.Rows.Insert(1, ListLines[6]);
            dataGridView1.Rows.Insert(1, ListLines[7]);
            dataGridView1.Rows.Insert(1, ListLines[8]);
            dataGridView1.Rows.Insert(1, ListLines[9]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "POI Image";
            file.Filter = "PNG (.png)|*.png|JPG (.JPG)|*.JPG";
            file.InitialDirectory = Directory.GetCurrentDirectory();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "POI Image";
            file.Filter = "PNG (.png)|*.png|JPG (.JPG)|*.JPG";
            file.InitialDirectory = Directory.GetCurrentDirectory();
            file.ShowDialog();
            pictureBox3.ImageLocation = file.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "POI Image";
            file.Filter = "PNG (.png)|*.png|JPG (.JPG)|*.JPG";
            file.InitialDirectory = Directory.GetCurrentDirectory();
            file.ShowDialog();
            pictureBox2.ImageLocation = file.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oneClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\one\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\one\\load1.png");
            }
            if (twoClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\two\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\two\\load1.png");
            }
            if (threeClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\three\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\three\\load1.png");
            }
            if (fourClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\four");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\four\\load1.png");
            }
            if (fiveClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\five\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\five\\load1.png");
            }
            if (sixClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\six\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\six\\load1.png");
            }
            if (sevenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\seven\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\seven\\load1.png");
            }
            if (eightClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\eight\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\eight\\load1.png");
            }
            if (nineClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\nine\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\nine\\load1.png");
            }
            if (tenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ten\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\ten\\load1.png");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (oneExists && File.Exists(Directory.GetCurrentDirectory() + "\\one\\" + "load1.png") && oneClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\one\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\one\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\one\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\one\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\one\\" + "load3.png";
                    }
                }
            }
            if (twoExists && File.Exists(Directory.GetCurrentDirectory() + "\\two\\" + "load1.png") && twoClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\two\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\two\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\two\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\two\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\two\\" + "load3.png";
                    }
                }
            }
            if (threeExists && File.Exists(Directory.GetCurrentDirectory() + "\\three\\" + "load1.png") && threeClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\three\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\three\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\three\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\three\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\three\\" + "load3.png";
                    }
                }
            }
            if (fourExists && File.Exists(Directory.GetCurrentDirectory() + "\\four\\" + "load1.png") && fourClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\four\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\four\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\four\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\four\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\four\\" + "load3.png";
                    }
                }
            }
            if (fiveExists && File.Exists(Directory.GetCurrentDirectory() + "\\five\\" + "load1.png") && fiveClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\five\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\five\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\five\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\five\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\five\\" + "load3.png";
                    }
                }
            }
            if (sixExists && File.Exists(Directory.GetCurrentDirectory() + "\\six\\" + "load1.png") && sixClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\six\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\six\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\six\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\six\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\six\\" + "load3.png";
                    }
                }
            }
            if (sevenExists && File.Exists(Directory.GetCurrentDirectory() + "\\seven\\" + "load1.png") && sevenClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\seven\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\seven\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\seven\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\seven\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\seven\\" + "load3.png";
                    }
                }
            }
            if (eightExists && File.Exists(Directory.GetCurrentDirectory() + "\\eight\\" + "load1.png") && eightClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\eight\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\eight\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\eight\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\eight\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\eight\\" + "load3.png";
                    }
                }
            }
            if (nineExists && File.Exists(Directory.GetCurrentDirectory() + "\\nine\\" + "load1.png") && nineClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\nine\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\nine\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\nine\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\nine\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\nine\\" + "load3.png";
                    }
                }
            }
            if (tenExists && File.Exists(Directory.GetCurrentDirectory() + "\\ten\\" + "load1.png") && tenClicked)
            {
                pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + "\\ten\\" + "load1.png";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\ten\\" + "load2.png"))
                {
                    pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + "\\ten\\" + "load2.png";
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\ten\\" + "load3.png"))
                    {
                        pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\ten\\" + "load3.png";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oneClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\one\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\one\\load2.png");
            }
            if (twoClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\two\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\two\\load2.png");
            }
            if (threeClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\three\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\three\\load2.png");
            }
            if (fourClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\four");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\four\\load2.png");
            }
            if (fiveClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\five\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\five\\load2.png");
            }
            if (sixClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\six\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\six\\load2.png");
            }
            if (sevenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\seven\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\seven\\load2.png");
            }
            if (eightClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\eight\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\eight\\load2.png");
            }
            if (nineClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\nine\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\nine\\load2.png");
            }
            if (tenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ten\\");
                pictureBox2.Image.Save(Directory.GetCurrentDirectory() + "\\ten\\load2.png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oneClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\one\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\one\\load3.png");
            }
            if (twoClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\two\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\two\\load3.png");
            }
            if (threeClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\three\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\three\\load3.png");
            }
            if (fourClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\four");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\four\\load3.png");
            }
            if (fiveClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\five\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\five\\load3.png");
            }
            if (sixClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\six\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\six\\load3.png");
            }
            if (sevenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\seven\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\seven\\load3.png");
            }
            if (eightClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\eight\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\eight\\load3.png");
            }
            if (nineClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\nine\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\nine\\load3.png");
            }
            if (tenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ten\\");
                pictureBox3.Image.Save(Directory.GetCurrentDirectory() + "\\ten\\load3.png");
            }
        }
    }
}
