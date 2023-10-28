using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace senha_user
{
    public partial class telalogin : Form
    {
        //SqlConnection Conexao = new SqlConnection("Data Source=MICHELE\\SQLEXPRESS;Initial Catalog=LoginCharp;Integrated Security=True");

        SqlConnection Conexao = new SqlConnection("Data Source=DESKTOP-6SFQBBR\\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True;");

        public telalogin()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string usuario = (string)txtUsuario.Text;
            string senha = (string)txtPassword.Text;

            string connectionString = "Data Source=DESKTOP-6SFQBBR\\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True;";

            // Crie uma conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Agora você pode prosseguir com a recuperação dos dados do banco de dados.

                string query = "select funcionarioID, ds_login, ds_senha from funcionario " +
                    "WHERE ds_login = '" + usuario + "' and ds_senha='"+ senha + "'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                string funcionarioID = reader["funcionarioID"].ToString(); // Acesse a coluna "Nome" por nome
                                string ds_login = reader["ds_login"].ToString(); // Acesse a coluna "Nome" por nome
                                string ds_senha = reader["ds_senha"].ToString(); // Acesse a coluna "Nome" por nome
                                 

                                DialogResult result = MessageBox.Show($"Acesso permitido!\n\nID:{funcionarioID}\nLogin:{ds_login}\nSenha:{ds_senha}\n\nClique em OK para ser redirecionado para a próxima tela.", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                if (result == DialogResult.OK)
                                {
                                    //cria o objeto do formulário
                                    telainicial paginaInsert = new telainicial();
                                    paginaInsert.Show();
                                    //this é tela que vc está hide siginfica esconder
                                    this.Hide();
                                }

                            }


                        }
                        else {
                            MessageBox.Show("Acesso Negado Usuário e Senha Inválido!\nUsuario:" + usuario + "\nSenha" + senha, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }

                connection.Close();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
