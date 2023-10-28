using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senha_user
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void empregosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empregosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet1.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter1.Fill(this.masterDataSet1.Funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.masterDataSet.Funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Empregos'. Você pode movê-la ou removê-la conforme necessário.
            this.empregosTableAdapter.Fill(this.masterDataSet.Empregos);

        }

        private void iDLabel_Click(object sender, EventArgs e)
        {

        }

        private void funcionariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empregosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void nomeCompletoLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeCompletoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
