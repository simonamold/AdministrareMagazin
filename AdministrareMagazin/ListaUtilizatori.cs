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
    public partial class ListaUtilizatori : Form
    {
        public ListaUtilizatori()
        {
            InitializeComponent();
        }

        // incarca datele in grid view sans parola
        private void LoadUserData()
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = from p in mdb.Utilizatori
                          select new {
                          p.Id,
                          p.Nume,
                          p.Prenume,
                          p.Username };
                dgvUtilizatori.DataSource = res.ToList();
            }
        }

        private void btnRefreshU_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void ListaUtilizatori_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
