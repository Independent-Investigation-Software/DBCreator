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
            //button1.Text = "Create a '" + label3.Text + "' folder.";
            //button2.Text = "Save to '" + label3.Text + "' folder.";
            //button1.Enabled = true;
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
    }
}
