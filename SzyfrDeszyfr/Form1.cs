using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SzyfrDeszyfr
{
    public partial class Form1 : Form
    {
        //C:\Users\mikol\Desktop\text.txt
        //C:\Users\mikol\Desktop\znaki.txt
        //C:\Users\mikol\Desktop\txt.txt
        string[] code;
        string codd;
        string zbior = "0f00ff0450fa0120fd03400006006006600006f03d0120ad";
        string key;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_szyfr_Click(object sender, EventArgs e)
        {
            /*if(txtKey.Text.Length < 11)
            {
                MessageBox.Show("Klucz musi się składać z 11 znaków");
            } else
            {
                codd = ReadFile(txtPath.Text);
                key = CreateKey(txtKey.Text);
                MessageBox.Show(codd);
                MessageBox.Show(key);
            }*/

            codd = ReadFile(txtPath.Text);
            key = CreateKey(txtKey.Text);
            MessageBox.Show(codd);
            MessageBox.Show(key);

        }

        private void btn_deszyfr_Click(object sender, EventArgs e)
        {
            CreateFile(codd);
        }

        public static void CreateFile(string code)
        {
            using (StreamWriter outputFile = new StreamWriter("Decoded.txt"))
            {
                CultureInfo culture = new CultureInfo("pl-PL");
                for (int i = 0; i < code.Length; i += 3)
                {
                    if (code[i].Equals('0') && code[i + 1].Equals('0') && code[i + 2].Equals('0'))
                    {
                        outputFile.WriteLine();
                    }
                    else
                    {
                        string sign = "";
                        sign += code[i];
                        sign += code[i + 1];
                        sign += code[i + 2];
                        int hex = Int32.Parse(sign, System.Globalization.NumberStyles.HexNumber);
                        outputFile.Write(Convert.ToChar(hex, culture));
                    }
                }
            }
        }

        public static string ReadFile(string path)
        {
            CultureInfo culture = new CultureInfo("pl-PL");
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string outText = "";
            foreach (string line in lines)
            {
                foreach (char sign in line)
                {
                    string outHex = "0";
                    int b = Convert.ToInt32(sign, culture);
                    string hex = b.ToString("x");
                    if (hex.Length > 2)
                    {
                        outHex = hex;
                    }
                    else
                    {
                        outHex += hex;
                    }
                    outText += outHex;
                }
                outText += "000";
            }
            return outText;
        }

        string CreateKey(string preKey)
        {
            string key = "";
            CultureInfo culture = new CultureInfo("pl-PL");
            if(preKey.Length < 11)
            {
                int countTo11 = 11 - preKey.Length;
                for(int i = 0; i < countTo11; i++)
                {
                    preKey += "0";
                }

            }

            for (int i = 0; i < preKey.Length; i++)
            {
                string outHex = "0";
                int b = Convert.ToInt32(preKey[i], culture);
                string hex = b.ToString("x");
                if (hex.Length > 2)
                {
                    outHex = hex;
                }
                else
                {
                    outHex += hex;
                }
                key += outHex;
            }

            string lastKey = "";
            for (int i = 0; i < key.Length - 1; i++)
            {
                lastKey += key[i];
            }

            return lastKey;
        }

    }
}
