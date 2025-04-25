namespace TI_3
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.LabelP = new System.Windows.Forms.Label();
			this.TextBoxP = new System.Windows.Forms.TextBox();
			this.TextBoxQ = new System.Windows.Forms.TextBox();
			this.LabelQ = new System.Windows.Forms.Label();
			this.TextBoxR = new System.Windows.Forms.TextBox();
			this.LabelR = new System.Windows.Forms.Label();
			this.ButtonR = new System.Windows.Forms.Button();
			this.LabelD = new System.Windows.Forms.Label();
			this.TextBoxD = new System.Windows.Forms.TextBox();
			this.EulerLabel = new System.Windows.Forms.Label();
			this.TextBoxEuler = new System.Windows.Forms.TextBox();
			this.RadioButtonCipher = new System.Windows.Forms.RadioButton();
			this.RadioButtonDecipher = new System.Windows.Forms.RadioButton();
			this.TextBoxE = new System.Windows.Forms.TextBox();
			this.LabelE = new System.Windows.Forms.Label();
			this.PlainText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LabelCipher = new System.Windows.Forms.Label();
			this.CipherText = new System.Windows.Forms.TextBox();
			this.ResultButton = new System.Windows.Forms.Button();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LabelP
			// 
			this.LabelP.Location = new System.Drawing.Point(10, 156);
			this.LabelP.Name = "LabelP";
			this.LabelP.Size = new System.Drawing.Size(88, 22);
			this.LabelP.TabIndex = 1;
			this.LabelP.Text = "P:";
			// 
			// TextBoxP
			// 
			this.TextBoxP.Location = new System.Drawing.Point(27, 153);
			this.TextBoxP.Name = "TextBoxP";
			this.TextBoxP.Size = new System.Drawing.Size(297, 23);
			this.TextBoxP.TabIndex = 2;
			this.TextBoxP.TextChanged += new System.EventHandler(this.ClearStrip_Click);
			// 
			// TextBoxQ
			// 
			this.TextBoxQ.Location = new System.Drawing.Point(27, 184);
			this.TextBoxQ.Name = "TextBoxQ";
			this.TextBoxQ.Size = new System.Drawing.Size(297, 23);
			this.TextBoxQ.TabIndex = 4;
			this.TextBoxQ.TextChanged += new System.EventHandler(this.ClearStrip_Click);
			// 
			// LabelQ
			// 
			this.LabelQ.Location = new System.Drawing.Point(10, 187);
			this.LabelQ.Name = "LabelQ";
			this.LabelQ.Size = new System.Drawing.Size(88, 22);
			this.LabelQ.TabIndex = 3;
			this.LabelQ.Text = "Q:";
			// 
			// TextBoxR
			// 
			this.TextBoxR.Location = new System.Drawing.Point(47, 352);
			this.TextBoxR.Multiline = true;
			this.TextBoxR.Name = "TextBoxR";
			this.TextBoxR.ReadOnly = true;
			this.TextBoxR.Size = new System.Drawing.Size(277, 22);
			this.TextBoxR.TabIndex = 5;
			// 
			// LabelR
			// 
			this.LabelR.Location = new System.Drawing.Point(8, 352);
			this.LabelR.Name = "LabelR";
			this.LabelR.Size = new System.Drawing.Size(31, 22);
			this.LabelR.TabIndex = 6;
			this.LabelR.Text = "R:";
			// 
			// ButtonR
			// 
			this.ButtonR.Location = new System.Drawing.Point(26, 242);
			this.ButtonR.Name = "ButtonR";
			this.ButtonR.Size = new System.Drawing.Size(297, 28);
			this.ButtonR.TabIndex = 7;
			this.ButtonR.Text = "Рассчитать параметры";
			this.ButtonR.UseVisualStyleBackColor = true;
			this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
			// 
			// LabelD
			// 
			this.LabelD.Location = new System.Drawing.Point(10, 213);
			this.LabelD.Name = "LabelD";
			this.LabelD.Size = new System.Drawing.Size(29, 51);
			this.LabelD.TabIndex = 8;
			this.LabelD.Text = "D:";
			this.LabelD.Click += new System.EventHandler(this.LabelD_Click);
			// 
			// TextBoxD
			// 
			this.TextBoxD.Location = new System.Drawing.Point(27, 213);
			this.TextBoxD.Name = "TextBoxD";
			this.TextBoxD.Size = new System.Drawing.Size(296, 23);
			this.TextBoxD.TabIndex = 9;
			this.TextBoxD.TextChanged += new System.EventHandler(this.ClearStrip_Click);
			// 
			// EulerLabel
			// 
			this.EulerLabel.Location = new System.Drawing.Point(8, 389);
			this.EulerLabel.Name = "EulerLabel";
			this.EulerLabel.Size = new System.Drawing.Size(33, 22);
			this.EulerLabel.TabIndex = 10;
			this.EulerLabel.Text = "φ(R):";
			// 
			// TextBoxEuler
			// 
			this.TextBoxEuler.Location = new System.Drawing.Point(48, 389);
			this.TextBoxEuler.Multiline = true;
			this.TextBoxEuler.Name = "TextBoxEuler";
			this.TextBoxEuler.ReadOnly = true;
			this.TextBoxEuler.Size = new System.Drawing.Size(276, 22);
			this.TextBoxEuler.TabIndex = 11;
			// 
			// RadioButtonCipher
			// 
			this.RadioButtonCipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.RadioButtonCipher.Checked = true;
			this.RadioButtonCipher.Location = new System.Drawing.Point(130, 276);
			this.RadioButtonCipher.Name = "RadioButtonCipher";
			this.RadioButtonCipher.Size = new System.Drawing.Size(88, 22);
			this.RadioButtonCipher.TabIndex = 12;
			this.RadioButtonCipher.TabStop = true;
			this.RadioButtonCipher.Text = "Шифрация";
			this.RadioButtonCipher.UseVisualStyleBackColor = true;
			this.RadioButtonCipher.CheckedChanged += new System.EventHandler(this.RadioButtonCipher_CheckedChanged);
			// 
			// RadioButtonDecipher
			// 
			this.RadioButtonDecipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.RadioButtonDecipher.Location = new System.Drawing.Point(130, 304);
			this.RadioButtonDecipher.Name = "RadioButtonDecipher";
			this.RadioButtonDecipher.Size = new System.Drawing.Size(88, 22);
			this.RadioButtonDecipher.TabIndex = 13;
			this.RadioButtonDecipher.Text = "Дешифрация";
			this.RadioButtonDecipher.UseVisualStyleBackColor = true;
			this.RadioButtonDecipher.CheckedChanged += new System.EventHandler(this.RadioButtonDecipher_CheckedChanged);
			// 
			// TextBoxE
			// 
			this.TextBoxE.Location = new System.Drawing.Point(48, 424);
			this.TextBoxE.Multiline = true;
			this.TextBoxE.Name = "TextBoxE";
			this.TextBoxE.ReadOnly = true;
			this.TextBoxE.Size = new System.Drawing.Size(276, 22);
			this.TextBoxE.TabIndex = 14;
			this.TextBoxE.TextChanged += new System.EventHandler(this.TextBoxE_TextChanged);
			// 
			// LabelE
			// 
			this.LabelE.Location = new System.Drawing.Point(8, 424);
			this.LabelE.Name = "LabelE";
			this.LabelE.Size = new System.Drawing.Size(32, 17);
			this.LabelE.TabIndex = 15;
			this.LabelE.Text = "E:";
			// 
			// PlainText
			// 
			this.PlainText.Location = new System.Drawing.Point(353, 34);
			this.PlainText.Multiline = true;
			this.PlainText.Name = "PlainText";
			this.PlainText.ReadOnly = true;
			this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.PlainText.Size = new System.Drawing.Size(661, 299);
			this.PlainText.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(350, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(518, 22);
			this.label1.TabIndex = 17;
			this.label1.Text = "Исходный текст:";
			// 
			// LabelCipher
			// 
			this.LabelCipher.Location = new System.Drawing.Point(350, 373);
			this.LabelCipher.Name = "LabelCipher";
			this.LabelCipher.Size = new System.Drawing.Size(392, 22);
			this.LabelCipher.TabIndex = 18;
			this.LabelCipher.Text = "Зашифрованный текст:";
			// 
			// CipherText
			// 
			this.CipherText.Location = new System.Drawing.Point(353, 398);
			this.CipherText.Multiline = true;
			this.CipherText.Name = "CipherText";
			this.CipherText.ReadOnly = true;
			this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.CipherText.Size = new System.Drawing.Size(661, 297);
			this.CipherText.TabIndex = 19;
			// 
			// ResultButton
			// 
			this.ResultButton.Enabled = false;
			this.ResultButton.Location = new System.Drawing.Point(15, 542);
			this.ResultButton.Name = "ResultButton";
			this.ResultButton.Size = new System.Drawing.Size(311, 75);
			this.ResultButton.TabIndex = 20;
			this.ResultButton.Text = "Зашифровать/Дешифровать";
			this.ResultButton.UseVisualStyleBackColor = true;
			this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(10, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 66);
			this.button1.TabIndex = 21;
			this.button1.Text = "Загрузить исходный текст";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button2.Location = new System.Drawing.Point(171, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 66);
			this.button2.TabIndex = 22;
			this.button2.Text = "Сохранить зашифрованный \r\nтекст\r\n";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(10, 82);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(153, 66);
			this.button3.TabIndex = 23;
			this.button3.Text = "Загрузить зашифрованный текст";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(173, 82);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(150, 66);
			this.button4.TabIndex = 24;
			this.button4.Text = "Сохранить\r\nисходный текст";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 503);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(313, 33);
			this.button5.TabIndex = 25;
			this.button5.Text = "Очистить";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(1025, 718);
			this.Controls.Add(this.ButtonR);
			this.Controls.Add(this.TextBoxE);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ResultButton);
			this.Controls.Add(this.CipherText);
			this.Controls.Add(this.LabelCipher);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PlainText);
			this.Controls.Add(this.LabelE);
			this.Controls.Add(this.RadioButtonDecipher);
			this.Controls.Add(this.RadioButtonCipher);
			this.Controls.Add(this.TextBoxEuler);
			this.Controls.Add(this.EulerLabel);
			this.Controls.Add(this.TextBoxD);
			this.Controls.Add(this.LabelD);
			this.Controls.Add(this.LabelR);
			this.Controls.Add(this.TextBoxR);
			this.Controls.Add(this.TextBoxQ);
			this.Controls.Add(this.LabelQ);
			this.Controls.Add(this.TextBoxP);
			this.Controls.Add(this.LabelP);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(15, 15);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ТИ Lab3";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;

        private System.Windows.Forms.Button ResultButton;

        private System.Windows.Forms.TextBox PlainText;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCipher;

        private System.Windows.Forms.TextBox CipherText;

        private System.Windows.Forms.Label LabelD;

        private System.Windows.Forms.TextBox TextBoxD;

        private System.Windows.Forms.RadioButton RadioButtonCipher;
        private System.Windows.Forms.RadioButton RadioButtonDecipher;

        private System.Windows.Forms.Label EulerLabel;

        private System.Windows.Forms.TextBox TextBoxE;

        private System.Windows.Forms.Label LabelE;
        private System.Windows.Forms.TextBox TextBoxEuler;

        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label LabelR;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
	}
}