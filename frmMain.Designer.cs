namespace WindowAES
{
    partial class FrmMain
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCypher = new System.Windows.Forms.TextBox();
            this.btnCypher = new System.Windows.Forms.Button();
            this.btnDecypher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadPlain = new System.Windows.Forms.Button();
            this.txtCipherKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCipherKeySize = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.BackColor = System.Drawing.Color.White;
            this.txtPlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlain.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlain.Location = new System.Drawing.Point(9, 78);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlain.Size = new System.Drawing.Size(251, 197);
            this.txtPlain.TabIndex = 0;
            // 
            // txtCypher
            // 
            this.txtCypher.BackColor = System.Drawing.Color.White;
            this.txtCypher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCypher.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCypher.Location = new System.Drawing.Point(355, 78);
            this.txtCypher.Multiline = true;
            this.txtCypher.Name = "txtCypher";
            this.txtCypher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCypher.Size = new System.Drawing.Size(250, 197);
            this.txtCypher.TabIndex = 1;
            // 
            // btnCypher
            // 
            this.btnCypher.BackColor = System.Drawing.Color.White;
            this.btnCypher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCypher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCypher.ForeColor = System.Drawing.Color.Black;
            this.btnCypher.Location = new System.Drawing.Point(266, 78);
            this.btnCypher.Name = "btnCypher";
            this.btnCypher.Size = new System.Drawing.Size(83, 48);
            this.btnCypher.TabIndex = 2;
            this.btnCypher.Text = "Encrypt >>";
            this.btnCypher.UseVisualStyleBackColor = false;
            this.btnCypher.Click += new System.EventHandler(this.btnCypher_Click);
            // 
            // btnDecypher
            // 
            this.btnDecypher.BackColor = System.Drawing.Color.White;
            this.btnDecypher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecypher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecypher.ForeColor = System.Drawing.Color.Black;
            this.btnDecypher.Location = new System.Drawing.Point(266, 132);
            this.btnDecypher.Name = "btnDecypher";
            this.btnDecypher.Size = new System.Drawing.Size(83, 46);
            this.btnDecypher.TabIndex = 3;
            this.btnDecypher.Text = "<< Decrypt";
            this.btnDecypher.UseVisualStyleBackColor = false;
            this.btnDecypher.Click += new System.EventHandler(this.btnDecypher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cipher Side";
            // 
            // btnLoadPlain
            // 
            this.btnLoadPlain.BackColor = System.Drawing.Color.White;
            this.btnLoadPlain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPlain.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlain.ForeColor = System.Drawing.Color.Black;
            this.btnLoadPlain.Location = new System.Drawing.Point(9, 281);
            this.btnLoadPlain.Name = "btnLoadPlain";
            this.btnLoadPlain.Size = new System.Drawing.Size(251, 28);
            this.btnLoadPlain.TabIndex = 6;
            this.btnLoadPlain.Text = "&Load";
            this.btnLoadPlain.UseVisualStyleBackColor = false;
            this.btnLoadPlain.Click += new System.EventHandler(this.btnLoadPlain_Click);
            // 
            // txtCipherKey
            // 
            this.txtCipherKey.BackColor = System.Drawing.Color.White;
            this.txtCipherKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCipherKey.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipherKey.Location = new System.Drawing.Point(218, 37);
            this.txtCipherKey.MaxLength = 16;
            this.txtCipherKey.Multiline = true;
            this.txtCipherKey.Name = "txtCipherKey";
            this.txtCipherKey.Size = new System.Drawing.Size(187, 35);
            this.txtCipherKey.TabIndex = 11;
            this.txtCipherKey.Text = "SETCIPHERKEYHERE";
            this.txtCipherKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCipherKey.TextChanged += new System.EventHandler(this.txtCipherKey_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblCipherKeySize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPlain);
            this.panel1.Controls.Add(this.txtCypher);
            this.panel1.Controls.Add(this.btnCypher);
            this.panel1.Controls.Add(this.btnDecypher);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLoadPlain);
            this.panel1.Controls.Add(this.txtCipherKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 350);
            this.panel1.TabIndex = 15;
            // 
            // lblCipherKeySize
            // 
            this.lblCipherKeySize.BackColor = System.Drawing.Color.White;
            this.lblCipherKeySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCipherKeySize.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherKeySize.Location = new System.Drawing.Point(186, 54);
            this.lblCipherKeySize.Margin = new System.Windows.Forms.Padding(0);
            this.lblCipherKeySize.Name = "lblCipherKeySize";
            this.lblCipherKeySize.Size = new System.Drawing.Size(35, 18);
            this.lblCipherKeySize.TabIndex = 14;
            this.lblCipherKeySize.Text = "16";
            this.lblCipherKeySize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(355, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 348);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCypher;
        private System.Windows.Forms.Button btnCypher;
        private System.Windows.Forms.Button btnDecypher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadPlain;
        private System.Windows.Forms.TextBox txtCipherKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCipherKeySize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

