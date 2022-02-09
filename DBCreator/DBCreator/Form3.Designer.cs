
namespace DBCreator
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tag1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAG10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.PersonsBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ethnicity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleDataToolStripMenuItem,
            this.trafficDataToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // peopleDataToolStripMenuItem
            // 
            this.peopleDataToolStripMenuItem.Name = "peopleDataToolStripMenuItem";
            this.peopleDataToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.peopleDataToolStripMenuItem.Text = "People Data";
            this.peopleDataToolStripMenuItem.Click += new System.EventHandler(this.peopleDataToolStripMenuItem_Click);
            // 
            // trafficDataToolStripMenuItem
            // 
            this.trafficDataToolStripMenuItem.Name = "trafficDataToolStripMenuItem";
            this.trafficDataToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.trafficDataToolStripMenuItem.Text = "Traffic Data";
            this.trafficDataToolStripMenuItem.Click += new System.EventHandler(this.trafficDataToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleDBToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "New";
            this.fileToolStripMenuItem.ToolTipText = "Create a new file.";
            // 
            // peopleDBToolStripMenuItem
            // 
            this.peopleDBToolStripMenuItem.Name = "peopleDBToolStripMenuItem";
            this.peopleDBToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.peopleDBToolStripMenuItem.Text = "People DB";
            this.peopleDBToolStripMenuItem.ToolTipText = "People DB";
            this.peopleDBToolStripMenuItem.Click += new System.EventHandler(this.peopleDBToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Enabled = false;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.databaseToolStripMenuItem.Text = "Traffic DB";
            this.databaseToolStripMenuItem.ToolTipText = "Traffic DB";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.ToolTipText = "People you have logged.";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonsBP,
            this.FNoP,
            this.Ethnicity,
            this.HC,
            this.EC,
            this.Height,
            this.BT,
            this.Weight});
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 122);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag1,
            this.TAG3,
            this.Tag2,
            this.TAG4,
            this.TAG5,
            this.TAG6,
            this.TAG7,
            this.TAG8,
            this.TAG9,
            this.TAG10});
            this.dataGridView2.Location = new System.Drawing.Point(9, 156);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(508, 208);
            this.dataGridView2.TabIndex = 2;
            // 
            // Tag1
            // 
            this.Tag1.HeaderText = "TAG 1";
            this.Tag1.MinimumWidth = 6;
            this.Tag1.Name = "Tag1";
            this.Tag1.Width = 125;
            // 
            // TAG3
            // 
            this.TAG3.HeaderText = "TAG 3";
            this.TAG3.MinimumWidth = 6;
            this.TAG3.Name = "TAG3";
            this.TAG3.Width = 125;
            // 
            // Tag2
            // 
            this.Tag2.HeaderText = "TAG 2";
            this.Tag2.MinimumWidth = 6;
            this.Tag2.Name = "Tag2";
            this.Tag2.Width = 125;
            // 
            // TAG4
            // 
            this.TAG4.HeaderText = "TAG 4";
            this.TAG4.MinimumWidth = 6;
            this.TAG4.Name = "TAG4";
            this.TAG4.Width = 125;
            // 
            // TAG5
            // 
            this.TAG5.HeaderText = "TAG 5";
            this.TAG5.MinimumWidth = 6;
            this.TAG5.Name = "TAG5";
            this.TAG5.Width = 125;
            // 
            // TAG6
            // 
            this.TAG6.HeaderText = "TAG 6";
            this.TAG6.MinimumWidth = 6;
            this.TAG6.Name = "TAG6";
            this.TAG6.Width = 125;
            // 
            // TAG7
            // 
            this.TAG7.HeaderText = "TAG 7";
            this.TAG7.MinimumWidth = 6;
            this.TAG7.Name = "TAG7";
            this.TAG7.Width = 125;
            // 
            // TAG8
            // 
            this.TAG8.HeaderText = "TAG 8";
            this.TAG8.MinimumWidth = 6;
            this.TAG8.Name = "TAG8";
            this.TAG8.Width = 125;
            // 
            // TAG9
            // 
            this.TAG9.HeaderText = "TAG 9";
            this.TAG9.MinimumWidth = 6;
            this.TAG9.Name = "TAG9";
            this.TAG9.Width = 125;
            // 
            // TAG10
            // 
            this.TAG10.HeaderText = "TAG 10";
            this.TAG10.MinimumWidth = 6;
            this.TAG10.Name = "TAG10";
            this.TAG10.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "add row";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 344);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Tag = "";
            this.textBox1.Text = "index";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "remove row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(710, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(522, 156);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 341);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "save as default \"loading\" image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PersonsBP
            // 
            this.PersonsBP.HeaderText = "Persons birthplace";
            this.PersonsBP.MinimumWidth = 6;
            this.PersonsBP.Name = "PersonsBP";
            this.PersonsBP.ReadOnly = true;
            this.PersonsBP.Width = 125;
            // 
            // FNoP
            // 
            this.FNoP.HeaderText = "Full name of person";
            this.FNoP.MinimumWidth = 6;
            this.FNoP.Name = "FNoP";
            this.FNoP.ReadOnly = true;
            this.FNoP.Width = 125;
            // 
            // Ethnicity
            // 
            this.Ethnicity.HeaderText = "Ethnicity";
            this.Ethnicity.MinimumWidth = 6;
            this.Ethnicity.Name = "Ethnicity";
            this.Ethnicity.ReadOnly = true;
            this.Ethnicity.Width = 125;
            // 
            // HC
            // 
            this.HC.HeaderText = "Hair color";
            this.HC.MinimumWidth = 6;
            this.HC.Name = "HC";
            this.HC.ReadOnly = true;
            this.HC.Width = 125;
            // 
            // EC
            // 
            this.EC.HeaderText = "Eye color";
            this.EC.MinimumWidth = 6;
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            this.EC.Width = 125;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            // 
            // BT
            // 
            this.BT.HeaderText = "Body type";
            this.BT.MinimumWidth = 6;
            this.BT.Name = "BT";
            this.BT.ReadOnly = true;
            this.BT.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 374);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBCreator - TrafficDB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trafficDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAG10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonsBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ethnicity;
        private System.Windows.Forms.DataGridViewTextBoxColumn HC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn BT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}

