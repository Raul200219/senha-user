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

namespace senha_user
{
    public partial class login : Form
    {
        

        public login()
        {
            InitializeComponent();

            

        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-6SFQBBR\SQLEXPRESS; integrated security=SSPI;initial catalog=PIM");

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;
            lblMensagemErro.Text = "";

            if (ValidarLogin(usuario, senha))
            {
                // Login bem-sucedido
                MessageBox.Show("Login bem-sucedido!");
                // Adicione aqui a lógica para abrir o próximo formulário ou realizar outras ações após o login.

                // Criar e exibir o novo formulário
                Home novoFormulario = new Home();  // Substitua Form2 pelo nome real do seu segundo formulário
                novoFormulario.Show();

                textBox2.Text = "";

                // Fechar o formulário atual (se necessário)
                this.Hide();
            }
            else
            {
                // Login falhou
                lblMensagemErro.Text = "Usuário ou senha inválidos.";
            }
        }


        private bool ValidarLogin(string usuario, string senha)
        {
            // Consulta SQL para verificar as credenciais no banco de dados
            string query = "SELECT COUNT(*) FROM dbo.funcionario WHERE ds_login = @Usuario AND ds_senha = @Senha";

            using (SqlCommand cmd = new SqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);



                conexao.Open();

                int count = (int)cmd.ExecuteScalar();

                conexao.Close();

                // Retorna verdadeiro se as credenciais são válidas
                return count > 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        
    }
}
