using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pripremaZaProvjeruZnanja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(cmbVrsta.Text, txtNaziv.Text, txtMarka.Text, dtpGodPro.Value, trckSnaga.Value);

            listaVozila.Add(vozilo);

            MessageBox.Show("Unos je uspiješan.", "Uspijeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        List<Vozilo> listaVozila = new List<Vozilo>();

        private void trckSnaga_Scroll(object sender, EventArgs e)
        {
            lblSnaga.Text = Convert.ToString(trckSnaga.Value);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            rtxtIspis.Clear();
            foreach (Vozilo vozilo in listaVozila)
            {
                rtxtIspis.AppendText(vozilo.ToString());
            }
        }
    }
}
