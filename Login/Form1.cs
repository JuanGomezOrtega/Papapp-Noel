using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bPapa.FlatAppearance.BorderSize = 0;
            bElfo.FlatAppearance.BorderSize = 0;
        }

        private void bPapa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pa ti todo carbón");
        }

        private void bElfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si lo es, si lo es, es un Elfo");
        }

       
    }
}
