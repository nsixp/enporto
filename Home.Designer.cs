namespace NparkieApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            NoKend = new TextBox();
            Date = new DateTimePicker();
            HitungBtn = new Button();
            dataGridView1 = new DataGridView();
            JenKend = new ComboBox();
            JamMas = new TextBox();
            JamKel = new TextBox();
            LamPar = new TextBox();
            HarPar = new TextBox();
            TotBay = new TextBox();
            Kemb = new TextBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exiToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ProsesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // NoKend
            // 
            NoKend.Cursor = Cursors.IBeam;
            NoKend.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            NoKend.Location = new Point(112, 253);
            NoKend.Name = "NoKend";
            NoKend.Size = new Size(212, 22);
            NoKend.TabIndex = 1;
            // 
            // Date
            // 
            Date.CalendarFont = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(550, 56);
            Date.Name = "Date";
            Date.Size = new Size(82, 23);
            Date.TabIndex = 9;
            // 
            // HitungBtn
            // 
            HitungBtn.BackColor = Color.Transparent;
            HitungBtn.BackgroundImage = (Image)resources.GetObject("HitungBtn.BackgroundImage");
            HitungBtn.BackgroundImageLayout = ImageLayout.Stretch;
            HitungBtn.Cursor = Cursors.Hand;
            HitungBtn.FlatAppearance.BorderSize = 0;
            HitungBtn.FlatStyle = FlatStyle.Flat;
            HitungBtn.ForeColor = Color.Transparent;
            HitungBtn.Location = new Point(111, 459);
            HitungBtn.Name = "HitungBtn";
            HitungBtn.Size = new Size(451, 40);
            HitungBtn.TabIndex = 10;
            HitungBtn.UseVisualStyleBackColor = false;
            HitungBtn.Click += HitungBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(677, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(629, 567);
            dataGridView1.TabIndex = 11;
            // 
            // JenKend
            // 
            JenKend.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            JenKend.FormattingEnabled = true;
            JenKend.Location = new Point(112, 309);
            JenKend.Name = "JenKend";
            JenKend.Size = new Size(212, 24);
            JenKend.TabIndex = 12;
            // 
            // JamMas
            // 
            JamMas.Cursor = Cursors.IBeam;
            JamMas.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            JamMas.Location = new Point(112, 366);
            JamMas.Name = "JamMas";
            JamMas.Size = new Size(212, 22);
            JamMas.TabIndex = 13;
            // 
            // JamKel
            // 
            JamKel.Cursor = Cursors.IBeam;
            JamKel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            JamKel.Location = new Point(112, 424);
            JamKel.Name = "JamKel";
            JamKel.Size = new Size(212, 22);
            JamKel.TabIndex = 14;
            // 
            // LamPar
            // 
            LamPar.Cursor = Cursors.IBeam;
            LamPar.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            LamPar.Location = new Point(349, 253);
            LamPar.Name = "LamPar";
            LamPar.Size = new Size(213, 22);
            LamPar.TabIndex = 15;
            // 
            // HarPar
            // 
            HarPar.Cursor = Cursors.IBeam;
            HarPar.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            HarPar.Location = new Point(349, 310);
            HarPar.Name = "HarPar";
            HarPar.Size = new Size(213, 22);
            HarPar.TabIndex = 16;
            // 
            // TotBay
            // 
            TotBay.Cursor = Cursors.IBeam;
            TotBay.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            TotBay.Location = new Point(349, 366);
            TotBay.Name = "TotBay";
            TotBay.Size = new Size(213, 22);
            TotBay.TabIndex = 17;
            // 
            // Kemb
            // 
            Kemb.Cursor = Cursors.IBeam;
            Kemb.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Kemb.Location = new Point(349, 424);
            Kemb.Name = "Kemb";
            Kemb.Size = new Size(213, 22);
            Kemb.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1354, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, logOutToolStripMenuItem, exiToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(53, 20);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(121, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(121, 22);
            logOutToolStripMenuItem.Text = "&Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exiToolStripMenuItem
            // 
            exiToolStripMenuItem.Name = "exiToolStripMenuItem";
            exiToolStripMenuItem.Size = new Size(121, 22);
            exiToolStripMenuItem.Text = "&Exit";
            exiToolStripMenuItem.Click += exiToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(112, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ProsesBtn
            // 
            ProsesBtn.BackColor = Color.Transparent;
            ProsesBtn.BackgroundImage = (Image)resources.GetObject("ProsesBtn.BackgroundImage");
            ProsesBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ProsesBtn.Cursor = Cursors.Hand;
            ProsesBtn.FlatAppearance.BorderSize = 0;
            ProsesBtn.FlatStyle = FlatStyle.Flat;
            ProsesBtn.ForeColor = Color.Transparent;
            ProsesBtn.Location = new Point(81, 530);
            ProsesBtn.Name = "ProsesBtn";
            ProsesBtn.Size = new Size(508, 48);
            ProsesBtn.TabIndex = 20;
            ProsesBtn.UseVisualStyleBackColor = false;
            ProsesBtn.Click += ProsesBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1354, 661);
            Controls.Add(ProsesBtn);
            Controls.Add(Kemb);
            Controls.Add(TotBay);
            Controls.Add(HarPar);
            Controls.Add(LamPar);
            Controls.Add(JamKel);
            Controls.Add(JamMas);
            Controls.Add(JenKend);
            Controls.Add(dataGridView1);
            Controls.Add(HitungBtn);
            Controls.Add(Date);
            Controls.Add(NoKend);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nparkie";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NoKend;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker Date;
        private Button HitungBtn;
        private DataGridView dataGridView1;
        private ComboBox JenKend;
        private TextBox JamMas;
        private TextBox JamKel;
        private TextBox LamPar;
        private TextBox HarPar;
        private TextBox TotBay;
        private TextBox Kemb;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exiToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private Button ProsesBtn;
    }
}