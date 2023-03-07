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
    public partial class ModificaCantitate : Form
    {
        private const string msgId = "Nu exista inregistrare pentru acest id!";
        private const string msgIdNumeric = "Introduceti Id numeric!";
        private const string cantitateInsuficienta = "Nu exista suficienta cantitate pentru stergere!";
        private const string msgSucces = "Modificat cu succes";
        public ModificaCantitate()
        {
            InitializeComponent();
           
        }

        // validari
        private bool isValidNumber(string number)
        {
            int rezult;
            return int.TryParse(number, out rezult);
        }

        private bool cantitatePozitiva(decimal val)
        {
            return val > 0;
        }

        private async Task cresteCantitatea(int id)
        {
            using (MagazinDbContext mdb = new MagazinDbContext())
            {
                var res = mdb.Produse.SingleOrDefault(p => p.Id == id);
                if (res != null)
                {
                    
                    res.Cantitate += decimal.ToInt32(nudAddQ.Value);
                    await mdb.SaveChangesAsync();
                    this.DialogResult = DialogResult.OK;
                   
                }
                else
                    MessageBox.Show(msgId);
            }
        }

        private void btnAddQ_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(txtId.Text);
            if (cantitatePozitiva(nudAddQ.Value))
            {
                var res = Task.Run(() => cresteCantitatea(id));
                res.Wait();
                this.Close();
            }

            else
                MessageBox.Show("Va rugam adaugati cantitatea de modificat!");
        }

   
        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if(!isValidNumber(txtId.Text))
            {
                MessageBox.Show(msgIdNumeric);
            }
        }

       
    }
}
