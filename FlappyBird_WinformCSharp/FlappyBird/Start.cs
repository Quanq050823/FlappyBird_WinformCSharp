using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void startbtt_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
