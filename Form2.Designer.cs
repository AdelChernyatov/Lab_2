namespace Lab2
{
    partial class Form2
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
            this.diagnos_richText = new System.Windows.Forms.RichTextBox();
            this.Name_2text = new System.Windows.Forms.TextBox();
            this.FirName_text = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.male_label = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.data_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.id_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnos_richText
            // 
            this.diagnos_richText.Location = new System.Drawing.Point(304, 67);
            this.diagnos_richText.Name = "diagnos_richText";
            this.diagnos_richText.Size = new System.Drawing.Size(239, 215);
            this.diagnos_richText.TabIndex = 0;
            this.diagnos_richText.Text = "";
            this.diagnos_richText.TextChanged += new System.EventHandler(this.diagnos_richText_TextChanged);
            // 
            // Name_2text
            // 
            this.Name_2text.Location = new System.Drawing.Point(120, 46);
            this.Name_2text.Multiline = true;
            this.Name_2text.Name = "Name_2text";
            this.Name_2text.Size = new System.Drawing.Size(131, 31);
            this.Name_2text.TabIndex = 1;
            this.Name_2text.TextChanged += new System.EventHandler(this.Name_2text_TextChanged);
            // 
            // FirName_text
            // 
            this.FirName_text.Location = new System.Drawing.Point(120, 108);
            this.FirName_text.Multiline = true;
            this.FirName_text.Name = "FirName_text";
            this.FirName_text.Size = new System.Drawing.Size(131, 33);
            this.FirName_text.TabIndex = 2;
            this.FirName_text.TextChanged += new System.EventHandler(this.FirName_text_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "м";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.male_label);
            this.groupBox.Controls.Add(this.radioButton2);
            this.groupBox.Controls.Add(this.radioButton1);
            this.groupBox.Location = new System.Drawing.Point(44, 174);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(157, 77);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // male_label
            // 
            this.male_label.AutoSize = true;
            this.male_label.Location = new System.Drawing.Point(58, 18);
            this.male_label.Name = "male_label";
            this.male_label.Size = new System.Drawing.Size(31, 16);
            this.male_label.TabIndex = 5;
            this.male_label.Text = "пол";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(99, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ж";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // data_text
            // 
            this.data_text.Location = new System.Drawing.Point(132, 285);
            this.data_text.Multiline = true;
            this.data_text.Name = "data_text";
            this.data_text.Size = new System.Drawing.Size(136, 34);
            this.data_text.TabIndex = 5;
            this.data_text.TextChanged += new System.EventHandler(this.data_text_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(1, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_cancel.Location = new System.Drawing.Point(346, 14);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 32);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_save.Location = new System.Drawing.Point(104, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 32);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // id_Box
            // 
            this.id_Box.Location = new System.Drawing.Point(132, 345);
            this.id_Box.Multiline = true;
            this.id_Box.Name = "id_Box";
            this.id_Box.Size = new System.Drawing.Size(136, 30);
            this.id_Box.TabIndex = 7;
            this.id_Box.TextChanged += new System.EventHandler(this.id_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата Рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Диагноз";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_Box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.data_text);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.FirName_text);
            this.Controls.Add(this.Name_2text);
            this.Controls.Add(this.diagnos_richText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox diagnos_richText;
        private System.Windows.Forms.TextBox Name_2text;
        private System.Windows.Forms.TextBox FirName_text;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label male_label;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox data_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox id_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}