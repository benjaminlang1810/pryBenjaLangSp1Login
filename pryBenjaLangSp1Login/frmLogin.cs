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
    public partial class frmLogin : Form
    {
        int CantidadErrores = 0; 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;  
            var contraseña = txtContraseña.Text;
            var modulo = cboModulo.Text;
            frmBienvenida ventanaBienvenida = new frmBienvenida();
            frmError ventanaError = new frmError(); 

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
