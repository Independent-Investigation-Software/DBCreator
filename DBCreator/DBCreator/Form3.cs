using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DBCreator
{
    public partial class Form3 : Form
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

        public Form3()
        {
            InitializeComponent();
            FormClosed += Form3_FormClosed;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
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

        private void trafficDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Choose an old record.";
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.ShowDialog();
            TextReader file = new StreamReader(open.FileName);
            int lines = 14;
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

        private void peopleDataToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(Convert.ToInt32(textBox1.Text));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (oneExists && File.Exists(Directory.GetCurrentDirectory() + "\\one\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\one\\" + "load.png";
            }
            if (twoExists && File.Exists(Directory.GetCurrentDirectory() + "\\two\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\two\\" + "load.png";
            }
            if (threeExists && File.Exists(Directory.GetCurrentDirectory() + "\\three\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\three\\" + "load.png";
            }
            if (fourExists && File.Exists(Directory.GetCurrentDirectory() + "\\four\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\four\\" + "load.png";
            }
            if (fiveExists && File.Exists(Directory.GetCurrentDirectory() + "\\five\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\five\\" + "load.png";
            }
            if (sixExists && File.Exists(Directory.GetCurrentDirectory() + "\\six\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\six\\" + "load.png";
            }
            if (sevenExists && File.Exists(Directory.GetCurrentDirectory() + "\\seven\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\seven\\" + "load.png";
            }
            if (eightExists && File.Exists(Directory.GetCurrentDirectory() + "\\eight\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\eight\\" + "load.png";
            }
            if (nineExists && File.Exists(Directory.GetCurrentDirectory() + "\\nine\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\nine\\" + "load.png";
            }
            if (tenExists && File.Exists(Directory.GetCurrentDirectory() + "\\ten\\" + "load.png"))
            {
                pictureBox3.ImageLocation = Directory.GetCurrentDirectory() + "\\ten\\" + "load.png";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog();
            picture.Title = "Please grab a picture of the POI for the 'loading' image.";
            picture.Filter = "PNG (.png)|*.png|JPG (.JPG)|*.JPG";
            picture.InitialDirectory = Directory.GetCurrentDirectory();
            picture.ShowDialog();
            pictureBox1.ImageLocation = picture.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oneClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\one\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\one\\load.png");
            }
            if (twoClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\two\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\two\\load.png");
            }
            if (threeClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\three\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\three\\load.png");
            }
            if (fourClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\four");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\four\\load.png");
            }
            if (fiveClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\five\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\five\\load.png");
            }
            if (sixClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\six\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\six\\load.png");
            }
            if (sevenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\seven\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\seven\\load.png");
            }
            if (eightClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\eight\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\eight\\load.png");
            }
            if (nineClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\nine\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\nine\\load.png");
            }
            if (tenClicked)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ten\\");
                pictureBox1.Image.Save(Directory.GetCurrentDirectory() + "\\ten\\load.png");
            }
            else
            {
                MessageBox.Show("Please select a POI before saving image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
