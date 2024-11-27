namespace BlossimMakeup
{
    partial class cadastroProduto
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
            this.buttonCad = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCad
            // 
            this.buttonCad.Location = new System.Drawing.Point(173, 263);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(75, 23);
            this.buttonCad.TabIndex = 2;
            this.buttonCad.Text = "button1";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(151, 203);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(128, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(151, 148);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 21);
            this.comboMarca.TabIndex = 7;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(151, 104);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 8;
            // 
            // cadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.buttonCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastroProduto";
            this.Text = "cadastroProduto";
            this.Load += new System.EventHandler(this.cadastroProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox txtNome;
    }
}