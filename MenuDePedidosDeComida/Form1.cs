using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuDePedidosDeComida
{
    public partial class Form1 : Form
    {
        double v1 = 0, v2 = 0, v3 = 0;
        double precio1, precio2, precio3, precio4, precio5, precio6, precio7, precio8,subtotal,IVA,total,totalaP;
        double dinero,cambio,pago;
        private void RdbOtOp_CheckedChanged(object sender, EventArgs e)
        {
            txtAgua.Enabled = true;
            txtHamburguesa.Enabled = true;
            txtPizza.Enabled = true;
            txtNugghets.Enabled = true;
            txtpapas.Enabled = true;
            txtRefresco.Enabled = true;
            txtyogourth.Enabled = true;
            txtEnsalada.Enabled = true;
            if(RdbOtOp.Checked==true)
                {
                txtHamburguesa.Text = "0";
                txtpapas.Text = "0";
                txtRefresco.Text = "0";
                txtPizza.Text = "0";
                txtNugghets.Text = "0";
                txtEnsalada.Text = "0";
                txtyogourth.Text = "0";
                txtAgua.Text = "0";

                txtHamburguesa.ReadOnly = false;
                txtpapas.ReadOnly=false;
                txtRefresco.ReadOnly=false;
                txtPizza.ReadOnly=false;
                txtNugghets.ReadOnly=false;
                txtEnsalada.ReadOnly=false;
                txtyogourth.ReadOnly=false;
                txtAgua.ReadOnly=false;
            }
            else
            {
                txtHamburguesa.ReadOnly = true;
                txtpapas.ReadOnly = true;
                txtRefresco.ReadOnly = true;
                txtPizza.ReadOnly = true;
                txtNugghets.ReadOnly = true;
                txtEnsalada.ReadOnly = true;
                txtyogourth.ReadOnly = true;
                txtAgua.ReadOnly = true;
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnterminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dinero = double.Parse(txtPago.Text);
                if (dinero > total)

                {
                    cambio = dinero - total;
                    txtCambio.Text = Convert.ToString(cambio);
                }
                else
                {
                    MessageBox.Show("El pago es menor al total", "El Pago es menor al total", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPago.Clear();
                }
            }
            catch
            {

            }
        }

        private void txtTotalaPagar_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            

}
        private void RdbEnYoAg_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbEnYoAg.Checked == true)
            {
                v3 = 1;
                txtHamburguesa.Text = "0";
                txtpapas.Text = "0";
                txtRefresco.Text = "0";
                txtPizza.Text = "0";
                txtNugghets.Text = "0";
                txtEnsalada.Text = Convert.ToString(v3);
                txtyogourth.Text = Convert.ToString(v3);
                txtAgua.Text = Convert.ToString(v3);
            }
        }

        private void RdbPiNuRe_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbPiNuRe.Checked == true)
            {
                v2 = 1;
                txtHamburguesa.Text = "0";
                txtpapas.Text = "0";
                txtRefresco.Text = Convert.ToString(v2);
                txtPizza.Text = Convert.ToString(v2);
                txtNugghets.Text = Convert.ToString(v2);
                txtEnsalada.Text = "0";
                txtyogourth.Text = "0";
                txtAgua.Text = "0";
            }
        }

        private void RdbHamPaRef_CheckedChanged(object sender, EventArgs e)
        {
            if(RdbHamPaRef.Checked==true)
            {
                v1 = 1;
                txtHamburguesa.Text = Convert.ToString(v1);
                txtpapas.Text = Convert.ToString(v1);
                txtRefresco.Text = Convert.ToString(v1);
                txtPizza.Text = "0";
                txtNugghets.Text = "0";
                txtEnsalada.Text = "0";
                txtyogourth.Text = "0";
                txtAgua.Text = "0";
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            precio1 = double.Parse(txtHamburguesa.Text);
            precio2 = double.Parse(txtpapas.Text);
            precio3 = double.Parse(txtRefresco.Text);
            precio4 = double.Parse(txtPizza.Text);
            precio5 = double.Parse(txtNugghets.Text);
            precio6 = double.Parse(txtEnsalada.Text);
            precio7 = double.Parse(txtyogourth.Text);
            precio8 = double.Parse(txtAgua.Text);

            precio1 = precio1 * 35;
            precio2 = precio2 * 15;
            precio3 = precio3 * 12;
            precio4 = precio4 * 70;
            precio5 = precio5 * 25;
            precio6 = precio6 * 30;
            precio7 = precio7 * 15;
            precio8 = precio8 * 12;

            subtotal = precio1 + precio2 + precio3 + precio4 + precio5 + precio6 + precio7 + precio8;
            txtSubtotal.Text = (Convert.ToString(subtotal));
            IVA = subtotal * .16;
            txtiva.Text = (Convert.ToString(IVA));
            total = subtotal + IVA;
            txtSubtotal.Text = (Convert.ToString(total));
            totalaP = total + IVA;
            txtTotalaPagar.Text = (Convert.ToString(totalaP));

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnvolveraUsar_Click(object sender, EventArgs e)
        {
            txtAgua.Clear();
            txtCambio.Clear();
            txtEnsalada.Clear();
            txtHamburguesa.Clear();
            txtiva.Clear();
            txtNugghets.Clear();
            txtPago.Clear();
            txtpapas.Clear();
            txtPizza.Clear();
            txtRefresco.Clear();
            txtSubtotal.Clear();
            txtTotalaPagar.Clear();
            txtyogourth.Clear();
            RdbEnYoAg.Checked = false;
            RdbHamPaRef.Checked = false;
            RdbPiNuRe.Checked = false;
            RdbOtOp.Checked = false;

        }
    }
}
