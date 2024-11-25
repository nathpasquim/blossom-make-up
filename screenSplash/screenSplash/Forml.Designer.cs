namespace screenSplash
{
    partial class Forml
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
            panelSideMenu = new Panel();
            btnHelp = new Button();
            panelToolsSubMenu = new Panel();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            bntTools = new Button();
            btnEqualizer = new Button();
            panelPlaylistSubMenu = new Panel();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnPlaylist = new Button();
            panelMediaSubMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnMedia = new Button();
            panelLogo = new Panel();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelToolsSubMenu.SuspendLayout();
            panelPlaylistSubMenu.SuspendLayout();
            panelMediaSubMenu.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(198, 167, 163);
            panelSideMenu.Controls.Add(btnHelp);
            panelSideMenu.Controls.Add(panelToolsSubMenu);
            panelSideMenu.Controls.Add(bntTools);
            panelSideMenu.Controls.Add(btnEqualizer);
            panelSideMenu.Controls.Add(panelPlaylistSubMenu);
            panelSideMenu.Controls.Add(btnPlaylist);
            panelSideMenu.Controls.Add(panelMediaSubMenu);
            panelSideMenu.Controls.Add(btnMedia);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 506);
            panelSideMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.DimGray;
            btnHelp.Location = new Point(0, 715);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(10, 0, 0, 0);
            btnHelp.Size = new Size(233, 45);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // panelToolsSubMenu
            // 
            panelToolsSubMenu.BackColor = Color.FromArgb(194, 181, 177);
            panelToolsSubMenu.Controls.Add(button12);
            panelToolsSubMenu.Controls.Add(button13);
            panelToolsSubMenu.Controls.Add(button14);
            panelToolsSubMenu.Controls.Add(button15);
            panelToolsSubMenu.Dock = DockStyle.Top;
            panelToolsSubMenu.Location = new Point(0, 553);
            panelToolsSubMenu.Name = "panelToolsSubMenu";
            panelToolsSubMenu.Size = new Size(233, 162);
            panelToolsSubMenu.TabIndex = 7;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ForeColor = Color.DimGray;
            button12.Location = new Point(0, 120);
            button12.Name = "button12";
            button12.Padding = new Padding(35, 0, 0, 0);
            button12.Size = new Size(233, 36);
            button12.TabIndex = 4;
            button12.Text = "button12 (excClien)";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.DimGray;
            button13.Location = new Point(0, 80);
            button13.Name = "button13";
            button13.Padding = new Padding(35, 0, 0, 0);
            button13.Size = new Size(233, 40);
            button13.TabIndex = 3;
            button13.Text = "button13 (altClien)";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.DimGray;
            button14.Location = new Point(0, 40);
            button14.Name = "button14";
            button14.Padding = new Padding(35, 0, 0, 0);
            button14.Size = new Size(233, 40);
            button14.TabIndex = 2;
            button14.Text = "button14 (visClien)";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ForeColor = Color.DimGray;
            button15.Location = new Point(0, 0);
            button15.Name = "button15";
            button15.Padding = new Padding(35, 0, 0, 0);
            button15.Size = new Size(233, 40);
            button15.TabIndex = 1;
            button15.Text = "button15 (cadClien)";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // bntTools
            // 
            bntTools.Dock = DockStyle.Top;
            bntTools.FlatAppearance.BorderSize = 0;
            bntTools.FlatStyle = FlatStyle.Flat;
            bntTools.ForeColor = Color.DimGray;
            bntTools.Location = new Point(0, 508);
            bntTools.Name = "bntTools";
            bntTools.Padding = new Padding(10, 0, 0, 0);
            bntTools.Size = new Size(233, 45);
            bntTools.TabIndex = 6;
            bntTools.Text = "Tools (cliente)";
            bntTools.TextAlign = ContentAlignment.MiddleLeft;
            bntTools.UseVisualStyleBackColor = true;
            bntTools.Click += bntTools_Click;
            // 
            // btnEqualizer
            // 
            btnEqualizer.Dock = DockStyle.Top;
            btnEqualizer.FlatAppearance.BorderSize = 0;
            btnEqualizer.FlatStyle = FlatStyle.Flat;
            btnEqualizer.ForeColor = Color.DimGray;
            btnEqualizer.Location = new Point(0, 463);
            btnEqualizer.Name = "btnEqualizer";
            btnEqualizer.Padding = new Padding(10, 0, 0, 0);
            btnEqualizer.Size = new Size(233, 45);
            btnEqualizer.TabIndex = 5;
            btnEqualizer.Text = "Equalizer";
            btnEqualizer.TextAlign = ContentAlignment.MiddleLeft;
            btnEqualizer.UseVisualStyleBackColor = true;
            btnEqualizer.Click += btnEqualizer_Click;
            // 
            // panelPlaylistSubMenu
            // 
            panelPlaylistSubMenu.BackColor = Color.FromArgb(194, 181, 177);
            panelPlaylistSubMenu.Controls.Add(button6);
            panelPlaylistSubMenu.Controls.Add(button7);
            panelPlaylistSubMenu.Controls.Add(button8);
            panelPlaylistSubMenu.Controls.Add(button9);
            panelPlaylistSubMenu.Dock = DockStyle.Top;
            panelPlaylistSubMenu.Location = new Point(0, 301);
            panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            panelPlaylistSubMenu.Size = new Size(233, 162);
            panelPlaylistSubMenu.TabIndex = 4;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.DimGray;
            button6.Location = new Point(0, 120);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(233, 36);
            button6.TabIndex = 4;
            button6.Text = "button6 (excFunc)";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.DimGray;
            button7.Location = new Point(0, 80);
            button7.Name = "button7";
            button7.Padding = new Padding(35, 0, 0, 0);
            button7.Size = new Size(233, 40);
            button7.TabIndex = 3;
            button7.Text = "button7 (altFunc)";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.DimGray;
            button8.Location = new Point(0, 40);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(233, 40);
            button8.TabIndex = 2;
            button8.Text = "button8 (visFunc)";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.DimGray;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(233, 40);
            button9.TabIndex = 1;
            button9.Text = "button9 (cadFunc)";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Dock = DockStyle.Top;
            btnPlaylist.FlatAppearance.BorderSize = 0;
            btnPlaylist.FlatStyle = FlatStyle.Flat;
            btnPlaylist.ForeColor = Color.DimGray;
            btnPlaylist.Location = new Point(0, 256);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Padding = new Padding(10, 0, 0, 0);
            btnPlaylist.Size = new Size(233, 45);
            btnPlaylist.TabIndex = 3;
            btnPlaylist.Text = "Playlist (Funcionário)";
            btnPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += button1_Click_2;
            // 
            // panelMediaSubMenu
            // 
            panelMediaSubMenu.BackColor = Color.FromArgb(194, 181, 177);
            panelMediaSubMenu.Controls.Add(button5);
            panelMediaSubMenu.Controls.Add(button4);
            panelMediaSubMenu.Controls.Add(button3);
            panelMediaSubMenu.Controls.Add(button2);
            panelMediaSubMenu.Dock = DockStyle.Top;
            panelMediaSubMenu.Location = new Point(0, 94);
            panelMediaSubMenu.Name = "panelMediaSubMenu";
            panelMediaSubMenu.Size = new Size(233, 162);
            panelMediaSubMenu.TabIndex = 2;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.DimGray;
            button5.Location = new Point(0, 120);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(233, 36);
            button5.TabIndex = 4;
            button5.Text = "button5 (excProd)";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(233, 40);
            button4.TabIndex = 3;
            button4.Text = "button4 (altProd)";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.DimGray;
            button3.Location = new Point(0, 40);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(233, 40);
            button3.TabIndex = 2;
            button3.Text = "button3 (visProd)";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DimGray;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(233, 40);
            button2.TabIndex = 1;
            button2.Text = "button2 (cadProduto)";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnMedia
            // 
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.ForeColor = Color.DimGray;
            btnMedia.Location = new Point(0, 49);
            btnMedia.Name = "btnMedia";
            btnMedia.Padding = new Padding(10, 0, 0, 0);
            btnMedia.Size = new Size(233, 45);
            btnMedia.TabIndex = 1;
            btnMedia.Text = "Media (Produto)";
            btnMedia.TextAlign = ContentAlignment.MiddleLeft;
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 49);
            panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(194, 181, 177);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 381);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(533, 125);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(203, 193, 193);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(533, 381);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.boca3;
            pictureBox1.Location = new Point(187, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Forml
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 506);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(783, 506);
            Name = "Forml";
            Text = "Forml";
            panelSideMenu.ResumeLayout(false);
            panelToolsSubMenu.ResumeLayout(false);
            panelPlaylistSubMenu.ResumeLayout(false);
            panelMediaSubMenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnMedia;
        private Panel panelMediaSubMenu;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnPlaylist;
        private Panel panelToolsSubMenu;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button bntTools;
        private Button btnEqualizer;
        private Panel panelPlaylistSubMenu;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnHelp;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
    }
}