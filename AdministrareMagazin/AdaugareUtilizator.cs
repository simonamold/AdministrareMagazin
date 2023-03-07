using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrareMagazin
{
    public partial class AdaugareUtilizator : Form
    {
        private const string MSG_GOL = "Campul nu poate fi gol";
        private const string MSG_LUNG = "Lungimea maxima depasita!";
        private const int MAX_LUNG = 30;

        private Utilizator u = null;
        public AdaugareUtilizator(Utilizator u)
        {
            InitializeComponent();
            this.u = u;
        }

        // validari pentru continut
        private bool maxLenght(int lung)
        {
            return lung > MAX_LUNG;
        }

        private bool isEmpty(string text)
        {
            return text.Equals("");
        }

        private bool validContent(string text)
        {
            if (maxLenght(text.Length))
            {
                MessageBox.Show(MSG_LUNG);
                return false;
            }
            if(isEmpty(text))
            {
                MessageBox.Show(MSG_GOL);
                return false;
            }
            else
                return true;
            
        }

        // seteaza valorile campurilor userilor
        private void btnUAutentificare_Click(object sender, EventArgs e)
        {
            if (validContent(txtUNume.Text) && validContent(txtUPrenume.Text)
                && validContent(txtUser.Text) && validContent(txtParola.Text))
            {
                u.Nume = txtUNume.Text;
                u.Prenume = txtUPrenume.Text;
                u.Username = txtUser.Text;
                u.Parola = txtParola.Text;

               
                this.Close();
            }
           
        }
    }
}
