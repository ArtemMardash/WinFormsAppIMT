using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppIMT
{
    public partial class Form2 : Form
    {
        public Form2(string recomendations)
        {
            InitializeComponent();
            label1.Text = recomendations;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Вы запустили калькулятор ИМТ ", "Message", MessageBoxButtons.OK);
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
