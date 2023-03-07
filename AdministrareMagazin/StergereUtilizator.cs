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
    public partial class StergereUtilizator : Form
    {
        private ErrorProvider err = new ErrorProvider();
        public StergereUtilizator()
        {
            InitializeComponent();
        }

        // verifica id-ul si parola si cere confirmare de stergere de la user
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            using(MagazinDbContext mdb = new MagazinDbContext())
            {
                string parola = txtParola.Text;
                int idUser = int.Parse(txtIdStergere.Text);
                var res = mdb.Utilizatori.SingleOrDefault(u => u.Id == idUser);
                if(res == null)
                {
                    MessageBox.Show("Id-ul intodus nu exista!");
                }
                else
                {
                    if(res.Parola.Equals(parola))
                    {
                        YesNo ys = new YesNo();
                        ys.ShowDialog();
                        if(ys.DialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Utilizatorul nu a fost sters");
                            this.Close();
                        }
                        else
                        {
                            mdb.Utilizatori.Remove(res);
                            mdb.SaveChanges();
                            MessageBox.Show("Utilizator sters cu succes!");
                            this.Close();
                        }
                    }
                }
            }
        }

        // validari textbox
        private void txtIdStergere_Validating(object sender, CancelEventArgs e)
        {
            if (txtIdStergere.Text.Equals(""))
            {
                e.Cancel = true;
                txtIdStergere.Focus();
                err.SetError(txtIdStergere, "Camp Gol");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtIdStergere, "");
            }
        }

        private void txtParola_Validating(object sender, CancelEventArgs e)
        {
            if (txtParola.Text.Equals(""))
            {
                e.Cancel = true;
                txtParola.Focus();
                err.SetError(txtParola, "Camp Gol");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtParola, "");
            }
        }
    }
}
