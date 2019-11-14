using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Form2 _Form = new Form2();
            _Form.Show();
        }

        private void money_Click(object sender, EventArgs e)
        {
            Form3 _Form = new Form3();
            _Form.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
