﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_again
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();//para calir
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text=="juancho"&&txtcontraseña.Text=="123tamarindo")
            {
                MessageBox.Show("bienvenido sr don juancho");
                this.Hide();//escogemos ventanalogin
                ventana2 cursosventana = new ventana2();
                cursosventana.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(" usuario o contraseña no valido ");
                txtusuario.Text = " ";
                txtcontraseña.Text = "";
                txtusuario.Focus();

            }
        }

        private void Txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if(txtusuario.Text=="juancho"&& txtcontraseña.Text=="123tamarindo")
                {

                }
                    
            }
        }
    }
}
