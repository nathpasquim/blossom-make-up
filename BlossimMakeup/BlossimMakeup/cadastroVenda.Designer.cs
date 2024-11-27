namespace BlossimMakeup
{
    partial class cadastroVenda
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
            this.comboFunc = new System.Windows.Forms.ComboBox();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtClien = new System.Windows.Forms.TextBox();
            this.txtFiltroProduto = new System.Windows.Forms.TextBox();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFunc
            // 
            this.comboFunc.FormattingEnabled = true;
            this.comboFunc.Location = new System.Drawing.Point(156, 51);
            this.comboFunc.Name = "comboFunc";
            this.comboFunc.Size = new System.Drawing.Size(121, 21);
            this.comboFunc.TabIndex = 0;
            // 
            // comboProd
            // 
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Location = new System.Drawing.Point(155, 127);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(121, 21);
            this.comboProd.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(166, 272);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtClien
            // 
            this.txtClien.Location = new System.Drawing.Point(156, 90);
            this.txtClien.Name = "txtClien";
            this.txtClien.Size = new System.Drawing.Size(121, 20);
            this.txtClien.TabIndex = 3;
            // 
            // txtFiltroProduto
            // 
            this.txtFiltroProduto.Location = new System.Drawing.Point(28, 127);
            this.txtFiltroProduto.Name = "txtFiltroProduto";
            this.txtFiltroProduto.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroProduto.TabIndex = 4;
            this.txtFiltroProduto.TextChanged += new System.EventHandler(this.txtFiltroProduto_TextChanged);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(156, 154);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(120, 95);
            this.listBoxProdutos.TabIndex = 5;
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(328, 272);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 6;
            this.btnCad.Text = "button1";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(308, 124);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProduto.TabIndex = 7;
            this.btnAdicionarProduto.Text = "button2";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // cadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.txtFiltroProduto);
            this.Controls.Add(this.txtClien);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.comboProd);
            this.Controls.Add(this.comboFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastroVenda";
            this.Text = "cadastroVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFunc;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtClien;
        private System.Windows.Forms.TextBox txtFiltroProduto;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnAdicionarProduto;
    }
}