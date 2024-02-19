using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REO
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new CheckProperty();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a  = new InsertReq();
            a.ShowDialog();
        }
    }
}
