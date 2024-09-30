using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2buoi3
{
    public partial class Form1 : Form
    {
        private string _message;
        public Form1()
        {
            InitializeComponent();
        }


        public delegate void delPassData(TextBox text);

        private void btnSend_Click(object sender, System.EventArgs e)
        {
            Form2 frm = new Form2();
            delPassData del = new delPassData(frm.funData);
            del(this.textBox1);
            frm.Show();
        }

    }
}
