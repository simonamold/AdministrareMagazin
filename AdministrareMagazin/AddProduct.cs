using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrareMagazin
{
    public partial class AddProduct : Form
    {
        private Produs p = null;
        public AddProduct(Produs p)
        {
            InitializeComponent();
            this.p = p;
        }

        // seteaza valorile campurilor Produsului
        private void btnAdaugareProdus_Click(object sender, EventArgs e)
        {
            if (decimal.ToInt32(nudCantitate.Value) > 0)
            {
                p.Denumire = txtDenumire.Text;
                p.Descriere = txtDescriere.Text;
                p.DataIntrare = dtpIntrare.Value;
                p.DataValabilitate = dtpValabilitate.Value;
                p.Cantitate = decimal.ToInt32(nudCantitate.Value);
            }
            else
                MessageBox.Show("Cantitatea adaugata nu poate fi 0!");
            this.Close();
        }

      // validari
        private void txtDenumire_Validating(object sender, CancelEventArgs e)
        {
            if (txtDenumire.Text.Length > 30)
            {
                MessageBox.Show("Denumire - Lungime maxima depasita!");
            }
            if (txtDenumire.Text.Equals(""))
            {
                
                MessageBox.Show("Campul denumire nu poate fi gol");
            }
        }

        private void txtDescriere_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescriere.Text.Length > 500)
            {
                MessageBox.Show("Descriere - Lungime maxima depasita!");
            }
        }

    }
}
