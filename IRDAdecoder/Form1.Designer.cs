namespace IRDAdecoder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pult = new System.Windows.Forms.PictureBox();
            this.opnfilebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decoderbutton = new System.Windows.Forms.Button();
            this.pult_off = new System.Windows.Forms.PictureBox();
            this.pult_up = new System.Windows.Forms.PictureBox();
            this.pult_left = new System.Windows.Forms.PictureBox();
            this.pult_right = new System.Windows.Forms.PictureBox();
            this.pult_down = new System.Windows.Forms.PictureBox();
            this.pult_vol_plus = new System.Windows.Forms.PictureBox();
            this.pult_vol_min = new System.Windows.Forms.PictureBox();
            this.pult_ch_plus = new System.Windows.Forms.PictureBox();
            this.pult_ch_min = new System.Windows.Forms.PictureBox();
            this.pult_0 = new System.Windows.Forms.PictureBox();
            this.pult_1 = new System.Windows.Forms.PictureBox();
            this.pult_2 = new System.Windows.Forms.PictureBox();
            this.pult_3 = new System.Windows.Forms.PictureBox();
            this.pult_4 = new System.Windows.Forms.PictureBox();
            this.pult_5 = new System.Windows.Forms.PictureBox();
            this.pult_6 = new System.Windows.Forms.PictureBox();
            this.pult_7 = new System.Windows.Forms.PictureBox();
            this.pult_8 = new System.Windows.Forms.PictureBox();
            this.pult_9 = new System.Windows.Forms.PictureBox();
            this.FilePathBox = new System.Windows.Forms.RichTextBox();
            this.OscillogramBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_vol_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_vol_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_ch_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_ch_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_9)).BeginInit();
            this.SuspendLayout();
            // 
            // pult
            // 
            this.pult.BackColor = System.Drawing.Color.Transparent;
            this.pult.Image = ((System.Drawing.Image)(resources.GetObject("pult.Image")));
            this.pult.Location = new System.Drawing.Point(12, 12);
            this.pult.Name = "pult";
            this.pult.Size = new System.Drawing.Size(253, 425);
            this.pult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult.TabIndex = 0;
            this.pult.TabStop = false;
            // 
            // opnfilebutton
            // 
            this.opnfilebutton.Location = new System.Drawing.Point(242, 12);
            this.opnfilebutton.Name = "opnfilebutton";
            this.opnfilebutton.Size = new System.Drawing.Size(341, 38);
            this.opnfilebutton.TabIndex = 1;
            this.opnfilebutton.Text = "Открыть файл";
            this.opnfilebutton.UseVisualStyleBackColor = true;
            this.opnfilebutton.Click += new System.EventHandler(this.opnfilebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код осциллограммы:";
            // 
            // decoderbutton
            // 
            this.decoderbutton.Location = new System.Drawing.Point(242, 56);
            this.decoderbutton.Name = "decoderbutton";
            this.decoderbutton.Size = new System.Drawing.Size(341, 36);
            this.decoderbutton.TabIndex = 4;
            this.decoderbutton.Text = "Декодировать";
            this.decoderbutton.UseVisualStyleBackColor = true;
            this.decoderbutton.Click += new System.EventHandler(this.decoderbutton_Click);
            // 
            // pult_off
            // 
            this.pult_off.BackColor = System.Drawing.Color.Transparent;
            this.pult_off.Image = ((System.Drawing.Image)(resources.GetObject("pult_off.Image")));
            this.pult_off.Location = new System.Drawing.Point(12, 12);
            this.pult_off.Name = "pult_off";
            this.pult_off.Size = new System.Drawing.Size(253, 425);
            this.pult_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_off.TabIndex = 6;
            this.pult_off.TabStop = false;
            // 
            // pult_up
            // 
            this.pult_up.BackColor = System.Drawing.Color.Transparent;
            this.pult_up.Image = ((System.Drawing.Image)(resources.GetObject("pult_up.Image")));
            this.pult_up.Location = new System.Drawing.Point(12, 12);
            this.pult_up.Name = "pult_up";
            this.pult_up.Size = new System.Drawing.Size(253, 425);
            this.pult_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_up.TabIndex = 7;
            this.pult_up.TabStop = false;
            // 
            // pult_left
            // 
            this.pult_left.BackColor = System.Drawing.Color.Transparent;
            this.pult_left.Image = ((System.Drawing.Image)(resources.GetObject("pult_left.Image")));
            this.pult_left.Location = new System.Drawing.Point(12, 12);
            this.pult_left.Name = "pult_left";
            this.pult_left.Size = new System.Drawing.Size(253, 425);
            this.pult_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_left.TabIndex = 8;
            this.pult_left.TabStop = false;
            // 
            // pult_right
            // 
            this.pult_right.BackColor = System.Drawing.Color.Transparent;
            this.pult_right.Image = ((System.Drawing.Image)(resources.GetObject("pult_right.Image")));
            this.pult_right.Location = new System.Drawing.Point(12, 12);
            this.pult_right.Name = "pult_right";
            this.pult_right.Size = new System.Drawing.Size(253, 425);
            this.pult_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_right.TabIndex = 9;
            this.pult_right.TabStop = false;
            // 
            // pult_down
            // 
            this.pult_down.BackColor = System.Drawing.Color.Transparent;
            this.pult_down.Image = ((System.Drawing.Image)(resources.GetObject("pult_down.Image")));
            this.pult_down.Location = new System.Drawing.Point(12, 12);
            this.pult_down.Name = "pult_down";
            this.pult_down.Size = new System.Drawing.Size(253, 425);
            this.pult_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_down.TabIndex = 10;
            this.pult_down.TabStop = false;
            // 
            // pult_vol_plus
            // 
            this.pult_vol_plus.BackColor = System.Drawing.Color.Transparent;
            this.pult_vol_plus.Image = ((System.Drawing.Image)(resources.GetObject("pult_vol_plus.Image")));
            this.pult_vol_plus.Location = new System.Drawing.Point(12, 12);
            this.pult_vol_plus.Name = "pult_vol_plus";
            this.pult_vol_plus.Size = new System.Drawing.Size(253, 425);
            this.pult_vol_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_vol_plus.TabIndex = 11;
            this.pult_vol_plus.TabStop = false;
            // 
            // pult_vol_min
            // 
            this.pult_vol_min.BackColor = System.Drawing.Color.Transparent;
            this.pult_vol_min.Image = ((System.Drawing.Image)(resources.GetObject("pult_vol_min.Image")));
            this.pult_vol_min.Location = new System.Drawing.Point(12, 12);
            this.pult_vol_min.Name = "pult_vol_min";
            this.pult_vol_min.Size = new System.Drawing.Size(253, 425);
            this.pult_vol_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_vol_min.TabIndex = 12;
            this.pult_vol_min.TabStop = false;
            this.pult_vol_min.Visible = false;
            // 
            // pult_ch_plus
            // 
            this.pult_ch_plus.BackColor = System.Drawing.Color.Transparent;
            this.pult_ch_plus.Image = ((System.Drawing.Image)(resources.GetObject("pult_ch_plus.Image")));
            this.pult_ch_plus.Location = new System.Drawing.Point(12, 12);
            this.pult_ch_plus.Name = "pult_ch_plus";
            this.pult_ch_plus.Size = new System.Drawing.Size(253, 425);
            this.pult_ch_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_ch_plus.TabIndex = 13;
            this.pult_ch_plus.TabStop = false;
            this.pult_ch_plus.Visible = false;
            // 
            // pult_ch_min
            // 
            this.pult_ch_min.BackColor = System.Drawing.Color.Transparent;
            this.pult_ch_min.Image = ((System.Drawing.Image)(resources.GetObject("pult_ch_min.Image")));
            this.pult_ch_min.Location = new System.Drawing.Point(12, 12);
            this.pult_ch_min.Name = "pult_ch_min";
            this.pult_ch_min.Size = new System.Drawing.Size(253, 425);
            this.pult_ch_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_ch_min.TabIndex = 14;
            this.pult_ch_min.TabStop = false;
            this.pult_ch_min.Visible = false;
            // 
            // pult_0
            // 
            this.pult_0.BackColor = System.Drawing.Color.Transparent;
            this.pult_0.Image = ((System.Drawing.Image)(resources.GetObject("pult_0.Image")));
            this.pult_0.Location = new System.Drawing.Point(12, 12);
            this.pult_0.Name = "pult_0";
            this.pult_0.Size = new System.Drawing.Size(253, 425);
            this.pult_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_0.TabIndex = 15;
            this.pult_0.TabStop = false;
            this.pult_0.Visible = false;
            // 
            // pult_1
            // 
            this.pult_1.BackColor = System.Drawing.Color.Transparent;
            this.pult_1.Image = ((System.Drawing.Image)(resources.GetObject("pult_1.Image")));
            this.pult_1.Location = new System.Drawing.Point(12, 12);
            this.pult_1.Name = "pult_1";
            this.pult_1.Size = new System.Drawing.Size(253, 425);
            this.pult_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_1.TabIndex = 16;
            this.pult_1.TabStop = false;
            this.pult_1.Visible = false;
            // 
            // pult_2
            // 
            this.pult_2.BackColor = System.Drawing.Color.Transparent;
            this.pult_2.Image = ((System.Drawing.Image)(resources.GetObject("pult_2.Image")));
            this.pult_2.Location = new System.Drawing.Point(12, 12);
            this.pult_2.Name = "pult_2";
            this.pult_2.Size = new System.Drawing.Size(253, 425);
            this.pult_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_2.TabIndex = 17;
            this.pult_2.TabStop = false;
            this.pult_2.Visible = false;
            // 
            // pult_3
            // 
            this.pult_3.BackColor = System.Drawing.Color.Transparent;
            this.pult_3.Image = ((System.Drawing.Image)(resources.GetObject("pult_3.Image")));
            this.pult_3.Location = new System.Drawing.Point(12, 12);
            this.pult_3.Name = "pult_3";
            this.pult_3.Size = new System.Drawing.Size(253, 425);
            this.pult_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_3.TabIndex = 18;
            this.pult_3.TabStop = false;
            this.pult_3.Visible = false;
            // 
            // pult_4
            // 
            this.pult_4.BackColor = System.Drawing.Color.Transparent;
            this.pult_4.Image = ((System.Drawing.Image)(resources.GetObject("pult_4.Image")));
            this.pult_4.Location = new System.Drawing.Point(12, 12);
            this.pult_4.Name = "pult_4";
            this.pult_4.Size = new System.Drawing.Size(253, 425);
            this.pult_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_4.TabIndex = 19;
            this.pult_4.TabStop = false;
            this.pult_4.Visible = false;
            // 
            // pult_5
            // 
            this.pult_5.BackColor = System.Drawing.Color.Transparent;
            this.pult_5.Image = ((System.Drawing.Image)(resources.GetObject("pult_5.Image")));
            this.pult_5.Location = new System.Drawing.Point(12, 12);
            this.pult_5.Name = "pult_5";
            this.pult_5.Size = new System.Drawing.Size(253, 425);
            this.pult_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_5.TabIndex = 20;
            this.pult_5.TabStop = false;
            this.pult_5.Visible = false;
            // 
            // pult_6
            // 
            this.pult_6.BackColor = System.Drawing.Color.Transparent;
            this.pult_6.Image = ((System.Drawing.Image)(resources.GetObject("pult_6.Image")));
            this.pult_6.Location = new System.Drawing.Point(12, 12);
            this.pult_6.Name = "pult_6";
            this.pult_6.Size = new System.Drawing.Size(253, 425);
            this.pult_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_6.TabIndex = 21;
            this.pult_6.TabStop = false;
            this.pult_6.Visible = false;
            // 
            // pult_7
            // 
            this.pult_7.BackColor = System.Drawing.Color.Transparent;
            this.pult_7.Image = ((System.Drawing.Image)(resources.GetObject("pult_7.Image")));
            this.pult_7.Location = new System.Drawing.Point(12, 12);
            this.pult_7.Name = "pult_7";
            this.pult_7.Size = new System.Drawing.Size(253, 425);
            this.pult_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_7.TabIndex = 22;
            this.pult_7.TabStop = false;
            this.pult_7.Visible = false;
            // 
            // pult_8
            // 
            this.pult_8.BackColor = System.Drawing.Color.Transparent;
            this.pult_8.Image = ((System.Drawing.Image)(resources.GetObject("pult_8.Image")));
            this.pult_8.Location = new System.Drawing.Point(12, 12);
            this.pult_8.Name = "pult_8";
            this.pult_8.Size = new System.Drawing.Size(253, 425);
            this.pult_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_8.TabIndex = 23;
            this.pult_8.TabStop = false;
            this.pult_8.Visible = false;
            // 
            // pult_9
            // 
            this.pult_9.BackColor = System.Drawing.Color.Transparent;
            this.pult_9.Image = ((System.Drawing.Image)(resources.GetObject("pult_9.Image")));
            this.pult_9.Location = new System.Drawing.Point(12, 12);
            this.pult_9.Name = "pult_9";
            this.pult_9.Size = new System.Drawing.Size(253, 425);
            this.pult_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pult_9.TabIndex = 24;
            this.pult_9.TabStop = false;
            this.pult_9.Visible = false;
            // 
            // FilePathBox
            // 
            this.FilePathBox.Location = new System.Drawing.Point(242, 116);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(341, 140);
            this.FilePathBox.TabIndex = 25;
            this.FilePathBox.Text = "";
            // 
            // OscillogramBox
            // 
            this.OscillogramBox.Location = new System.Drawing.Point(242, 283);
            this.OscillogramBox.Name = "OscillogramBox";
            this.OscillogramBox.Size = new System.Drawing.Size(341, 138);
            this.OscillogramBox.TabIndex = 26;
            this.OscillogramBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.OscillogramBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decoderbutton);
            this.Controls.Add(this.opnfilebutton);
            this.Controls.Add(this.pult);
            this.Controls.Add(this.pult_9);
            this.Controls.Add(this.pult_8);
            this.Controls.Add(this.pult_7);
            this.Controls.Add(this.pult_6);
            this.Controls.Add(this.pult_5);
            this.Controls.Add(this.pult_4);
            this.Controls.Add(this.pult_3);
            this.Controls.Add(this.pult_2);
            this.Controls.Add(this.pult_1);
            this.Controls.Add(this.pult_0);
            this.Controls.Add(this.pult_ch_min);
            this.Controls.Add(this.pult_ch_plus);
            this.Controls.Add(this.pult_vol_min);
            this.Controls.Add(this.pult_vol_plus);
            this.Controls.Add(this.pult_down);
            this.Controls.Add(this.pult_right);
            this.Controls.Add(this.pult_left);
            this.Controls.Add(this.pult_up);
            this.Controls.Add(this.pult_off);
            this.Name = "Form1";
            this.Text = "IrDA Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_vol_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_vol_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_ch_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_ch_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pult_9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pult;
        private System.Windows.Forms.Button opnfilebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decoderbutton;
        private System.Windows.Forms.PictureBox pult_off;
        private System.Windows.Forms.PictureBox pult_up;
        private System.Windows.Forms.PictureBox pult_left;
        private System.Windows.Forms.PictureBox pult_right;
        private System.Windows.Forms.PictureBox pult_down;
        private System.Windows.Forms.PictureBox pult_vol_plus;
        private System.Windows.Forms.PictureBox pult_vol_min;
        private System.Windows.Forms.PictureBox pult_ch_plus;
        private System.Windows.Forms.PictureBox pult_ch_min;
        private System.Windows.Forms.PictureBox pult_0;
        private System.Windows.Forms.PictureBox pult_1;
        private System.Windows.Forms.PictureBox pult_2;
        private System.Windows.Forms.PictureBox pult_3;
        private System.Windows.Forms.PictureBox pult_4;
        private System.Windows.Forms.PictureBox pult_5;
        private System.Windows.Forms.PictureBox pult_6;
        private System.Windows.Forms.PictureBox pult_7;
        private System.Windows.Forms.PictureBox pult_8;
        private System.Windows.Forms.PictureBox pult_9;
        private System.Windows.Forms.RichTextBox FilePathBox;
        private System.Windows.Forms.RichTextBox OscillogramBox;
    }
}

