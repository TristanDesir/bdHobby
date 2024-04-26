using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace wfa_hobby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void codePostalTextBox_Validating(object sender, CancelEventArgs e)
        {
            bool valide = Regex.IsMatch(codePostalTextBox.Text, "^([a-z-A-Z][0-9]){3}$");
            if (valide )
            {
                errorProvider1.Clear();
            }
            else
            {
                e.Cancel = true;//Bloque dans le textBox
                errorProvider1.SetError(codePostalTextBox, "Entrez un code postal valide : A1A1A1");
            }

          
        }
        private void debuterBouton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Le programme se ferait");
            }
            else
            {
                MessageBox.Show("Remplissez tous les champs");
            }
        }
    }
}
