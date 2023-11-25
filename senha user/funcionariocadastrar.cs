using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senha_user
{
    public partial class funcionariocadastrar : Form
    {
        public funcionariocadastrar()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-6SFQBBR\SQLEXPRESS; integrated security=SSPI;initial catalog=PIM");

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

        //salvar dados funcionarios
        private void button4_Click(object sender, EventArgs e)
        {
            {
                // Obtenha os valores dos TextBoxes
                string cpf = textBox1.Text;
                string nome = textBox2.Text;
                string email = textBox3.Text;
                string cep = textBox4.Text;
                string endereco = textBox5.Text;
                string numeroCasa = textBox6.Text;
                string uf = textBox7.Text;
                string cidade = textBox8.Text;
                string bairro = textBox9.Text;

                // Insira os dados no banco de dados
                InserirDadosNoBanco(cpf, nome, email, cep, endereco, numeroCasa, uf, cidade, bairro);

                // Exiba uma mensagem de sucesso
                MessageBox.Show("Os dados foram salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpe os TextBoxes após a gravação
                LimparTextBoxes();
            }
            

        }

        private void InserirDadosNoBanco(string cpf, string nome, string email, string cep, string endereco, string numeroCasa, string uf, string cidade, string bairro)
        {
            // Conecte-se ao banco de dados e insira os dados aqui
            // Use ADO.NET ou um ORM (Object-Relational Mapping) como Entity Framework

            // Exemplo com ADO.NET (substitua pela sua string de conexão e comando SQL)
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-6SFQBBR\SQLEXPRESS; integrated security=SSPI;initial catalog=PIM"))
            {
                connection.Open();

                string insertQuery = "INSERT INTO dbo.Cadastrarfuncionario (CPF, Nome, Email, CEP, Endereco, NumeroCasa, UF, Cidade, Bairro) VALUES (@CPF, @Nome, @Email, @CEP, @Endereco, @NumeroCasa, @UF, @Cidade, @Bairro)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@CPF", cpf);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CEP", cep);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@NumeroCasa", numeroCasa);
                    command.Parameters.AddWithValue("@UF", uf);
                    command.Parameters.AddWithValue("@Cidade", cidade);
                    command.Parameters.AddWithValue("@Bairro", bairro);

                    command.ExecuteNonQuery();
                }
            }

        }
        private void LimparTextBoxes()
        {
            // Limpe os TextBoxes após a gravação
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

    }
}
