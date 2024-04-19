using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_hobby
{
    public partial class AssocierHobbyEtudiantForm : Form
    {
        public AssocierHobbyEtudiantForm()
        {
            InitializeComponent();
        }

        private void etudiantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hobbyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void etudiantComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ManagerEtudiantHobby managerEtudiantHobby = new ManagerEtudiantHobby();
            hobbyDataGridView.DataSource = managerEtudiantHobby.ListerHobbyDUnEtudiant((int)etudiantComboBox.SelectedValue);
            hobbyDataGridView.Columns["no_hobby"].Visible = false;
            hobbyDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hobbyDataGridView.RowHeadersVisible = false;
            hobbyDataGridView.
        }

        private void hobbyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssocierHobbyEtudiantForm_Load(object sender, EventArgs e)
        {
            remplirComboBoxEtudiant();

        }
    }
}
