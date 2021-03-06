using System;
using System.IO;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace DBCreator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("African american");
            comboBox1.Items.Add("Caucasian/White person");
            comboBox1.Items.Add("Americans");
            comboBox1.Items.Add("Native americans of U.S.");
            comboBox1.Items.Add("Asian people");
            comboBox1.Items.Add("Alaska natives");
            comboBox1.Items.Add("Hispanic/Latino americans");
            comboBox1.Items.Add("Pacific islander");
            comboBox1.Items.Add("Black people");
            comboBox1.Items.Add("Native hawaiians");
            comboBox1.Items.Add("Pacific islander americans");
            comboBox1.Items.Add("Non-hispanic whites");
            comboBox1.Items.Add("Purerto ricans");
            comboBox1.Items.Add("Multi-racial people");
            comboBox1.Items.Add("Jewish people");
            comboBox1.Items.Add("Asian americans");
            comboBox1.Items.Add("Mexicans");
            comboBox1.Items.Add("Hispanic");
            comboBox1.Items.Add("Romzni people");
            comboBox1.Items.Add("Han chinese");
            comboBox1.Items.Add("Black hispanic and latino americans");
            comboBox1.Items.Add("White hispanic and latino americnas");
            comboBox1.Items.Add("Indigenous peoples of americas");
            comboBox1.Items.Add("Kurds");
            comboBox1.Items.Add("Irish people");
            comboBox1.Items.Add("Koreans");
            comboBox1.Items.Add("Arabs");
            comboBox1.Items.Add("Uyghurs");
            comboBox1.Items.Add("Arabs");
            comboBox1.Items.Add("Spaniards");
            comboBox1.Items.Add("Multiracial americans");
            comboBox1.Items.Add("Assyrian people");
            comboBox1.Items.Add("White americans");
            comboBox1.Items.Add("Irish travellers");
            comboBox1.Items.Add("Hmong people");
            comboBox1.Items.Add("French canadians");
            comboBox1.Items.Add("Tatars");
            comboBox1.Items.Add("Ashkenazi jews");
            comboBox1.Items.Add("White british");
            comboBox1.Items.Add("Greeks");
            comboBox1.Items.Add("Berbers");
            comboBox1.Items.Add("Mexican americans");
            comboBox1.Items.Add("Turkic peoples");
            comboBox1.Items.Add("Russian");
            comboBox1.Items.Add("Ukrainians");
            comboBox1.Items.Add("Austrians");
            comboBox1.Items.Add("Iroquois");
            comboBox1.Items.Add("Norwegians");
            comboBox1.Items.Add("Mestizo");
            comboBox1.Items.Add("People of the dominican republic");
            comboBox1.Items.Add("Kazakhs");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox4.Text = colorDialog1.Color.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string BirthPlace = textBox2.Text;
            string FulleName = textBox1.Text;
            string Ethnicity = textBox3.Text;
            string HairColor = textBox6.Text;
            string EyeColor = textBox4.Text;
            string Height = textBox5.Text;
            string BodyType = textBox7.Text;
            string Weight = textBox8.Text;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\one");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\one\\one.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\two");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\two\\two.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\three");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\three\\three.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\four");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\four\\four.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\five");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\five\\five.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\six");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\six\\six.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\seven\\seven.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\seven");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\seven\\seven.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\eight\\eight.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\seven\\seven.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\eight");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\eight\\eight.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\nine\\nine.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\eight\\eight.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\seven\\seven.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\nine");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\nine\\nine.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
            else if (File.Exists(Directory.GetCurrentDirectory() + "\\ten\\ten.txt") == false && File.Exists(Directory.GetCurrentDirectory() + "\\nine\\nine.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\eight\\eight.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\seven\\seven.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\six\\six.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\five\\five.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\four\\four.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\three\\three.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\two\\two.txt") && File.Exists(Directory.GetCurrentDirectory() + "\\one\\one.txt"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\ten");
                var file = File.CreateText(Directory.GetCurrentDirectory() + "\\ten\\ten.txt");
                file.Write(BirthPlace + Environment.NewLine + FulleName + Environment.NewLine + Ethnicity + Environment.NewLine + HairColor + Environment.NewLine + EyeColor + Environment.NewLine + Height + Environment.NewLine + BodyType + Environment.NewLine + Weight);
                file.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox6.Text = colorDialog1.Color.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text = "Birth Place = " + textBox2.Text + Environment.NewLine + "Full Nmae = " + textBox1.Text + Environment.NewLine + "Ethnicity = " + textBox3.Text + Environment.NewLine + "Hair Color = " + textBox6.Text + Environment.NewLine + "Eye Color = " + textBox4.Text + Environment.NewLine + "Height = " + textBox5.Text + Environment.NewLine + "Body Type = " + textBox7.Text + Environment.NewLine + "Weight = " + textBox8.Text;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox4.Text = colorDialog1.Color.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "Birth Place = " + textBox2.Text + Environment.NewLine + "Full Nmae = " + textBox1.Text + Environment.NewLine + "Ethnicity = " + textBox3.Text + Environment.NewLine + "Hair Color = " + textBox6.Text + Environment.NewLine + "Eye Color = " + textBox4.Text + Environment.NewLine + "Height = " + textBox5.Text + Environment.NewLine + "Body Type = " + textBox7.Text + Environment.NewLine + "Weight = " + textBox8.Text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
