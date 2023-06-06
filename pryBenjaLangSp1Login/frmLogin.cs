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

            bool datosOk = false;

            switch (usuario)
            {
                case "Adm":
                    if (contraseña == "@1a" && (modulo == "ADM (administracion)" || modulo == "COM (compras)" || modulo == "VTA (ventas)"))
                        datosOk = true;
                    break;
                case "Ceci":
                    if (contraseña == "*@3c" && (modulo == "ADM (administracion)" || modulo == "VTA (ventas)"))
                        datosOk = true;
                    break;
                case "John":
                    if (contraseña == "*2b" && (modulo == "SIST (sistemas)"))
                        datosOk = true;
                    break;
                case "God":
                    if (contraseña == "*@#4d" && modulo != "")
                        datosOk = true;
                    break;

                default:
                    break;
            }
            if (datosOk)
            {
                CantidadErrores = 0;
                this.Hide();
                ventanaBienvenida.ShowDialog();
            }
            else
            {
                CantidadErrores++;
                ventanaError.ShowDialog();
                funcionCierre(CantidadErrores);
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            funcionCierre(CantidadErrores);
        }


        private void funcionCierre(int CantidadErrores)
        {
            if (CantidadErrores == 2)
            { this.Close(); }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}