using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBenjaLangSp1Login
{
    public partial class frmSinterpartSRL : Form
    {
        public frmSinterpartSRL()
        {
            InitializeComponent();
        }

        

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
