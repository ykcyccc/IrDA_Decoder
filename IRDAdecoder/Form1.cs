using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRDAdecoder
{
    public partial class Form1 : Form
    {
        string filename, filetext;

        public Form1()
        {
            InitializeComponent();
        }

        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        private void decoderbutton_Click(object sender, EventArgs e)
        {
            Path.ChangeExtension(filename, "txt");
            var encode_data = GetBytesFromBinaryString(filetext);
            var encode_text = Encoding.ASCII.GetString(encode_data);
            Path.ChangeExtension(filename, "irda");
            if (encode_text == "turn off tv")
            {
                pult.Visible = false;
                pult_off.Visible = true;
            }
            else if (encode_text == "press button 0")
            {
                pult.Visible = false;
                pult_0.Visible = true;
            }
            else if (encode_text == "press button 1")
            {
                pult.Visible = false;
                pult_1.Visible = true;
            }
            else if (encode_text == "press button 2")
            {
                pult.Visible = false;
                pult_2.Visible = true;
            }
            else if (encode_text == "press button 3")
            {
                pult.Visible = false;
                pult_3.Visible = true;
            }
            else if (encode_text == "press button 4")
            {
                pult.Visible = false;
                pult_4.Visible = true;
            }
            else if (encode_text == "press button 5")
            {
                pult.Visible = false;
                pult_5.Visible = true;
            }
            else if (encode_text == "press button 6")
            {
                pult.Visible = false;
                pult_6.Visible = true;
            }
            else if (encode_text == "press button 7")
            {
                pult.Visible = false;
                pult_7.Visible = true;
            }
            else if (encode_text == "press button 8")
            {
                pult.Visible = false;
                pult_8.Visible = true;
            }
            else if (encode_text == "press button 9")
            {
                pult.Visible = false;
                pult_9.Visible = true;
            }
            else if (encode_text == "press button chanel -")
            {
                pult.Visible = false;
                pult_ch_min.Visible = true;
            }
            else if (encode_text == "press button chanel +")
            {
                pult.Visible = false;
                pult_ch_plus.Visible = true;
            }
            else if (encode_text == "press button volume +")
            {
                pult.Visible = false;
                pult_vol_plus.Visible = true;
            }
            else if (encode_text == "press button volume -")
            {
                pult.Visible = false;
                pult_vol_min.Visible = true;
            }
            else if (encode_text == "press button up")
            {
                pult.Visible = false;
                pult_up.Visible = true;
            }
            else if (encode_text == "press button down")
            {
                pult.Visible = false;
                pult_down.Visible = true;
            }
            else if (encode_text == "press button left")
            {
                pult.Visible = false;
                pult_left.Visible = true;
            }
            else if (encode_text == "press button right")
            {
                pult.Visible = false;
                pult_right.Visible = true;
            }
            else MessageBox.Show("Ошибка");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pult.Visible = true;
            pult_0.Visible = false;
            pult_1.Visible = false;
            pult_2.Visible = false;
            pult_3.Visible = false;
            pult_4.Visible = false;
            pult_5.Visible = false;
            pult_6.Visible = false;
            pult_7.Visible = false;
            pult_8.Visible = false;
            pult_9.Visible = false;
            pult_off.Visible = false;
            pult_ch_plus.Visible = false;
            pult_ch_min.Visible = false;
            pult_vol_plus.Visible = false;
            pult_vol_min.Visible = false;
            pult_up.Visible = false;
            pult_down.Visible = false;
            pult_left.Visible = false;
            pult_right.Visible = false;
        }

        private void opnfilebutton_Click(object sender, EventArgs e)
        {
            pult.Visible = true;
            pult_0.Visible = false;
            pult_1.Visible = false;
            pult_2.Visible = false;
            pult_3.Visible = false;
            pult_4.Visible = false;
            pult_5.Visible = false;
            pult_6.Visible = false;
            pult_7.Visible = false;
            pult_8.Visible = false;
            pult_9.Visible = false;
            pult_off.Visible = false;
            pult_ch_plus.Visible = false;
            pult_ch_min.Visible = false;
            pult_vol_plus.Visible = false;
            pult_vol_min.Visible = false;
            pult_up.Visible = false;
            pult_down.Visible = false;
            pult_left.Visible = false;
            pult_right.Visible = false;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "irda files (*.irda)|*.irda";
            openfile.FilterIndex = 2;
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                filename = openfile.FileName;
                filetext = File.ReadAllText(filename);
                FilePathBox.Text = filename;
                OscillogramBox.Text = filetext;
            }
        }
    }
}
