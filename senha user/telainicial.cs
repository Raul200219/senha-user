using System;
using System.Collections;
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
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
        }

        private void testeInsert_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-6SFQBBR\\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True;";

            // Crie uma conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Agora você pode prosseguir com a recuperação dos dados do banco de dados.

                string query = "select funcionarioID, ds_login, ds_senha from funcionario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Preencha o DataGridView com os dados
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }

                connection.Close();
            }

            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
