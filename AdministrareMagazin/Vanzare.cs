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
    public partial class Vanzare : Form
    {
        private IstoricVanzari ist;
        private ErrorProvider err = new ErrorProvider();
        int idProdus;

        
        public Vanzare(Produs p)
        {
            InitializeComponent();
            ist = new IstoricVanzari();
            idProdus = p.Id;
            ist.DenumireProdus = p.Denumire;
            ist.Cantitate= p.Cantitate;

        }

        // veifica id-ul produsului si cantitatea din stoc 
        // modifica cantitatea sau sterge produsul din bd in unctie de stoc
        private async Task vanzare(int idProd)
        {
            int idUser = int.Parse(txtIDUser.Text);
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var iduser = mdb.Utilizatori.SingleOrDefault(u => u.Id == idUser);
                if (iduser == null)
                {
                    MessageBox.Show("Id User inexistent!");
                    return;
                }
                else {
                    this.ist.IdUser = idUser;
                    var res = mdb.Produse.SingleOrDefault(p => p.Id == idProd);
                    if (res != null)
                    {
                        if (res.Cantitate > 0)
                        {
                            if (res.Cantitate < decimal.ToInt32(nudVanzare.Value))
                            {
                                MessageBox.Show("Stoc insuficient");
                                return;
                            }
                            else if (res.Cantitate == decimal.ToInt32(nudVanzare.Value))
                            {
                                mdb.Produse.Remove(res);
                                mdb.istoricVanzari.Add(ist);
                                // await mdb.SaveChangesAsync();
                            }
                            else
                            {
                                res.Cantitate -= decimal.ToInt32(nudVanzare.Value);
                                MessageBox.Show("Vandut cu succes");
                                mdb.istoricVanzari.Add(ist);
                            }
                            await mdb.SaveChangesAsync();
                        }
                    }
                }
            } 
        }

        private void btnVanzare_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext()) 
            {
                var res = Task.Run(() => vanzare(idProdus));
                res.Wait();

                this.Close();
            }    
        }

        private void txtIDUser_Validating(object sender, CancelEventArgs e)
        {
            if (txtIDUser.Text.Equals("")) {
                e.Cancel = true;
                txtIDUser.Focus();
                err.SetError(txtIDUser, "Camp Gol");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtIDUser, "");
            }
        }

    }
}

