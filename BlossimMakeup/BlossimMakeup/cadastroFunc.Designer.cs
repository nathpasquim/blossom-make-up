namespace BlossimMakeup
{
    partial class cadastroFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.guna2TextBox6 = new System.Windows.Forms.TextBox();
            this.guna2TextBox2 = new System.Windows.Forms.TextBox();
            this.guna2TextBox5 = new System.Windows.Forms.TextBox();
            this.guna2TextBox4 = new System.Windows.Forms.TextBox();
            this.guna2TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(193, 246);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "button1";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(55, 76);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(121, 20);
            this.txtBoxNome.TabIndex = 2;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Location = new System.Drawing.Point(288, 125);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.Size = new System.Drawing.Size(121, 20);
            this.guna2TextBox6.TabIndex = 5;
            this.guna2TextBox6.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Location = new System.Drawing.Point(55, 125);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.Size = new System.Drawing.Size(121, 20);
            this.guna2TextBox2.TabIndex = 6;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Location = new System.Drawing.Point(288, 76);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.Size = new System.Drawing.Size(121, 20);
            this.guna2TextBox5.TabIndex = 7;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Location = new System.Drawing.Point(55, 169);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.Size = new System.Drawing.Size(121, 20);
            this.guna2TextBox4.TabIndex = 8;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Location = new System.Drawing.Point(288, 169);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Size = new System.Drawing.Size(121, 20);
            this.guna2TextBox1.TabIndex = 9;
            // 
            // cadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastroFunc";
            this.Text = "cadastroFunc";
            this.Load += new System.EventHandler(this.cadastroFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox guna2TextBox6;
        private System.Windows.Forms.TextBox guna2TextBox2;
        private System.Windows.Forms.TextBox guna2TextBox5;
        private System.Windows.Forms.TextBox guna2TextBox4;
        private System.Windows.Forms.TextBox guna2TextBox1;
    }
}