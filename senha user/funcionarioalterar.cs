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
    public partial class funcionarioalterar : Form
    {
        public funcionarioalterar()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home redirectHome = new Home();
            this.Hide();
            redirectHome.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            funcionariobuscar redirectFuncionarioform = new funcionariobuscar();
            this.Hide();
            redirectFuncionarioform.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            empresabuscar redirectCdtempresaform = new empresabuscar();
            this.Hide();
            redirectCdtempresaform.Show();
        }

        private void btnCbo_Click(object sender, EventArgs e)
        {
            cbobuscar redirectCboform = new cbobuscar();
            this.Hide();
            redirectCboform.Show();
        }

        private void btnFolhadeponto_Click(object sender, EventArgs e)
        {
            folhadeponto redirectFolhadepontoform = new folhadeponto();
            this.Hide();
            redirectFolhadepontoform.Show();
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            holerite redirectHoleriteform = new holerite();
            this.Hide();
            redirectHoleriteform.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            funcionariobuscar redirectFuncionarioform = new funcionariobuscar();
            this.Hide();
            redirectFuncionarioform.Show();
        }
    }
}
