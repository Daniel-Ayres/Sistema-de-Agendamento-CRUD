using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prj_SalaoBeleza.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prj_SalaoBeleza.View
{
    public partial class Frm_CadClie : Form
    {
        public Frm_CadClie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cad_Click(object sender, EventArgs e)
        {

            try
            {
                // Dados de conexão com o banco de dados
                string connectionString = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

                // Dados do cliente a serem inseridos
                Cliente DadosClie = new Cliente();

                DadosClie.Nome1 = txtb_Nome.Text;
                DadosClie.Email1 = txtb_Email.Text;
                DadosClie.Telefone1 = txtb_Tel.Text;
                DadosClie.Endereco1 = txtb_Ender.Text;
                DadosClie.Cidade1 = txtb_Cid.Text;
                DadosClie.Estado1 = txtb_Esta.Text;
                DadosClie.Pais1 = txtb_Pais.Text;


                // Comando SQL para inserir os dados
                string query = "INSERT INTO clientes (nome, email, telefone, logradouro, cidade ,estado , pais) VALUES (@nome, @email, @telefone , @logradouro , @cidade, @estado ,@pais)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", DadosClie.Nome1);
                        command.Parameters.AddWithValue("@email", DadosClie.Email1);
                        command.Parameters.AddWithValue("@telefone", DadosClie.Telefone1);
                        command.Parameters.AddWithValue("@logradouro", DadosClie.Endereco1);
                        command.Parameters.AddWithValue("@cidade", DadosClie.Cidade1);
                        command.Parameters.AddWithValue("@estado", DadosClie.Estado1);
                        command.Parameters.AddWithValue("@pais", DadosClie.Pais1);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados do cliente inseridos com sucesso!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir dados do cliente no banco de dados: " + ex.Message);
            }
        }
    }
}
