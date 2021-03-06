using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_CianiDiaco_GestionePizzeria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int /*margherita*/ = 0, formaggi = 0, verdure = 0; 
            int quantita, temp = Convert.ToInt32(txtQuantità.Text);
            string scelta = cmbScelta.Text;
            switch (scelta)
            {
                case "Pizza margherita":
                    lstPizze.Items.Add($"{scelta} {quantita}");
                    lblNumPizMarg.Text = Convert.ToString(Convert.ToInt32(lblNumPizMarg.Text) + quantita);
                    break;
                case "Pizza quattro formaggi":
                    formaggi = formaggi + temp;
                    lstPizze.Text = "Pizza quattro formaggi" + temp;
                    lblNumPizQuattroFormaggi.Text = Convert.ToString(formaggi);
                    break;
                case "Pizza con verdure":
                    verdure = verdure + temp;
                    lstPizze.Text = "Pizza con verdure" + temp;
                    lblNumPizVerd.Text = Convert.ToString(verdure);
                    break;
            }
        }
    }
}
