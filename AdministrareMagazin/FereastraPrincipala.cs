using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrareMagazin
{
    public partial class FormMagazin : Form
    {
        public FormMagazin()
        {
            InitializeComponent();
            LoadData();
            dgvIstoricVanzari.Hide();
        }

        // incarca in grid view datele produselor
        private void LoadData()
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from p in mdb.Produse
                          select p;
                dgvProduct.DataSource = res.ToList();
            }
        }

        // incarca in grid view istoricul vanzarilor
        private void LoadDataVanzari()
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from p in mdb.istoricVanzari
                          select p;
                dgvIstoricVanzari.DataSource = res.ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvIstoricVanzari.Hide();
            dgvProduct.Show();
            LoadData();
        }
        
        // adaugare produs nou
        private async Task AddProduct(Produs p)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                mdb.Produse.Add(p);
                try {
                    await mdb.SaveChangesAsync();
                }
                catch (DbEntityValidationException) { }
            }
        }

        private void produsNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
            AddProduct ad = new AddProduct(produs);
            ad.ShowDialog();
            var res = Task.Run(() => AddProduct(produs));
            res.Wait();

            LoadData();
        }

        // cautare dupa denumire
        private void btnCautare_Click(object sender, EventArgs e)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from p in mdb.Produse
                          where p.Denumire.Equals(txtCautare.Text)
                          select p;

                dgvProduct.DataSource = res.ToList();
                txtCautare.Clear();

            }
        }

        // adaugare cantitate produselor deja existente
        private void modificareCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaCantitate modq = new ModificaCantitate();
            if (modq.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        // adauga utilizatori
        private async Task AddUtilizator(Utilizator u)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                mdb.Utilizatori.Add(u);
                try
                {
                    await mdb.SaveChangesAsync();
                }
                catch (DbEntityValidationException) { }
            }
        }
        private void autentificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizator u = new Utilizator();
            AdaugareUtilizator adu = new AdaugareUtilizator(u);
            adu.ShowDialog();
            var res = Task.Run(() => AddUtilizator(u));
            res.Wait();
        }

        private void listaUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUtilizatori ls = new ListaUtilizatori();
            ls.ShowDialog();
        }

        // vanzare produs
        private void dgvProduct_CellContentClick(object sender, EventArgs e)
        {
            int idProd;
            if (txtCautare.Text.Equals(""))
            {
                MessageBox.Show("Introduceti id-ul produsului in text box");
                txtCautare.Focus();
            }
            else
            {
                idProd = int.Parse(txtCautare.Text);
                using (MagazinDbContext mdb = new MagazinDbContext())
                {
                    var res = mdb.Produse.SingleOrDefault(p => p.Id == idProd);

                    if (res != null)
                    {
                        Vanzare vanzare = new Vanzare(res);
                        vanzare.ShowDialog();
                    }
                }
            }
            LoadData();
        }


        //cautare dupa id
        private void btnCautareId_Click(object sender, EventArgs e)
        {
            int idProd = int.Parse(txtCautare.Text);
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from p in mdb.Produse
                          where p.Id == idProd
                          select p;

                dgvProduct.DataSource = res.ToList();
            }
            txtCautare.Clear();
        }

        // afiseaza grid view-ul istoricului de vanzari
        private void istoricVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvProduct.Hide();
            dgvIstoricVanzari.Show();
            LoadDataVanzari();
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergereUtilizator sterge = new StergereUtilizator();
            sterge.ShowDialog();
        }
    }
}

