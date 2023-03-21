using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BejinariuAndreeaAtestat
{
    public partial class Generic : Form
    {
        public Generic()
        {
            InitializeComponent();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel1 f = new Nivel1();
            f.Show();
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel2 f = new Nivel2();
            f.Show();
        }
       

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel3 f = new Nivel3();
            f.Show();
        }
    }
}
