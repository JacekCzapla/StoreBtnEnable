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
    
    public partial class Form2 : Form
    {
         
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // trzeba zdefiniować w Solution Explorer -> Properties -> Settings pole Password typu String
            // odczyt w Form 1 - 
            // string pass = Properties.Settings.Default.Password;

            Properties.Settings.Default.Password = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
