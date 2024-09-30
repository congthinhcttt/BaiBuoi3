using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2buoi3
{
    public partial class Form2 : Form
    {
        private string _message;
        public Form2()
        {
            InitializeComponent();
        }
        
        public void funData (TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;    
        }
    }
}
