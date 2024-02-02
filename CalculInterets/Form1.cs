using System.Diagnostics;
using System.Globalization;

namespace CalculInterets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRaz_Click(object sender, EventArgs e)
        {
            txtCapitalDepart.Text = "10000 €";
            txtNombreAnnees.Text = "10";
            txtTauxInteret.Text = (7.5).ToString() + " %";
        }


        private void btnCalculer_Click(object sender, EventArgs e)
        {
            double capitalDepart = double.Parse(txtCapitalDepart.Text.TrimEnd(' ', '€'));
            Debug.WriteLine(capitalDepart);
            double tauxInterets = double.Parse(String.Format("{0:0.00}", txtTauxInteret.Text.TrimEnd(' ', '%')));
            Debug.WriteLine(tauxInterets);
            double nombreAnnees = double.Parse(txtNombreAnnees.Text);
            Debug.WriteLine(nombreAnnees);

            double resultat = capitalDepart;
            for (double i = 1.0; i <= nombreAnnees; i++)
            {
                resultat *= 1 + tauxInterets / 100;
                Debug.WriteLine("Iteration " + i);
            }

            lblResultat.Text = "Resutat : " + resultat.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCapitalDepart_Leave(object sender, EventArgs e)
        {
            if (!txtCapitalDepart.Text.Contains(" €"))
            {
                txtCapitalDepart.Text = txtCapitalDepart.Text.TrimEnd(' ');
                txtCapitalDepart.Text = txtCapitalDepart.Text.TrimEnd('€');
                txtCapitalDepart.Text += " €";
            }
        }

        private void txtTauxInteret_Leave(object sender, EventArgs e)
        {
            if (!txtTauxInteret.Text.Contains(" %"))
            {
                txtTauxInteret.Text = txtTauxInteret.Text.TrimEnd(' ');
                txtTauxInteret.Text = txtTauxInteret.Text.TrimEnd('%');
                txtTauxInteret.Text += " %";
            }
        }

        private void txtCapitalDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtTauxInteret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtNombreAnnees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter) {
                e.Handled = true;
                if(e.KeyChar != (char)Keys.Enter)
                {
                    btnCalculer.PerformClick();
                }
            }
        }
    }
}