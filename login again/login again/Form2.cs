using System;
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
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Txtcerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Txtcomprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if(cbcs.Checked==true)
            {
                conteo++;
            }
            if(cbvisual.Checked==true)
            {
                conteo++;
            }
            if(rbtarjeta.Checked==true)
            {
                seleccion = "tarjeta de credito";

            }
            else
            {
                seleccion = "paypal";
            }
            MessageBox.Show("has seleccionado" + conteo + " cursos y tu metodo de pago es " + seleccion);
        }
    }
}
