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
    public partial class Home : Form
    {
        
        

        public Home()
        {
            InitializeComponent();
           
            
        }

        //cliques dos botoes de menu

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

        //esconder menu

        private bool btncbovisible = true;
        private bool btnholeritevisible = true;
        private bool btnpanel2visible = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnpanel2visible)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }

            btnpanel2visible = !btnpanel2visible;


            if (btncbovisible)
            {
                btnCbo.Visible = false;
            }
            else
            {
                btnCbo.Visible = true;
            }

            btncbovisible = !btncbovisible;

            if (btnholeritevisible)
            {
                btnHolerite.Visible = false;
            }
            else
            {
                btnHolerite.Visible = true;
            }

            btnholeritevisible = !btnholeritevisible;

            
        }
    }
}
