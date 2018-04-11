using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreBtnLocationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            // odczyt hasła z settings
            string pass = Properties.Settings.Default.Password;
            //sprawdzenie hasa
            if (String.IsNullOrEmpty(textBox1.Text) || pass != textBox1.Text)
            {
                MessageBox.Show("Hasło niepoprawne");
            }
            else {
                textBox1.Text = "";
                Form2 f = new Form2();
                f.Show();
            }
            
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            bool RememberMe = Properties.Settings.Default.RememberMe;
            if (RememberMe) {
                textBox1.Text = Properties.Settings.Default.Password;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = checkBox1.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
