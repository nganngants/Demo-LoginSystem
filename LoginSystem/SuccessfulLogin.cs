using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class SuccessfulLogin : Form
    {
        public SuccessfulLogin(String usrname)
        {
            InitializeComponent();
            UIText.Text += usrname;
        }

        private void but_cls_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void SuccessfulLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
